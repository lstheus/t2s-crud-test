import { Component } from '@angular/core';
import { ClienteService } from 'src/app/shared/services/cliente.service';
import { cliente } from 'src/app/shared/models/cliente';

@Component({
  selector: 'app-clientes',
  templateUrl: './clientes.component.html',
  styleUrls: ['./clientes.component.css']
})
export class ClientesComponent {
clientes!:cliente[];

constructor(private clienteService : ClienteService) {


}
ngOnInit(): void
{
  this.clienteService.get().subscribe({
    next:(client)=> {this.clientes = client},
    error: (err)=> console.log(err)
  })
}
}
