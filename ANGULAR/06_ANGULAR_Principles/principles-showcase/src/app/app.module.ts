import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ShowAnObjectComponent } from './show-an-object/show-an-object.component';
import { EditAnObjectComponent } from './edit-an-object/edit-an-object.component';
import { DisplayAListComponent } from './display-a-list/display-a-list.component';
import { ViewingDetailsComponent } from './viewing-details/viewing-details.component';
import { ObjectDetailsComponent } from './object-details/object-details.component';
import { GetObjectAsyncComponent } from './get-object-async/get-object-async.component';
import { MenuBarComponent } from './menu-bar/menu-bar.component';
import { HomeComponent } from './home/home.component';

@NgModule({
  declarations: [
    AppComponent,
    ShowAnObjectComponent,
    EditAnObjectComponent,
    DisplayAListComponent,
    ViewingDetailsComponent,
    ObjectDetailsComponent,
    GetObjectAsyncComponent,
    MenuBarComponent,
    HomeComponent
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
