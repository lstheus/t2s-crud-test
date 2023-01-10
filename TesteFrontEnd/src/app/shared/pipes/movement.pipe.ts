import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'movement'
})
export class MovementPipe implements PipeTransform {

  transform(value: number): string {
    switch (value) {
      case 1: return 'Embarque';
      case 2: return 'Descarga';
      case 3: return 'Gate in';
      case 4: return 'Gate out';
      case 5: return 'Reposicionamento';
      case 6: return 'Pesagem';
      case 7: return 'Scanner';
    }
    return '';
  }

}
