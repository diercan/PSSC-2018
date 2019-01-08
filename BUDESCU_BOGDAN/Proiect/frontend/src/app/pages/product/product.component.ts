import { Component, OnInit, SimpleChanges, OnChanges, AfterViewInit, OnDestroy } from '@angular/core';
import { HttpService } from 'src/app/services/http/http.service';
import { SharedService } from 'src/app/services/shared/shared.service';
import { Product } from 'src/app/models/Product';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent  {

  public tableHead = [
    { name: "Id", colspan: 1 },
    { name: "firstName", colspan: 1 },
    { name: "lastName", colspan: 1 },
    { name: "email", colspan: 1 },
    { name: "countryId", colspan: 2 }
  ];

  public selectedProducts: any[]=[];
  public indexProduct = 0;
  public array : any[]=[1,2,3,4,5,6,7,8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21];
  public indexPage = 1;
  // public products : any[] = [
  //                           {
  //                             image : 'assets/laptop1.jpg',
  //                             name : 'Laptop ASUS ZenBook UX430UA-GV183T',
  //                             quantity:'500 pieces',
  //                             cost: '2400 RON'
  //                           },
  //                           {
  //                             image : 'assets/laptop2.jpg',
  //                             name : 'Laptop ASUS ZenBook 13 UX331UN-C4088T',
  //                             quantity:'10 pieces',
  //                             cost : '3600 RON'
  //                           },
  //                           {
  //                             image :'assets/laptop3.jpg',
  //                             name : 'Notebook Asus K555lb - dm451t',
  //                             quantity:'200 pieces',
  //                             cost : '3200 RON'
  //                           }
  //                           ];
  public products: Product[] = [];
  public showCreateProductForm: boolean = false;
  public createUserModel: Product = new Product("","",new Date(),"",true,null,null,"","","","");
  public updateUserModel: Product = new Product("","",new Date(),"",true,null,null,"","","","");

  public buttonMessage_1: string = "Show Create Product Form";
  constructor(private httpService : HttpService,
              public sharedService : SharedService) {
    this.getProducts();
   }


   public AddProduct(index:number)
   {
     this.indexProduct ++;
     this.selectedProducts.push(index);
   }

   public DeleteProductCustomer(index:number)
   {
     this.indexProduct ++;
     console.log(this.selectedProducts);
     for (let i = 0; i < this.selectedProducts.length; i++) {
       const element = this.selectedProducts[i];
       if(element==index)
       {
         this.selectedProducts.splice(i,1);
       }
     }
   }

   public NextButton() {
    if (this.indexPage < (this.products.length-1) / 6) {
      this.indexPage++;
    }
  }

  public PreviousButton() {
    if (this.indexPage > 1) {
      this.indexPage--;
    }
  }


  public getProducts() {
    this.httpService.getProducts().subscribe((result: Product[]) => {
      this.products = result;
    });
  }

  public deleteProductManager(id: string) {

    this.httpService.deleteProduct(id).subscribe((result) => {
      this.getProducts();
    }, (err) => {
      console.log(err)
    })
  }

  public showCreateProduct() {

    if (this.showCreateProductForm) {
      this.buttonMessage_1 = "Show Create Product Form";
      this.showCreateProductForm = false;
    } else {
      this.buttonMessage_1 = "Hide Create Product Form";
      this.showCreateProductForm = true;
    }
  }

  public showUpdateProduct(product: Product) {

    if (this.updateUserModel.id == product.id) {
      this.updateUserModel = new Product("","",new Date(),"",true,null,null,"","","","");
    } else if (this.updateUserModel.id !=  product.id) {
      this.updateUserModel = new Product(product.id,product.name,product.created,product.modified,product.active,product.quantity,product.cost,product.productCodeId,product.productCodeName,product.description,product.image);
    }
  
  }

  public onSubmitCreateProductForm() {

    this.httpService.createProduct(this.createUserModel).subscribe((result) => {
      this.getProducts();
    })
  }

  public onSubmitUpdateProductForm() {

    this.httpService.updateProduct(this.updateUserModel).subscribe((result) => {
      this.getProducts();
    })
  }
}
