import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'kereso'
})
export class KeresoPipe implements PipeTransform {

  transform(products:any,kereso:any, mezo:any) {
    if (!products) return null;
    if (!kereso || kereso.length==0) return products
    
    return products.filter(
      (sor:any)=> {
      // {return sor.name.toLowerCase().includes(kereso.toLowerCase())}
      if (mezo=='') {
        for (const e in sor){
          // console.log(sor[e])

          if(typeof(sor[e]) == 'string'){
            if (String(sor[e]).toLowerCase().includes(kereso)) return true
          }
          else{
            if(sor[e] == kereso) return true
          }
        }
        return false
      }
        
        // JSON.stringify(sor).toLowerCase().includes(kereso.toLowerCase())}


      else {
        
        if(typeof(sor[mezo]) == 'string'){
        
          return sor[mezo].toLowerCase().includes(kereso.toLowerCase())
        }

        else{

          if(sor[mezo]==kereso){

            return true

          }
        }


      }
      
      // {return JSON.stringify(sor).toLowerCase().includes(kereso.toLowerCase())}
    }
    
    )
    

  }

}
