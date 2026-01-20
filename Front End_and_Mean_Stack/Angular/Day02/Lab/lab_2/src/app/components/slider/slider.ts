import { ChangeDetectorRef, Component } from '@angular/core';

@Component({
  selector: 'app-slider',
  imports: [],
  templateUrl: './slider.html',
  styleUrl: './slider.css',
})
export class Slider {
  constructor(private ref: ChangeDetectorRef) {}

  images: string[] = [
    './assets/1.jpg',
    './assets/2.jpg',
    './assets/3.jpg',
    './assets/4.jpg',
    './assets/5.jpg',
    './assets/6.jpg',
  ];

  currentIndex: number = 0;

  intervalId: any;

  prevImage() {
    if (this.currentIndex > 0) {
      this.currentIndex--;
      console.log(this.currentIndex);
    }
  }
  nextImage() {
    if (this.currentIndex < this.images.length - 1) {
      this.currentIndex++;
      console.log(this.currentIndex);
    }
  }
  play() {
    // if (this.intervalId) return;
    this.intervalId = setInterval(() => {
      this.ref.detectChanges();
      this.currentIndex = (this.currentIndex + 1) % this.images.length;
    }, 500);
  }
  stop() {
    clearInterval(this.intervalId);
  }
}
