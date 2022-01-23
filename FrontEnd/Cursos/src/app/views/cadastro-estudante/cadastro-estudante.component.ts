import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { CursosService } from '../../services/cursos.service';
import { Estudante } from './estudante';

@Component({
  selector: 'app-cadastro-estudante',
  templateUrl: './cadastro-estudante.component.html',
  styleUrls: ['./cadastro-estudante.component.scss']
})
export class CadastroEstudanteComponent implements OnInit {

  estudante: Estudante = new Estudante();
  formEstudante!: FormGroup;

  constructor(
    private cursoService: CursosService,
    private router: Router,
    private fb: FormBuilder
  ) { }

  ngOnInit(): void {

    this.buildFormEstudante();
  }

  onSubmit() {
    this.cadastraEstudante();
  }

  buildFormEstudante(): void {
    this.formEstudante = this.fb.group({

      nome!: ["", Validators.required],
      cpf!: ["", Validators.required],
      endereco!: [""],
      email!: ["", [
        Validators.required,
        Validators.email
      ]]
    })
  }

  cadastraEstudante() {

    if (!this.formEstudante.valid) {
      console.log("Formulário inválido");
      return;
    }
    this.cursoService.cadastrarEstudante(this.formEstudante.value).subscribe(estudante => {
      console.log(estudante);
      this.estudante = estudante;
    },
      error => console.log(error));
  }

  Cartao() {
    let id = this.estudante.id
    this.router.navigate(['cadastro-cartao'], { state: { id } });
  }
}
