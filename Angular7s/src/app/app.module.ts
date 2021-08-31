import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule} from '@angular/forms';
import { HttpClientModule } from "@angular/common/http";
import { AppComponent } from './app.component';
import { LogdetayComponent } from './logdetaylar/logdetay/logdetay.component';
import { LogdetaylarComponent } from './logdetaylar/logdetaylar.component';
import { LogdetayListeComponent } from './logdetaylar/logdetay-liste/logdetay-liste.component';
import { LogdetayService } from './paylas/logdetay.service';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { ToastrModule } from 'ngx-toastr';

@NgModule({
  declarations: [
    AppComponent,
    LogdetayComponent,
    LogdetaylarComponent,
    LogdetayListeComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot()
  ],
  providers: [LogdetayService],
  bootstrap: [AppComponent]
})
export class AppModule { }
