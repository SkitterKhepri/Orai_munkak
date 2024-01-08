import { Component } from '@angular/core';
import { BaseService } from '../base.service';
import { Products } from '../products';

@Component({
  selector: 'app-upload',
  templateUrl: './upload.component.html',
  styleUrls: ['./upload.component.css']
})
export class UploadFormComponent {

  selectedFile:any
  upload=false
  percentage = 0
  newProduct:any = []

  constructor(private base:BaseService){
    this.base.getUrlSubject().subscribe(
      (url)=>{
        console.log(this.newProduct.imageUrl)
        this.newProduct.imageUrl.push(url)
      }
    )
   }

  selectFile(event:any){
    
    this.selectedFile = event.target.files[0]
    this.upload = false
    this.percentage = 0
  }


  uploadFile(){
    this.upload=true
    this.base.pushImage(this.selectedFile).subscribe(
      (res)=>{
        console.log(res,"%")
        this.percentage=Math.round(Number(res))
      }
    )
  }

  addProduct(product:any){
    this.base.addProduct(product)
  }
  // uploadFile(){
  //   this.upload =true
  //   Array.from(this.selectedFile).forEach((element:any) => {      
  //     this.base.pushFile(element).subscribe(
  //       (res)=>{        
  //         console.log(res, "%")
  //         this.percentage = Math.round(Number(res))
  //       }
  //     )
  //   });
    

  // }

}
