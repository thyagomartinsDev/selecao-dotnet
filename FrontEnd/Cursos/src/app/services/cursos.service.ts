import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CursosService {

  private url = "http://localhost:1194";

  constructor(private httpClient: HttpClient) { }

  listarCursos(): Observable<any[]> {
    return this.httpClient.get<any[]>(`${this.url}/api/Cursoes/BuscaTodos`);
  }

  cadastrarEstudante(estudante: any): Observable<any> {
    return this.httpClient.post(`${this.url}/api/Estudantes/Cadastrar`, estudante);
  }

  cadastrarCartao(cartao: any): Observable<any> {
    return this.httpClient.post(`${this.url}/api/Cartao/Cadastrar`, cartao);
  }

  consultarPorCpf(cpf: any): Observable<any> {
    const params: HttpParams = new HttpParams().set('cpfEstudante', cpf);
    return this.httpClient.get(`${this.url}/api/Estudantes/BuscarPorCPF`, { params });
  }

  consultarCartaoIdEstudante(idEstudante: any): Observable<any[]> {
    debugger
    const params: HttpParams = new HttpParams().set('idEstudante', idEstudante);
    return this.httpClient.get<any[]>(`${this.url}/api/Cartao/BuscarPorIdEtudante`, { params });
  }

  cadastrarVenda(venda: any): Observable<any> {
    return this.httpClient.post(`${this.url}/api/Venda/Cadastrar`, venda);
  }

  consultarCurso(idCurso: any): Observable<any> {
    const params: HttpParams = new HttpParams().set('idCurso', idCurso);
    return this.httpClient.get(`${this.url}/api/Cursoes/BuscarPorId`, { params });
  }

  consultarCursosPorIdEstudante(idEstudante: any): Observable<any> {
    const params: HttpParams = new HttpParams().set('idEstudante', idEstudante);
    return this.httpClient.get(`${this.url}/api/Cursoes/BuscarCursosPorIdEstudante`, { params });
  }

}
