import { Component } from '@angular/core';
import { first } from 'rxjs';
import { movimentacoes } from 'src/app/shared/models/movimentacoes';
import { MovimentacoesService } from 'src/app/shared/services/movimentacoes.service';

@Component({
  selector: 'app-movimentacoes',
  templateUrl: './movimentacoes.component.html',
  styleUrls: ['./movimentacoes.component.css']
})
export class MovimentacoesComponent {
  movimentacoes!: movimentacoes[];
  constructor(private movimentacoesService: MovimentacoesService) {

  }
  ngOnInit() {
    this.movimentacoesService.get().pipe(first()).subscribe({
      next: (movimentacoes) => { this.movimentacoes = movimentacoes },
      error: (err) => {
        console.log(err);
      }
    });


  }
    onDelete(id: number) {
    this.movimentacoesService.delete(id).pipe(first()).subscribe(
      {
        next: (movimentacoes) => {
          location.reload();
        },
        error: (err) => console.log(err)
      }
    )
  }
}
