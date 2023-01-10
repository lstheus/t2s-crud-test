import { Component } from '@angular/core';
import { first } from 'rxjs';
import { conteiner } from 'src/app/shared/models/conteiner';
import { ConteinerService } from 'src/app/shared/services/conteiner.service';

@Component({
  selector: 'app-conteiner',
  templateUrl: './conteiner.component.html',
  styleUrls: ['./conteiner.component.css'],
})
export class ConteinerComponent {
  conteiners!: conteiner[];
  constructor(private conteinerService: ConteinerService) {
  }
  ngOnInit() {
    this.conteinerService.get().subscribe({
      next: (conteiner) => {
        console.log(conteiner)
        this.conteiners = conteiner;

      },
      error: (err) => console.log(err)
    })
  }
  onDelete(code: string) {
    this.conteinerService.delete(code).pipe(first()).subscribe(
      {
        next: (conteiner) => {
        location.reload();
        },
        error: (err) => console.log(err)
      }
    )
  }
}
