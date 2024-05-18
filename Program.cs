using System;
using System.Runtime.InteropServices;
using Struct;
Console.WriteLine("\nExer 1");
Jogador jogador1 = new();

jogador1.nome = "Paulo";
jogador1.idade = 19;
jogador1.time = "Palmeiras";
jogador1.cartaoAmarelo = 10;
jogador1.cartaoVermelho = 20;

Console.WriteLine(jogador1.imprimir());

Console.WriteLine("\nExer 2");
 Equipes equipes1 = new();

 equipes1.nomeEquipe = "Abacate Poderoso Supremo";
 equipes1.dataEstreia = "11/12/2007";
 equipes1.vitorias = 60;
 equipes1.jogadores = 4;
 equipes1.Premios = 80;
 equipes1.registrarCampeonatoVencido(20);
 equipes1.atualizarValorTotalPremiacoes(1000);
 equipes1.verificarAnoEstreia(2005);

 Console.WriteLine(equipes1.imprimir());

Console.WriteLine("\nExer 3");

Produto produto1 = new();

produto1.nome = "Pão";
produto1.valor = 5;
produto1.dataValidade = "20/05/2024";
produto1.quantidade = 10;
produto1.cupom = 0;
produto1.porcen = 0.0;
produto1.aplicarCupomDescontoValor(3);
produto1.aplicarCupomDescontoPorcentagem(50);
produto1.verificarQuantidadeEmEstoque(produto1.quantidade);

Console.WriteLine(produto1.imprimir());

Console.WriteLine("\nExer 4");

Professor professor1 = new();

professor1.nome = "Cleiton";
professor1.materia = "Engenharia da Computação";
professor1.salario = 1250;
professor1.cargaHoraria = 50;
professor1.reajusteSalarialEmValor(500);
professor1.reajusteSalarialEmPorcentagem(25);
professor1.descontoSalarialPorFaltaEmValor(100, 2);
professor1.descontoSalarialPorFaltaEmPorcentagem(5, 2);
professor1.aumentarCargaHorariaDeTrabalho(5, 250);

Console.WriteLine(professor1.imprimir());
