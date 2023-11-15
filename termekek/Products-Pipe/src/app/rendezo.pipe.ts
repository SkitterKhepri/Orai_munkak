import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'rendezo'
})
export class RendezoPipe implements PipeTransform {

  transform(termekek:any) {
    if(!termekek) return null

    termekek.sort(
      (a:any, b:any)=>{
        return a['name'].localeCompare(b['name'], 'hu', {sensitivity:'base'})
      }
    )
    return termekek

  }

}
