import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BaseService {

  private todoSub = new Subject()
  url="https://localhost:7061/api/Todoes/"

  constructor(private http:HttpClient) {
    this.loadTodo()
   }

  getToddo(){
    return this.todoSub
  }

  loadTodo(){
    this.http.get(this.url).subscribe(
      (res:any)=>this.todoSub.next(res)
    )
  }

  postTodo(body?:any){

    if(!body){
      body = {name:"Angulart tanulni!", isComplete:false}      }
    
    console.log("body:", body)
    this.http.post(this.url, body).subscribe(
      ()=>this.loadTodo()
    )
    }
  

  putTodo(body:any){
    this.http.put(this.url + body.id, body).subscribe(
      ()=>this.loadTodo()
    )
  }

  deleteTodo(body:any){
    this.http.delete(this.url + body.id).subscribe(
      ()=>this.loadTodo()
    )
  }

}
