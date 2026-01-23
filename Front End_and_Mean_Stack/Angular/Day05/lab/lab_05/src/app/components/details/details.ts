import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-details',
  imports: [],
  templateUrl: './details.html',
  styleUrl: './details.css',
})
export class Details {
  userId = 0;

  constructor(route: ActivatedRoute) {
    this.userId = Number(route.snapshot.paramMap.get('id'));
  }
}
