import { Component } from '@angular/core';
import { BaseService } from '../base.service';
import { map } from 'rxjs';

@Component({
  selector: 'app-home',
  templateUrl: 'home.page.html',
  styleUrls: ['home.page.scss'],
})
export class HomePage {

  animals:any
  oszlopok = ["imagesUrl", "key", "name", "price"]

  constructor(private base:BaseService) {
    this.base.getAnimals().snapshotChanges().pipe(
      map(
        (ch:any)=> ch.map(
          (c:any)=> ({key:c.payload.key, ...c.payload.val()})
        )
      )
    ).subscribe(
      (res:any)=> this.animals=res
    )
  }

  saveAllat(allat:any){
    this.base.saveAnimal(allat)
  }

  deleteAllat(allat:any){
    this.base.deleteAnimal(allat)
  }

}
