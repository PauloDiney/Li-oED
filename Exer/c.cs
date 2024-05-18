using System;
using System.Security.Cryptography;

namespace Struct;


public struct Produto{
    public string nome;
    public double valor;
    public string dataValidade;
    public int quantidade;

    public double cupom;
    public double porcen;

    public Produto(string nome, double valor, string dataValidade, int quantidade, double cupom, double porcen){
        this.nome = nome;
        this.valor = valor;
        this.dataValidade = dataValidade;
        this.quantidade = quantidade;
        this.cupom = cupom;
        this.porcen = porcen;

    }

    public void aplicarCupomDescontoValor(double cupomValor ){
        this.cupom = this.valor - cupomValor;
        if(this.cupom < 0){
            this.cupom = 0;
        }
    }

    public void aplicarCupomDescontoPorcentagem(double cumpoPorcen){
    
        this.porcen  = this.valor - (this.valor * (cumpoPorcen / 100));
         if(this.porcen < 0){
            this.porcen = 0;
         }
    }

    public void verificarQuantidadeEmEstoque(int quantidadeEstoque){
        this.quantidade = quantidadeEstoque;
    }

    public string imprimir(){
        return "\nNome Produto: " + this.nome 
        + "\nValor Produto: " + this.valor +
         "\nData Validade: "+ this.dataValidade + 
         "\nQuantidade: " + this.quantidade + 
         "\nProduto com Cupom: " + this.cupom + 
         "\nProduto com Desconto Porcentagem: R$" + this.porcen ; 
           }
}