import { Component, EventEmitter, Output } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-register',
  imports: [FormsModule],
  standalone: true,
  templateUrl: './register.html',
  styleUrls: ['./register.css'],
})
export class Register {
  @Output() registerEvent = new EventEmitter();

  name: string = '';
  age: number | null = null;

  addStudent() {
    console.log('added');
    this.registerEvent.emit({ name: this.name, age: this.age});
  }
}    
