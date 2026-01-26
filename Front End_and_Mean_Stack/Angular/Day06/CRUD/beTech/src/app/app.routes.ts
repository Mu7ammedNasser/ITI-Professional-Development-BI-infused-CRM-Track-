import { Routes } from '@angular/router';
import { Home } from './Components/home/home';
import { ProductDetails } from './Components/product-details/product-details';
import { ProductForm } from './Components/product-form/product-form';
import { NotFounded } from './Components/not-founded/not-founded';

export const routes: Routes = [
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: 'home', component: Home },
  { path: 'product-details/:id', component: ProductDetails },
  { path: 'product-form', component: ProductForm },
  { path: '**', component: NotFounded },
];
