import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SearchService {

  keresendo3= new BehaviorSubject("")

  constructor() { }

  getKeresendo(){
    return this.keresendo3
  }

  setKeresendo(szo:any){
    this.keresendo3.next(szo)
  }

}
