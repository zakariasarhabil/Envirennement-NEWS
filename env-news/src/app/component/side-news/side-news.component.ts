import { Component, OnInit } from "@angular/core";

@Component({
  selector: "app-side-news",
  templateUrl: "./side-news.component.html",
  styleUrls: ["./side-news.component.css"]
})
export class SideNewsComponent implements OnInit {
  constructor() {}
  cards = [
    {
      title: "card1",
      description:
        "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,",
      image: "https://picsum.photos/200/300"
    },
    {
      title: "card2",
      description:
        "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,2",
      image: "https://picsum.photos/200/300"
    },
    {
      title: "card3",
      description:
        "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, 3",
      image: "https://picsum.photos/200/300"
    },
    {
      title: "card4",
      description:
        "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, 4",
      image: "https://picsum.photos/200/300"
    },
    {
      title: "card5",
      description:
        "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, 5",
      image: "https://picsum.photos/200/300"
    }
  ];

  ngOnInit() {}
}
