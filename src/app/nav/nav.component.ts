import { Component } from '@angular/core';
import { ConfigService } from '../config.service';
import { SearchService } from '../search.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent {

  fontosAdat:any
  keresendo4:any

  constructor(private config:ConfigService, private search:SearchService){
    this.config.getConfig().subscribe(
      (adat:any)=>this.fontosAdat = adat
    )
  }

  keres(){
    //console.log("esemény:", this.keresendo4)
    this.search.setKeresendo(this.keresendo4)
  }

}
