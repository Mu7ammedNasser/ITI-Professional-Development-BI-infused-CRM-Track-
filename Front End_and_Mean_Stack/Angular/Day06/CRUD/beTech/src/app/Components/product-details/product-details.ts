import { Component, inject, OnInit, signal } from '@angular/core';
import { ActivatedRoute, Router, RouterLink } from '@angular/router'; // ✓ Correct import
import { ProductService } from './../../Core/Services/product-service';
import { Header } from '../header/header';
import { Footer } from "../footer/footer";

@Component({
  selector: 'app-product-details',
  imports: [Header, RouterLink, Footer],
  standalone: true,
  templateUrl: './product-details.html',
  styleUrl: './product-details.css',
})
export class ProductDetails implements OnInit {
  private _route = inject(ActivatedRoute); 
  private _productService = inject(ProductService);
  private _router = inject(Router);

  product = signal<any>(null);
  loading = signal<boolean>(true);
  error = signal<string | null>(null);

  ngOnInit() {
    this._route.paramMap.subscribe((params) => {
      const id = params.get('id');
      if (id) {
        this.loading.set(true);
        this._productService.getProductById(+id).subscribe({
          next: (data) => {
            console.log(data);
            this.product.set(data);
            this.loading.set(false);
          },
          error: (err) => {
            console.error(err);
            this.error.set('Failed to load product');
            this.loading.set(false);
          },
        });
      }
    });
  }

  deleteProduct() {
    const id = this.product().id;
    if (id && confirm('Are you sure you want to delete this product?')) {
      this._productService.deleteProduct(id).subscribe({
        next: () => {
          alert('Product deleted successfully');
          this._router.navigate(['/products']);
          // Optionally, navigate away after deletion
        },
        error: (err) => {
          console.error(err);
          alert('Failed to delete product');
        },
      });
    }
  }
}
