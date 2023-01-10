import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'category'
})
export class CategoryPipe implements PipeTransform {

  transform(value: number): string {
    switch(value){
      case 1: return 'Importação';
      case 2 : return 'Exportação';
    }
    return ''
  }

}
