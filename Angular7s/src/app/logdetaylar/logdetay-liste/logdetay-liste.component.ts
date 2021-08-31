import { Component, OnInit } from '@angular/core';
import { Logdetay } from 'src/app/paylas/logdetay.model';
import { LogdetayService } from 'src/app/paylas/logdetay.service';
import { HttpClient } from "@angular/common/http";

@Component({
  selector: 'app-logdetay-liste',
  templateUrl: './logdetay-liste.component.html',
  styles: []
})
export class LogdetayListeComponent implements OnInit {
 
 
  constructor(private service : LogdetayService) {  }
  ngOnInit() {
    
    this.service;
    console.log(this.service.refreshList());
     this.service.refreshList();
  
  }


}
