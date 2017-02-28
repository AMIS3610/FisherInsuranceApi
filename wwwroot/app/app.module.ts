import {NgModule} from '@angular/core';
import {BrowserModule} from '@angular/platform-browser';
import {HttpModule} from '@angular/http';
import 'rxjs/Rx';

//import app component
import {AppComponent} from './app.component';
import {HomeComponent} from './components/home/home.component';
import {NavBarComponent} from './components/navbar/navbar.component';
@NgModule({
    declarations: [
        NavBarComponent,
        AppComponent,
        HomeComponent
    ],
    imports: [
        BrowserModule,
        HttpModule
    ],
    providers: [

    ],
    bootstrap: [
        //NavBarComponent,
        AppComponent
    ],
})
export class AppModule{ }