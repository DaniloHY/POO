using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Computador
{
    public CPU Cpu { get; set; }
    public MemoriaRAM Ram { get; set; }
    public HD Disco { get; set; }
    public PlacaVideo Gpu { get; set; }
    public FonteAlimentacao Fonte { get; set; }

    public Computador(CPU cpu, MemoriaRAM ram, HD disco, PlacaVideo gpu, FonteAlimentacao fonte)
    {
        Cpu = cpu;
        Ram = ram;
        Disco = disco;
        Gpu = gpu;
        Fonte = fonte;
    }

    public void Ligar()
    {
        List<Componente> componentes = new List<Componente> { Cpu, Ram, Disco, Gpu, Fonte };
        foreach (var componente in componentes)
        {
            if (!componente.Inicializar())
            {
                Console.WriteLine($"Falha na inicialização: {componente.GetType().Name}");
                return;
            }
        }

        Console.WriteLine("Computador ligado com sucesso!");
        MostrarConfiguracoes();
    }

    public void MostrarConfiguracoes()
    {
        Console.WriteLine($"CPU: {Cpu.Nucleos} núcleos, {Cpu.Clock} GHz");
        Console.WriteLine($"Memória RAM: {Ram.Capacidade} MB");
        Console.WriteLine($"Disco: {Disco.Capacidade} GB, tempo de escrita: {Disco.TempoEscrita} ms");
        Console.WriteLine($"Placa de Vídeo: {Gpu.Memoria} MB");
        Console.WriteLine($"Fonte de Alimentação: {Fonte.Potencia}W");
    }
}

