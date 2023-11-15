import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'kereso'
})
export class KeresoPipe implements PipeTransform {

  transform(products:any, kereso:any) {

    if(!products) return null
    if(!kereso || kereso.length == 0) return products 

    return products.filter(
      (sor:any)=>
      //{return sor.name.toLowerCase().includes(kereso.toLowerCase())}
      {return JSON.stringify(sor).toLowerCase().includes(kereso.toLowerCase())}
    )
  }

}
