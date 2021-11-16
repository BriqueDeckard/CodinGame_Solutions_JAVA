import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ShowAnObjectComponent } from './show-an-object/show-an-object.component';
import { EditAnObjectComponent } from './edit-an-object/edit-an-object.component';
import { DisplayAListComponent } from './display-a-list/display-a-list.component';
import { ViewingDetailsComponent } from './viewing-details/viewing-details.component';

@NgModule({
  declarations: [
    AppComponent,
    ShowAnObjectComponent,
    EditAnObjectComponent,
    DisplayAListComponent,
    ViewingDetailsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
