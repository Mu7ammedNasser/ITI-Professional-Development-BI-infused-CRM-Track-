import { join } from 'node:path';
import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'custom',
})
export class CustomPipe implements PipeTransform {
  transform(value: string, ...args: unknown[]): string {
    if (!value) return '';
    return value
      .split(' ')
      .map((word) => word[0].toLocaleUpperCase())
      .join('');
  }
}
