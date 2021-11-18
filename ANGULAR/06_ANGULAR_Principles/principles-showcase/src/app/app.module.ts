import { NgModule } from '@angular/core';
import {FormsModule, ReactiveFormsModule} from '@angular/forms';
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
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { AutocompleteComponent } from './autocomplete/autocomplete.component';
import { MatAutocompleteModule } from '@angular/material/autocomplete';
import { MatFormFieldModule } from '@angular/material/form-field';
import {MatInput, MatInputModule} from '@angular/material/input';
import {FormControl} from '@angular/forms';
import { MatIconModule } from '@angular/material/icon';
import {MatBadgeModule} from '@angular/material/badge';
import { HighlightModule, HIGHLIGHT_OPTIONS } from 'ngx-highlightjs';
import {MatBottomSheetModule} from '@angular/material/bottom-sheet';
import {MatListModule} from '@angular/material/list';
import { BottomSheetExampleComponent } from './bottom-sheet-example/bottom-sheet-example.component';
import { ButtonsComponent } from './buttons/buttons.component';

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
    HomeComponent,
    AutocompleteComponent,
    BottomSheetExampleComponent,
    ButtonsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    MatFormFieldModule,
    MatAutocompleteModule,
    MatInputModule,
    MatIconModule,
    MatBadgeModule,
    HighlightModule,
    MatBottomSheetModule,
    MatListModule
  ],
  exports: [
    MatAutocompleteModule,
    MatFormFieldModule,
    MatInputModule,
    MatBadgeModule,
    HighlightModule,
    MatBottomSheetModule,
    MatListModule
    
  ],
  providers: [
    {
      provide: HIGHLIGHT_OPTIONS,
      useValue: {
        coreLibraryLoader: () => import('highlight.js/lib/core'),
      }

    }
  ],
  bootstrap: [AppComponent],
})
export class AppModule { }
