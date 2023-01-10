import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { first } from 'rxjs';
import { ConteinerService } from 'src/app/shared/services/conteiner.service';

@Component({
  selector: 'app-criar-editar-conteiner',
  templateUrl: './criar-editar-conteiner.component.html',
  styleUrls: ['./criar-editar-conteiner.component.css']
})
export class CriarEditarConteinerComponent {
  isAddMode!: boolean;
  id!: string;
  conteinerForm!: FormGroup;
  submitted = false;
  constructor(private conteinerService: ConteinerService, private fb: FormBuilder, private router: Router, private route: ActivatedRoute) {

  }
  ngOnInit(): void {
    this.id = this.route.snapshot.params['code'];
    this.isAddMode = !this.id;
    this.conteinerForm = this.fb.group({
      codigo: [this.id,[Validators.required]],
      clienteId: ['', [Validators.required]],
      tipo: ['', [Validators.required]],
      status: ['', [Validators.required]],
      categoria: ['', [Validators.required]]
    })

    if (!this.isAddMode) {
      this.conteinerService.getById(this.id).pipe(first()).subscribe({
        next: (conteiner) => {
          this.conteinerForm.patchValue(conteiner);

          console.log(conteiner);
        }
        , error: (err) => {
          console.log(err)
        }

      })
    }

  }
  get f(){
    return this.conteinerForm.controls;
  }
  onSubmit() {
    this.submitted = true;
    if (!this.conteinerForm.valid) return;
    if (this.isAddMode) {
      this.createConteiner()
    } else {
      this.updateConteiner()
    }
  }
  private createConteiner() {
    this.conteinerService.post(this.conteinerForm.value).pipe(first()).subscribe({
      next: (success) => {
        this.router.navigateByUrl('/conteiner');

      },
      error: (err) => {
        console.log(err);
        return;
      }
    })
  }
  private updateConteiner() {
    this.conteinerService.put(this.id, this.conteinerForm.value).pipe(first()).subscribe({
      next: (success) => {
        this.router.navigateByUrl('/conteiner');
      },
      error: (err) => {
        console.log(err);
        return;
      }
    })
  }
}
