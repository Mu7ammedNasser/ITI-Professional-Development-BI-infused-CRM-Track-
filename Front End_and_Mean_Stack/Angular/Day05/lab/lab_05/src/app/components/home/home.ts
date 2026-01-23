import { UpperCasePipe } from '@angular/common';
import { Component } from '@angular/core';
import { CustomPipe } from '../../core/pipes/custom-pipe';
import { Custom } from '../../core/directive/custom';

@Component({
  selector: 'app-home',
  imports: [UpperCasePipe, CustomPipe , Custom],
  templateUrl: './home.html',
  styleUrl: './home.css',
})
export class Home {
  name: string = 'Mohamed Nasser';
}
