import { Injectable } from '@angular/core';
import { AngularFireStorage } from '@angular/fire/compat/storage';
import { AngularFireDatabase, AngularFireList } from '@angular/fire/compat/database';

import { Subject, finalize } from 'rxjs';
import { Products } from './products';

@Injectable({
  providedIn: 'root'
})
export class BaseService {

  urlSubject = new Subject()
  basePath = "/feltolt"
  dbRef:any
  productRef:AngularFireList<Products>


  constructor(private storage:AngularFireStorage, private db:AngularFireDatabase) {
    this.dbRef = this.db.list(this.basePath)
    this.productRef=this.db.list("/products")
   }


   getUrlSubject(){
    return this.urlSubject
   }



   getProducts(){
    return this.productRef
   }

   addProduct(product:any){
    return this.productRef.push(product)
   }

   updateProducts(product:any){
    return this.productRef.update(product.key, product)
   }

   deleteProduct(product:any){
    return this.productRef.remove(product.key)
   }

   deleteProducts(){
    return this.productRef.remove()
   }


   getData(){
    return this.dbRef
   }


   pushImage(file:any){
    const fullPath = this.basePath + "/" + file.name
    const storageRef = this.storage.ref(fullPath)
    const uploadTask = this.storage.upload(fullPath, file)

    uploadTask.snapshotChanges().pipe(
        finalize(
          ()=>{
            storageRef.getDownloadURL().subscribe(
              (url)=>{
                //console.log(url)
                this.urlSubject.next(url)
              }
            )
          }
        )
      ).subscribe()
      return uploadTask.percentageChanges()
   }


   pushFile(file:any){

      const fullPath = this.basePath + "/" + file.name
      const storageRef = this.storage.ref(fullPath)
      
      storageRef.getDownloadURL().subscribe(

        {
          next:(res:any)=>console.log("K:", res),
          error:(res:any)=>console.log("K:", res)
        }

      )


      const uploadTask = this.storage.upload(fullPath, file)
      
      uploadTask.snapshotChanges().pipe(
        finalize(
          ()=>{
            storageRef.getDownloadURL().subscribe(
              (url)=>{
                //console.log(url)
                this.addFileData(file.name, url)
              }
            )
          }
        )
      )
      
      .subscribe(
        (adat:any)=>console.log(adat)
      )
      return uploadTask.percentageChanges()
   }

  addFileData(fName:any, fsUrl:any){

    const data = {name:fName, url:fsUrl}
    this.dbRef.push(data)

  }

  deleteFile(file:any){

    this.dbRef.remove(file.key).then(
      ()=>{
        const fullPath = this.basePath + "/" + file.name
        const storageRef = this.storage.ref(fullPath)

        storageRef.delete().subscribe(
          (res)=>console.log(res)
        )
      }      
    )
  }
  

}
