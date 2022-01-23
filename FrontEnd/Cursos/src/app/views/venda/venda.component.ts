import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { CursosService } from 'src/app/services/cursos.service';
import { Estudante } from '../cadastro-estudante/estudante';
import { Venda } from './venda';

@Component({
  selector: 'app-venda',
  templateUrl: './venda.component.html',
  styleUrls: ['./venda.component.scss']
})
export class VendaComponent implements OnInit {
  venda: Venda = new Venda();
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

    this.venda.idCartao = this.formVenda.get('idCartao')?.value;
    this.venda.idCurso = this.formVenda.get('idCurso')?.value;
    this.venda.idEstudante = this.formVenda.get('idEstudante')?.value;
    this.venda.valorTotal = this.formVenda.get('valorTotal')?.value;

    this.cursoService.cadastrarVenda(this.venda).subscribe(venda => {
      console.log(venda);
      alert("Compra concluída e matricula realizada!");
    },
      error => alert("Erro ao realizar a venda!"));

  }

  consultarCurso(): void {

    this.cursoService.consultarCurso(this.id).subscribe(curso => {
      this.curso = curso;
      this.formVenda.get('idCurso')?.setValue(curso.id);
      this.formVenda.get('nomeCurso')?.setValue(curso.descricao);
      this.formVenda.get('valorTotal')?.setValue(curso.valorCurso)
    },
      error => alert("Curso não encontrado!"));
  }

  consultarCpf(): void {

    let cpf = this.formVenda.get('cpf')?.value
    this.cursoService.consultarPorCpf(cpf).subscribe(estudante => {
      this.estudante = estudante;
      this.consultaCartaoPorIdEstudante(this.estudante.id);
      console.log(this.estudante);
      this.formVenda.get('idEstudante')?.setValue(this.estudante.id);
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
