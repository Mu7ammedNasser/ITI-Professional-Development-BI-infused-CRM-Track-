import { student } from './../../utiles/student';
import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-students',
  imports: [],
  templateUrl: './students.html',
  styleUrl: './students.css',
})
export class Students {
  @Input() students: student[] = [];
}
