import { Directive, ElementRef, HostListener } from '@angular/core';

@Directive({
  selector: '[appCustom]',
})
export class Custom {
  constructor(private el: ElementRef) {}

  @HostListener('mouseover')
  onMouseEnter() {
    this.el.nativeElement.style.backgroundColor = '#f0f3f2';
    this.el.nativeElement.style.cursor = 'pointer';
  }

  @HostListener('mouseleave')
  onMouseLeave() {
    this.el.nativeElement.style.backgroundColor = '';
    this.el.nativeElement.style.cursor = '';
  }
}
