import { Component } from '@angular/core';
import { Students } from '../students/students';
import { Register } from '../register/register';
import { student } from '../../utiles/student';

@Component({
  selector: 'app-parent',
  standalone: true,
  imports: [Students, Register],
  templateUrl: './parent.html',
  styleUrls: ['./parent.css'],
})
export class Parent {
  users: student[] = [];
  getDataFromRegister(data: any) {
    // console.log(data);
    this.users.push(data);
    // console.log(this.users);
  }
}
