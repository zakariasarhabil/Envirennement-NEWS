import { Article } from './../../Model/article.model';
import { CardService } from './../../services/card.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-slider',
  templateUrl: './slider.component.html',
  styleUrls: ['./slider.component.css']
})
export class SliderComponent implements OnInit {

  constructor(private art:CardService) {

   }
   arts:Article[]=[]
 
  ngOnInit() {
    this.getAllarticles()

  }
  getAllarticles()
  {
    this.art.getArticle().subscribe((res:Article[])=>
    {
     this.arts=res
     console.log("my first api")
     console.log(this.arts)

    })
  }

}
