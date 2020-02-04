import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http";
@Injectable({
  providedIn: "root"
})
export class CardService {
  constructor(private http: HttpClient) {}
  getArticle(){
    return this.http.get("http://localhost:50137/getArticles");
  }
  
}

