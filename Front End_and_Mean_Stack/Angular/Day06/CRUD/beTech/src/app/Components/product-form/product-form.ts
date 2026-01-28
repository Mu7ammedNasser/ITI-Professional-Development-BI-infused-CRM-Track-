import { Component, inject, OnInit, signal } from '@angular/core';
import { FormBuilder, FormGroup, Validators, ReactiveFormsModule } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { CommonModule } from '@angular/common';
import { ProductService } from '../../Core/Services/product-service';
import { Header } from '../header/header';
import { Footer } from '../footer/footer';

@Component({
  selector: 'app-product-form',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule, Header, Footer], // Add CommonModule
  templateUrl: './product-form.html',
  styleUrls: ['./product-form.css'],
})
export class ProductForm implements OnInit {
  private fb = inject(FormBuilder);
  private route = inject(ActivatedRoute);
  private router = inject(Router);
  private productService = inject(ProductService);

  productForm!: FormGroup;
  isEditMode = signal<boolean>(false);
  productId = signal<string | null>(null);
  loading = signal<boolean>(false);
  error = signal<string | null>(null);

  ngOnInit() {
    this.initForm();

    // Check if we're in edit mode
    this.route.paramMap.subscribe((params) => {
      const id = params.get('id');

      if (id) {
        this.isEditMode.set(true);
        this.productId.set(id);
        this.loadProduct(id);
      }
    });
  }

  initForm() {
    this.productForm = this.fb.group({
      name: ['', [Validators.required, Validators.minLength(3)]],
      productCode: ['', Validators.required],
      description: ['', Validators.required],
      brand: ['', Validators.required],
      price: [0, [Validators.required, Validators.min(0)]],
      stock: [0, [Validators.required, Validators.min(0)]],
      categoryId: ['', Validators.required],
      isAvailable: [true],
      features: [''], // Can be comma-separated string
    });
  }

  loadProduct(id: string) {
    this.loading.set(true);
    this.productService.getProductById(+id).subscribe({
      next: (product) => {
        this.productForm.patchValue({
          name: product.name,
          productCode: product.productCode,
          description: product.description,
          brand: product.brand,
          price: product.price,
          stock: product.stock,
          categoryId: product.categoryId,
          isAvailable: product.isAvailable,
          features: product.features?.join(', ') || '',
        });
        this.loading.set(false);
      },
      error: (err) => {
        console.error(err);
        this.error.set('Failed to load product');
        this.loading.set(false);
      },
    });
  }

  onSubmit() {
    if (this.productForm.valid) {
      this.loading.set(true);

      const formValue = this.productForm.value;

      // Convert features string to array
      const productData = {
        ...formValue,
        features: formValue.features
          ? formValue.features.split(',').map((f: string) => f.trim())
          : [],
        rating: 0, // Default rating for new products
        photos: {
          thumbnail: 'assets/phonejpg.jpg',
          gallery: [],
        },
      };

      if (this.isEditMode()) {
        // Update existing product
        this.productService.updateProduct(+this.productId()!, productData).subscribe({
          next: () => {
            this.loading.set(false);
            this.router.navigate(['/products']);
          },
          error: (err) => {
            console.error(err);
            this.error.set('Failed to update product');
            this.loading.set(false);
          },
        });
      } else {
        // Create new product
        this.productService.createProduct(productData).subscribe({
          next: () => {
            this.loading.set(false);
            this.router.navigate(['/products']);
          },
          error: (err) => {
            console.error(err);
            this.error.set('Failed to create product');
            this.loading.set(false);
          },
        });
      }
    } else {
      // Mark all fields as touched to show validation errors
      Object.keys(this.productForm.controls).forEach((key) => {
        this.productForm.get(key)?.markAsTouched();
      });
    }
  }

  onCancel() {
    this.router.navigate(['/products']);
  }

  // Helper method to check if field has error
  hasError(fieldName: string, errorType: string): boolean {
    const field = this.productForm.get(fieldName);
    return !!(field?.hasError(errorType) && field?.touched);
  }
}
