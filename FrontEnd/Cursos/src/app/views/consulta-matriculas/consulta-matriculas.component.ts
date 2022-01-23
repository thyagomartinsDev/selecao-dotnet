import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CursosService } from 'src/app/services/cursos.service';
import { Estudante } from '../cadastro-estudante/estudante';

@Component({
  selector: 'app-consulta-matriculas',
  templateUrl: './consulta-matriculas.component.html',
  styleUrls: ['./consulta-matriculas.component.scss']
})
export class ConsultaMatriculasComponent implements OnInit {

  estudante: Estudante = new Estudante();
  cpf!: string;
  cursos!: any[];

  constructor(private cursoService: CursosService, private router: Router) { }

  ngOnInit(): void {
  }

  onSubmit(): void {
    this.consultarCpf();
  }

  consultarCpf(): void {

    let cpf = this.cpf
    this.cursoService.consultarPorCpf(cpf).subscribe(estudante => {
      this.estudante = estudante;
      console.log(this.estudante);
      let idEstudante = this.estudante.id;
      debugger
      this.consultarCursos(idEstudante);
    },
      error => alert("CPF não encontrado!"));
  }

  consultarCursos(idEstudante: any): void {
    this.cursoService.consultarCursosPorIdEstudante(idEstudante).subscribe(cursos => {
      debugger
      this.cursos = cursos;
    },
      error => alert("O Estudante não possui Matricula!"));
  }

}
