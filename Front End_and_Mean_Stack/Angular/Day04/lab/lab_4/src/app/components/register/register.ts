import { Component, EventEmitter, Output } from '@angular/core';
import {
  FormControl,
  FormGroup,
  FormsModule,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';

@Component({
  selector: 'app-register',
  imports: [FormsModule, ReactiveFormsModule],
  standalone: true,
  templateUrl: './register.html',
  styleUrls: ['./register.css'],
})
export class Register {
  @Output() registerEvent = new EventEmitter();

  isSubmitted = false;
  studentForm: FormGroup = new FormGroup({
    name: new FormControl(null, [
      Validators.required,
      Validators.minLength(3),
      Validators.maxLength(50),
    ]),
    age: new FormControl(null, [Validators.required, Validators.min(20), Validators.max(30)]),
  });

  addStudent() {
    // console.log('added');
    console.log(this.studentForm.value);
    console.log(this.studentForm.valid);

    this.isSubmitted = true;
    if (this.studentForm.valid) {
      this.registerEvent.emit(this.studentForm.value);
      this.studentForm.reset();
      this.isSubmitted = false;
    }
  }
}
