using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Partida
{
    private Time time1;
    private Time time2;
    private Time posseBola;
    private int acoesNoTurno;
    private Random rand = new Random();

    public Partida(Time t1, Time t2)
    {
        time1 = t1;
        time2 = t2;
        posseBola = rand.Next(2) == 0 ? t1 : t2;
        acoesNoTurno = 0;
    }

    public void Jogar()
    {
        while (time1.Pontos < 25 && time2.Pontos < 25)
        {
            acoesNoTurno = 0;
            Narrador.DescreverAcao($"{posseBola.Nome} tem a posse da bola!");
            RealizarJogada();
        }
        Console.WriteLine($"{(time1.Pontos >= 25 ? time1.Nome : time2.Nome)} venceu a partida!");
    }

    private void RealizarJogada()
    {
        Jogador sacador = posseBola.Jogadores[0];
        sacador.PodeSacar = true;

        if (!sacador.Sacar())
        {
            TrocarPosse();
            return;
        }

        Narrador.DescreverAcao($"{sacador.Nome} sacou a bola!");
        acoesNoTurno++;

        Jogador levantador = posseBola.Jogadores[1];
        bool bolaLevantada = levantador.Levantar();
        Narrador.DescreverAcao($"{levantador.Nome} levantou a bola!");
        acoesNoTurno++;

        Jogador atacante = posseBola.Jogadores[2];
        if (acoesNoTurno < 3 && atacante.Atacar(bolaLevantada))
        {
            Narrador.DescreverAcao($"{atacante.Nome} atacou e fez um ponto!");
            posseBola.Pontos++;
        }
        else
        {
            Narrador.DescreverAcao($"{atacante.Nome} atacou, mas não fez o ponto!");
            TrocarPosse();
        }
    }

    private void TrocarPosse()
    {
        posseBola = posseBola == time1 ? time2 : time1;
    }
}

