import { Component } from '@angular/core';
import { RouterLink } from "@angular/router";
import { Header } from "../header/header";
import { Footer } from "../footer/footer";
import { ProductForm } from "../product-form/product-form";

@Component({
  selector: 'app-home',
  imports: [RouterLink, Header, Footer, ProductForm],
  templateUrl: './home.html',
  styleUrl: './home.css',
})
export class Home {

}
