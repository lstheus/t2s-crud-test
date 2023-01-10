import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { first } from 'rxjs';
import { conteiner } from 'src/app/shared/models/conteiner';
import { ConteinerService } from 'src/app/shared/services/conteiner.service';
import { MovimentacoesService } from 'src/app/shared/services/movimentacoes.service';

@Component({
  selector: 'app-criar-editar-movimentacoes',
  templateUrl: './criar-editar-movimentacoes.component.html',
  styleUrls: ['./criar-editar-movimentacoes.component.css']
})
export class CriarEditarMovimentacoesComponent {
  isAddMode!: boolean;
  id!: number;
  movementForm!: FormGroup;
  submitted = false;
  constructor(private movementService: MovimentacoesService, private fb: FormBuilder, private router: Router, private route: ActivatedRoute) {

  }
  ngOnInit(): void {
    this.id = this.route.snapshot.params['id'];
    this.isAddMode = !this.id;
    if (this.id == null) {
      this.id = 0;
    }


    if (!this.isAddMode) {
      this.movementService.getById(this.id).pipe(first()).subscribe({
        next: (movement) => {
          this.movementForm.patchValue(movement);
          console.log(movement);
        }
        , error: (err) => console.log(err)
      })
    }
    this.movementForm = this.fb.group({
      id: [this.id],
      codigoConteiner: ['', [Validators.required]],
      tipoMov: ['', [Validators.required]],
      dtInicio: ['', [Validators.required]],
      dtFinal: ['', [Validators.required]]
    });

  }
  get f(){
    return this.movementForm.controls;
  }
  onSubmit() {
    this.submitted = true;
    if (!this.movementForm.valid) return;
    if (this.isAddMode) {
      this.createMovement();
    } else {
      this.updateMovement();
    }
  }

  private createMovement() {
    this.movementService.post(this.movementForm.value).pipe(first()).subscribe({
      next: (success) => {
        console.log(this.movementForm.value);
        console.log(success);
        this.router.navigateByUrl('/movimentacoes');
      },
      error: (err) => {
        console.log(err);
        return;
      }
    })
  }
  private updateMovement() {
    this.movementService.put(this.id, this.movementForm.value).pipe(first()).subscribe({
      next: (success) => {
        this.router.navigateByUrl('/movimentacoes');
      },
      error: (err) => {
        console.log(err);
        return;
      }
    })
  }
}
