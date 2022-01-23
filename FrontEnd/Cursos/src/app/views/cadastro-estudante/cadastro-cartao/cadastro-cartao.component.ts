import { Component, OnInit } from '@angular/core';
import { Navigation, Router } from '@angular/router';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { CursosService } from '../../../services/cursos.service';

@Component({
  selector: 'app-cadastro-cartao',
  templateUrl: './cadastro-cartao.component.html',
  styleUrls: ['./cadastro-cartao.component.scss']
})
export class CadastroCartaoComponent implements OnInit {

  formCartao!: FormGroup;
  id: any;

  constructor(
    private cursoService: CursosService,
    private router: Router,
    private fb: FormBuilder,
  ) {
    const currentNavigation = this.router.getCurrentNavigation();
    if (currentNavigation && currentNavigation.extras && currentNavigation.extras.state) {
      const state = currentNavigation.extras.state;
      this.id = state.id;
    }
  }

  ngOnInit(): void {

    this.buildFormCartao();
  }

  onSubmit() {
    this.cadastraCartao();
  }

  buildFormCartao(): void {
    this.formCartao = this.fb.group({
      numeroCartao!: ["", Validators.required],
      validadeCartao!: ["", Validators.required],
      codigoCartao!: ["", Validators.required],
      nomeTitular!: ["", Validators.required],
      bandeiraCartao!: ["", Validators.required],
      idEstudante!: [""],
    })
  }

  cadastraCartao() {

    if (!this.formCartao.valid) {
      alert("Preencha todos os dados!");
      return;
    }

    this.formCartao.get('idEstudante')?.setValue(this.id)

    this.cursoService.cadastrarCartao(this.formCartao.value).subscribe(cartao => {
      console.log(cartao);
      alert("Cartão cadastrado!");
    },
      error => alert("Erro ao cadastrar!"));
  }

  Home() {
    this.router.navigate(['home']);
  }
}
