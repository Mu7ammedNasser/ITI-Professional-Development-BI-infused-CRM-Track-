import { HttpClient } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class ProductService {
  private readonly _httpclient = inject(HttpClient);
  getAllProducts(): Observable<any> {
    {
      return this._httpclient.get('http://localhost:3000/products');
    }
  }

  getProductById(id: number): Observable<any> {
    return this._httpclient.get(`http://localhost:3000/products/${id}`);
  }

  deleteProduct(id: number): Observable<any> {
    return this._httpclient.delete(`http://localhost:3000/products/${id}`);
  }

  createProduct(productData: any): Observable<any> {
    return this._httpclient.post('http://localhost:3000/products', productData);
  }

  updateProduct(id: number, productData: any): Observable<any> {
    return this._httpclient.put(`http://localhost:3000/products/${id}`, productData);
  }
}
