import { Component } from '@angular/core';
import { BaseService } from '../base.service';

@Component({
  selector: 'app-todo-list',
  templateUrl: './todo-list.component.html',
  styleUrls: ['./todo-list.component.css']
})
export class TodoListComponent {

  todoes:any
  newTodo:any = {}

  constructor(private base:BaseService){

    this.base.getToddo().subscribe(
      (res:any)=> {this.todoes = res; console.log(res)}
    )

  }

  postTodo(){

    this.base.postTodo(this.newTodo)
    this.newTodo = {}

  }

  putTodo(todo:any){
    this.base.putTodo(todo)
  }

  delTodo(todo:any){
    this.base.deleteTodo(todo)
  }

}
