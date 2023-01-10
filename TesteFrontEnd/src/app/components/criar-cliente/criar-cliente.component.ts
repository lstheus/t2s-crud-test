import { Component } from '@angular/core';
import {
  UntypedFormBuilder,
  Validators,
  FormGroup,
  FormBuilder,
} from '@angular/forms';
import { Router } from '@angular/router';
import { ClienteService } from 'src/app/shared/services/cliente.service';
@Component({
  selector: 'app-criar-cliente',
  templateUrl: './criar-cliente.component.html',
  styleUrls: ['./criar-cliente.component.css']
})
export class CriarClienteComponent {
  clientForm!: FormGroup;
  constructor(private fb:FormBuilder, private router: Router, private clienteService: ClienteService) {

  }
  ngOnInit():void{
    this.clientForm = this.fb.group({
      nome: ['',[Validators.required, Validators.maxLength(50)]]
    })
  }
  onSubmit() {
    if (!this.clientForm.valid) return;
    this.createCliente();
  }
  get f(){
    return this.clientForm.controls;
  }
  private createCliente() {
    this.clienteService.post(this.clientForm.value).subscribe({
      next: (success) => {
        this.router.navigateByUrl('/clientes')
      },
      error: (err) => {
        if (err.status >= 400) {
          console.log(err);
          this.router.navigateByUrl('/');
        }
      }
    })
  }

}