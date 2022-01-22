import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { CadastroEstudanteComponent } from './views/cadastro-estudante/cadastro-estudante.component';
import { HomeComponent } from './views/home/home.component';
import { ListaCursosComponent } from './views/lista-cursos/lista-cursos.component';
import { CadastroCartaoComponent } from './views/cadastro-estudante/cadastro-cartao/cadastro-cartao.component';
import { VendaComponent } from './views/venda/venda.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    CadastroEstudanteComponent,
    HomeComponent,
    ListaCursosComponent,
    CadastroCartaoComponent,
    VendaComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
