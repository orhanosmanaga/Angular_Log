import { DatePipe } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { LogdetayService } from 'src/app/paylas/logdetay.service';
import { formatDate } from "@angular/common";
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { ToastrModule } from 'ngx-toastr';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-logdetay',
  templateUrl: './logdetay.component.html',
  styles: ['']
})
export class LogdetayComponent implements OnInit {

  constructor(private service:LogdetayService,
    private toastr : ToastrService) { }

  ngOnInit() {
    this.resetForm();
  }

resetForm(form?:NgForm){
  if (form!=null)
form.resetForm();
this.service.formData={

  Int:0,
  Message:'',
  CreateDate:new Date(),
  LogType:'',
}
}
onSubmit(form:NgForm){
this.service.postlogDetay(form.value).subscribe(

  res=>{
    this.resetForm(form);
    this.toastr.success('Ekleme tamam','Log kayit');

  },
  err=>{

    console.log(err);
    
  }
)

}
}
