import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Register } from './components/register/register';
import { Students } from './components/students/students';
import { Parent } from './components/parent/parent';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, Register, Students, Parent],
  templateUrl: './app.html',
  styleUrl: './app.css',
})
export class App {}
