import { ChangeDetectorRef, Component, inject, OnInit, signal } from '@angular/core';
import { Header } from '../header/header';
import { ProductCard } from '../product-card/product-card';
import { ProductService } from '../../Core/Services/product-service';

@Component({
  selector: 'app-products',
  imports: [Header, ProductCard],
  standalone: true,
  templateUrl: './products.html',
  styleUrls: ['./products.css'],
}) 
export class Products implements OnInit {
  private _products = inject(ProductService);
  items = signal<any[]>([]);

  ngOnInit() {
    this._products.getAllProducts().subscribe({
      next: (data) => {
        console.log(data);
        this.items.set(data);
      },
      error: (error) => {
        console.error('Error fetching products:', error);
      },
    });
  }
}


