import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { CursosService } from 'src/app/services/cursos.service';
import { Estudante } from '../cadastro-estudante/estudante';

@Component({
  selector: 'app-venda',
  templateUrl: './venda.component.html',
  styleUrls: ['./venda.component.scss']
})
export class VendaComponent implements OnInit {

  estudante: Estudante = new Estudante();
  formVenda!: FormGroup;
  cartoes!: any[];
  curso: any;
  id: any;

  constructor(
    private cursoService: CursosService,
    private router: Router,
    private fb: FormBuilder
  ) {
    const currentNavigation = this.router.getCurrentNavigation();
    if (currentNavigation && currentNavigation.extras && currentNavigation.extras.state) {
      const state = currentNavigation.extras.state;
      debugger
      this.id = state.idCurso;
    }
  }

  ngOnInit(): void {

    this.buildFormVenda();
    this.consultarCurso()
  }

  onSubmit(): void {
    this.finalizarVenda();
  }

  buildFormVenda(): void {
    this.formVenda = this.fb.group({
      id: ["", Validators.required],
      nomeCurso: ["", Validators.required],
      numeroCartao: ["", Validators.required],
      idCurso: ["", Validators.required],
      idCartao: ["", Validators.required],
      idEstudante: ["", Validators.required],
      valorTotal: ["", Validators.required],
      cpf: ["", Validators.required]
    })
  }

  finalizarVenda(): void {

    if (!this.formVenda.valid) {
      alert("Preencha todos os dados!");
      return;
    }
    this.cursoService.cadastrarEstudante(this.formVenda.value).subscribe(venda => {
      console.log(venda);
      alert("Compra concluída e matricula realizada!");
    },
      error => alert("Erro ao realizar a venda!"));

  }

  consultarCurso(): void {

    this.cursoService.consultarCurso(this.id).subscribe(curso => {
      this.curso = curso;
      this.formVenda.get('nomeCurso')?.setValue(curso.descricao);
      this.formVenda.get('valorTotal')?.setValue(curso.valorCurso)
    },
      error => alert("Curso não encontrado!"));
  }

  consultarCpf(): void {
    debugger
    let cpf = this.formVenda.get('cpf')?.value
    this.cursoService.consultarPorCpf(cpf).subscribe(estudante => {
      this.estudante = estudante;
      this.consultaCartaoPorIdEstudante(this.estudante.id);
      console.log(this.estudante);
    },
      error => alert("CPF não encontrado!"));
  }

  consultaCartaoPorIdEstudante(idEstudante: number): void {
    this.cursoService.consultarCartaoIdEstudante(idEstudante).subscribe(cartao => {
      this.cartoes = cartao;
      console.log(this.cartoes);
    },
      error => alert("Cartaões não encontrados"))
  }
}
