import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'type'
})
export class TypePipe implements PipeTransform {

 transform(value: number): string {
    switch(value){
      case 1: return '20';
      case 2 : return '40';
    }
    return ''
  }
}
