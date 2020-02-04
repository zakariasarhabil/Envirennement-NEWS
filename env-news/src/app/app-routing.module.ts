import { SliderComponent } from './component/slider/slider.component';
import { ArticleComponent } from "./component/article/article.component";
import { HomeComponent } from "./component/home/home.component";
import { NgModule, Component } from "@angular/core";
import { Routes, RouterModule } from "@angular/router";
import { ContactComponent } from "./component/contact/contact.component";

const routes: Routes = [
  { path: "", redirectTo: "/home", pathMatch: "full" },
  { path: "contact", component: ContactComponent },
  { path: "home", component: HomeComponent },
  { path: "article", component: SliderComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}
