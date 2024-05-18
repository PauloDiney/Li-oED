using System;
using System.Security.Cryptography;

namespace Struct;

public struct Equipes{
    public string nomeEquipe;

    public string dataEstreia;

    public int vitorias;

    public int  jogadores;

    public double Premios;

    public string NovaVeterena;

    public Equipes(string nomeEquipe, string dataEstreia, int vitorias, int jogadores, double Premios, string NovaVeterena){
        this.nomeEquipe = nomeEquipe;
        this.dataEstreia = dataEstreia;
        this.vitorias = vitorias;
        this.jogadores = jogadores;
        this.Premios = Premios;
        this.NovaVeterena = NovaVeterena;
    }

    public void registrarCampeonatoVencido(int valorPremio){
        this.vitorias = valorPremio;
        for(int i = 0; i <= valorPremio; i++){
            atualizarValorTotalPremiacoes(50000);
        }

    }

    public void atualizarValorTotalPremiacoes(double valor){
        this.Premios += valor;
    }

   public void verificarAnoEstreia(int ano){
    if(DateTime.Now.Year < ano){
        this.NovaVeterena = "Veterana";
    }else{
        this.NovaVeterena = "Novata";
    }
   }

   public string imprimir(){
    return "\nNome Equipe: " + this.nomeEquipe +
     "\nData de Estreia: " + this.dataEstreia + 
     "\nVitorias: " + 
    this.vitorias + "\nJogadores: " + 
    this.jogadores + "\nPremios: " +
     this.Premios + "\nA Equipe é: " + this.NovaVeterena;
   }


}