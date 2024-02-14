import { Component } from '@angular/core';
import { BaseService } from '../base.service';

@Component({
  selector: 'app-emberek',
  templateUrl: './emberek.component.html',
  styleUrls: ['./emberek.component.css']
})
export class EmberekComponent {

  humans:any
  newHuman:any = {}
  oszlopok = ["name", "gender", "age"]

  constructor(private base:BaseService){
    this.base.getHumans().subscribe(
      (res:any)=> this.humans = res
    )
  }

  addHuman(){
    this.base.addHuman(this.newHuman)
    this.newHuman = {}
  }

  editHuman(human:any){
    this.base.editHuman(human)
  }

  deleteHuman(human:any){
    this.base.deleteHuman(human)
  }

}
