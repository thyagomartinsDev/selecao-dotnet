import { Component, NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './views/home/home.component';
import { ListaCursosComponent } from './views/lista-cursos/lista-cursos.component';
import { CadastroEstudanteComponent } from './views/cadastro-estudante/cadastro-estudante.component';
import { CadastroCartaoComponent } from './views/cadastro-estudante/cadastro-cartao/cadastro-cartao.component';
import { VendaComponent } from './views/venda/venda.component';
import { HeaderComponent } from './views/header/header.component';
import { ConsultaMatriculasComponent } from './views/consulta-matriculas/consulta-matriculas.component'
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';

const routes: Routes = [
  { path: '', redirectTo: 'lista-cursos', pathMatch: 'full' },
  { path: 'home', component: HomeComponent },
  { path: 'header', component: HeaderComponent },
  { path: 'lista-cursos', component: ListaCursosComponent },
  { path: 'cadastro-estudante', component: CadastroEstudanteComponent },
  { path: 'cadastro-cartao', component: CadastroCartaoComponent },
  { path: 'venda', component: VendaComponent },
  { path: 'consulta-matricula', component: ConsultaMatriculasComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes), FormsModule, ReactiveFormsModule],
  exports: [RouterModule]
})
export class AppRoutingModule { }
