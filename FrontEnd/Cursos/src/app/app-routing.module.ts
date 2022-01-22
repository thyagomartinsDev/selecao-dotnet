import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './views/home/home.component';
import { ListaCursosComponent } from './views/lista-cursos/lista-cursos.component';
import { CadastroEstudanteComponent } from './views/cadastro-estudante/cadastro-estudante.component';
import { CadastroCartaoComponent } from './views/cadastro-estudante/cadastro-cartao/cadastro-cartao.component';
import { VendaComponent } from './views/venda/venda.component';

const routes: Routes = [
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: 'home', component: HomeComponent },
  { path: 'lista-cursos', component: ListaCursosComponent },
  { path: 'cadastro-estudante', component: CadastroEstudanteComponent },
  { path: 'cadastro-cartao', component: CadastroCartaoComponent },
  { path: 'venda/:id', component: VendaComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
