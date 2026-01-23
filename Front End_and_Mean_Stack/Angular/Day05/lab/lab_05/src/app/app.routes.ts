import { Routes } from '@angular/router';
import { Home } from './components/home/home';
import { About } from './components/about/about';
import { ContacUs } from './components/contac-us/contac-us';
import { Details } from './components/details/details';
import { Users } from './components/users/users';
import { Error } from './components/error/error';

export const routes: Routes = [
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: 'home', component: Home },
  { path: 'about', component: About },
  { path: 'contact-us', component: ContacUs },
  { path: 'users/:id', component: Details },
  { path: 'users', component: Users },
  { path: '**', component: Error },
];
