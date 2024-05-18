using System;
using System.Security.Cryptography;

namespace Struct;


public struct Professor{
    public string nome;
    public string materia;
    public double salario;

    public double cargaHoraria;

    public double valorSalario;

    public double valorSalarioPorcen;

    public double DescontoFalta;

    public double DescontoFaltaPorcen;

    public double ReajusteMaisSalario;

    public double AumentarSalario;

    public Professor(string nome, string materia, double salario, double cargaHoraria, double valorSalario, double valorSalarioPorcen, double DescontoFalta, double DescontoFaltaPorcen, double ReajusteMaisSalario, double AumentarSalario){
        this.nome = nome;
        this.materia = materia;
        this.salario = salario;
        this.cargaHoraria = cargaHoraria;
        this.valorSalario = valorSalario;
        this.valorSalarioPorcen = valorSalarioPorcen;
        this.DescontoFalta = DescontoFalta;
        this.DescontoFaltaPorcen = DescontoFaltaPorcen;
        this.ReajusteMaisSalario = ReajusteMaisSalario;
        this.AumentarSalario = AumentarSalario;

    }

    public void reajusteSalarialEmValor(double reajuste){
        this.valorSalario = this.salario + reajuste;
        
    }

    public void reajusteSalarialEmPorcentagem(double reajustePorcen){
        this.valorSalarioPorcen = this.salario - (this.salario*(reajustePorcen / 100));
    }

    public void descontoSalarialPorFaltaEmValor(double descontoValorFalta, int quantFalta){
        for(int i = 0; i < quantFalta; i++){
            this.DescontoFalta = this.salario - descontoValorFalta;
        }
    }

    public void descontoSalarialPorFaltaEmPorcentagem(double DescontoFaltaPorcen, int quantFalta){
         for(int i = 0; i < quantFalta; i++){
            this.DescontoFaltaPorcen = this.salario - (this.salario*(DescontoFaltaPorcen / 100));
         }
        
    }

    public void aumentarCargaHorariaDeTrabalho(double reajusteSalarioMais, double MaisSalario) {
        this.ReajusteMaisSalario = this.cargaHoraria + reajusteSalarioMais;
        this.AumentarSalario = this.salario + MaisSalario;
    }

    public string imprimir(){
        return "\nNome Professor: " + this.nome + 
        "\nMatéria: " + this.materia + "\nSalario: "
         + this.salario + "\nCarga Horaria: " +
          this.cargaHoraria + "\nValor Reajustado: " +
           this.valorSalario + "\nReajustado em Porcentagem: " +
            this.valorSalarioPorcen + "\nDesconto Por Falta: " + 
            this.DescontoFalta + "\nDesconto Por Falta em Porcentagem: " +
             this.DescontoFaltaPorcen + "\nCarga Horaria Reajustada: " + 
             this.ReajusteMaisSalario + "\nSalario Aumentado: " + this.AumentarSalario;
    }

}