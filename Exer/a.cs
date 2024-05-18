using System;

 namespace Struct;

 public struct Jogador{
    public string nome;
    public int idade;
    public string time;

    public int cartaoAmarelo;

    public int cartaoVermelho;

    public Jogador(string nome, int idade, string time, int cartaoAmarelo, int cartaoVermelho){
        this.nome = nome;
        this.idade = idade;
        this.time = time;
        this.cartaoAmarelo = cartaoAmarelo;
        this.cartaoVermelho = cartaoVermelho;
    }
    public void registrarNumeroCatoesAmarelos(){
        this.cartaoAmarelo += cartaoAmarelo;
    }

    public void registrarNumeroCatoesVermelhos(){
        this.cartaoVermelho += cartaoVermelho;
    }

    public void verificarVinculoClube(){
        if(this.time == ""){
            this.time = "Jogador não tem time";
        }
        
    }

    public string imprimir(){
        return "\nNome: " + this.nome + "\nIdade: " + this.idade + "\nTime: " + this.time + "\nCartoes Amarelos: " + this.cartaoAmarelo + "\nCartoes Vemelhos: " + this.cartaoVermelho;
    }
    
    


 }

