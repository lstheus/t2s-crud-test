import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'status'
})
export class StatusPipe implements PipeTransform {
  transform(value: number): string {
    switch (value) {
      case 1: return 'Cheio';
      case 2: return 'Vazio';
    }
    return '';
  }

}
