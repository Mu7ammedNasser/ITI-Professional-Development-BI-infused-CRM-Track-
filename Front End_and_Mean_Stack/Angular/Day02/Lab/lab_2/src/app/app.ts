import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { Slider } from "./components/slider/slider";
import { User } from "./components/user/user";

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, Slider, User],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('lab_2');
}
