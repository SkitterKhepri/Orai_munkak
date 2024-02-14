import { Component } from '@angular/core';
import { BaseService } from '../base.service';
import { map } from 'rxjs';

@Component({
  selector: 'app-home',
  templateUrl: 'home.page.html',
  styleUrls: ['home.page.scss'],
})
export class HomePage {

  messages:any
  userName = "Idegen"
  newMessage:any

  constructor(private base:BaseService) {

    this.base.getMessages().snapshotChanges().pipe(
    map(
      (ch:any)=> ch.map(
        (c:any)=>({key:c.payload.key, ...c.payload.val()})
      )
    )
    ).subscribe(

      (res:any)=>this.messages = res
      
    )

  }

  addMessage(){
    if(this.newMessage){
    let message = {userName:this.userName, time:new Date().toLocaleTimeString(), text:this.newMessage}
    this.base.addMessage(message)
    this.newMessage=""
    }
  }

  saveMessage(message:any){
    this.base.saveMessage(message)
  }

  deleteMessage(message:any){
    this.base.deleteMessage(message)
  }

}
