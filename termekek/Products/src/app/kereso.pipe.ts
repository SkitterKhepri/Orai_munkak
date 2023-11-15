import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'kereso',
  standalone: true
})
export class KeresoPipe implements PipeTransform {

  transform(value: unknown, ...args: unknown[]): unknown {
    return null;
  }

}
