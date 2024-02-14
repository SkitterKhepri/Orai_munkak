import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BaseService {

  private url = "https://localhost:7178/api/Humans/"

  private humansSub = new Subject

  constructor(private http:HttpClient) {
    this.loadHumans()
   }

  private loadHumans(){
    this.http.get(this.url).subscribe(
      (res:any)=>this.humansSub.next(res)
    )
  }

  getHumans(){
    return this.humansSub
  }

  addHuman(human:any){
    this.http.post(this.url, human).forEach(
      ()=>this.loadHumans()
    )
  }

  editHuman(human:any){
    this.http.put(this.url+human.id, human).forEach(
      ()=>this.loadHumans()
    )
  }

  deleteHuman(human:any){
    this.http.delete(this.url+human.id).forEach(
      ()=>this.loadHumans()
    )
  }

  

}
