import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { ExpandableListModule } from 'angular2-expandable-list';
import { FileDropModule } from 'ngx-file-drop';

import { AppComponent } from './components/app/app.component';
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';

import { ServersComponent } from './components/servers/servers.component';
import { ServerComponent } from './components/server/server.component';
import { NewServerFormComponent } from './components/new-server/new-server.component';

import { SimulationsComponent } from './components/simulations/simulations.component';
import { SimulationComponent } from './components/simulation/simulation.component';
import { NewSimulationFormComponent } from "./components/new-simulation/new-simulation.component";

import { PresentationComponent } from './components/presentation/presentation.component';

@
NgModule({
    declarations: [
        AppComponent,
        NavMenuComponent,
        ServersComponent,
        ServerComponent,
        NewServerFormComponent,
        SimulationsComponent,
        SimulationComponent,
        NewSimulationFormComponent,
        PresentationComponent,
        HomeComponent
    ],
    imports: [
        CommonModule,
        HttpClientModule,
        FormsModule,
        ExpandableListModule,
        FileDropModule,
        RouterModule.forRoot([
            { path: '', redirectTo: 'home', pathMatch: 'full' },
            { path: 'home', component: HomeComponent },
            { path: 'servers', component: ServersComponent },
            { path: 'servers/:id', component: ServerComponent },
            { path: 'simulations', component: SimulationsComponent },
            { path: 'simulations/:id', component: SimulationComponent },
            { path: 'presentations/:id', component: PresentationComponent },
            { path: '**', redirectTo: 'home' }
        ])
    ],
    bootstrap: [AppComponent]
})
export class AppModuleShared {
}
