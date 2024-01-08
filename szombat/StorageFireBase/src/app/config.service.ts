import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ConfigService {

  fontosDolog = new BehaviorSubject("nem tudom")

  getConfig(){
    return this.fontosDolog
  }

  setConfig(fontos:any){
    this.fontosDolog.next(fontos)
  }

  constructor() { }
}
