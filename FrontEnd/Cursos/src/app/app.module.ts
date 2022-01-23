import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CadastroEstudanteComponent } from './views/cadastro-estudante/cadastro-estudante.component';
import { HomeComponent } from './views/home/home.component';
import { ListaCursosComponent } from './views/lista-cursos/lista-cursos.component';
import { CadastroCartaoComponent } from './views/cadastro-estudante/cadastro-cartao/cadastro-cartao.component';
import { VendaComponent } from './views/venda/venda.component';
import { HeaderComponent } from './views/header/header.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CursosService } from './services/cursos.service'

@NgModule({
  declarations: [
    AppComponent,
    CadastroEstudanteComponent,
    HomeComponent,
    ListaCursosComponent,
    CadastroCartaoComponent,
    VendaComponent,
    HeaderComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
  ],
  providers: [
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
