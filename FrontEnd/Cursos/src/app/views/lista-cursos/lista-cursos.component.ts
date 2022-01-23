import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CursosService } from '../../services/cursos.service';

@Component({
  selector: 'app-lista-cursos',
  templateUrl: './lista-cursos.component.html',
  styleUrls: ['./lista-cursos.component.scss']
})
export class ListaCursosComponent implements OnInit {

  cursos!: any[];

  constructor(private listaCursos: CursosService, private router: Router) { }

  ngOnInit(): void {
    debugger
    this.carregarListaCursos();
  }

  private carregarListaCursos() {
    debugger
    this.listaCursos.listarCursos().subscribe(cursos => {
      this.cursos = cursos;
    }
    );
  }
  Venda(idCurso: any): void {
    this.router.navigate(['venda'], { state: { idCurso } });
  }
}
