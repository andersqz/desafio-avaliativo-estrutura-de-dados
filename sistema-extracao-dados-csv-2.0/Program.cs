using System;
using System.IO;
using System.IO.Pipes;
using System.Runtime.InteropServices;

/// <summary>
/// Classe principal responsável por executar o programa de análise climática.
/// </summary>
class Program
{
    /// <summary>
    /// Ponto de entrada do programa. Lê os dados climáticos de um CSV, filtra por temperatura,
    /// conta os registros por estação e exibe qual estação é mais quente, fria e amena.
    /// </summary>
    public static void Main()
    {
        // Lê o arquivo CSV e popula a lista geral com todos os registros climáticos
        string nome_arquivo = "dados.csv";
        List<Clima> dados_csv = new List<Clima>(); 
        dados_csv = Clima.getDadosCsv(nome_arquivo, dados_csv);

        // Filtra os registros por tipo de temperatura em listas separadas
        List<Clima> quente = Clima.FiltroPorTemperatura(dados_csv, "Quente");
        List<Clima> frio   = Clima.FiltroPorTemperatura(dados_csv, "Frio");
        List<Clima> ameno  = Clima.FiltroPorTemperatura(dados_csv, "Ameno");

        // Conta quantos registros de cada temperatura existem em cada estação
        int qtd_quente_verao   = Clima.ContarPorEstacao(quente, Clima.meses_verao);
        int qtd_frio_verao     = Clima.ContarPorEstacao(frio,   Clima.meses_verao);
        int qtd_ameno_verao    = Clima.ContarPorEstacao(ameno,  Clima.meses_verao);

        int qtd_quente_inverno = Clima.ContarPorEstacao(quente, Clima.meses_inverno);
        int qtd_frio_inverno   = Clima.ContarPorEstacao(frio,   Clima.meses_inverno);
        int qtd_ameno_inverno  = Clima.ContarPorEstacao(ameno,  Clima.meses_inverno);

        int qtd_quente_outono  = Clima.ContarPorEstacao(quente, Clima.meses_outono);
        int qtd_frio_outono    = Clima.ContarPorEstacao(frio,   Clima.meses_outono);
        int qtd_ameno_outono   = Clima.ContarPorEstacao(ameno,  Clima.meses_outono);

        // Exibe todos os registros agrupados por temperatura
        Clima.ExibeLista(quente);
        Clima.ExibeLista(frio);
        Clima.ExibeLista(ameno);

        // Exibe o resumo com a quantidade de cada temperatura por estação
        Console.WriteLine($"Quentes — Verão: {qtd_quente_verao} | Inverno: {qtd_quente_inverno} | Outono: {qtd_quente_outono}");
        Console.WriteLine($"Frios   — Verão: {qtd_frio_verao}   | Inverno: {qtd_frio_inverno}   | Outono: {qtd_frio_outono}");
        Console.WriteLine($"Amenos  — Verão: {qtd_ameno_verao}  | Inverno: {qtd_ameno_inverno}  | Outono: {qtd_ameno_outono}");

        // Determina e exibe qual estação teve mais registros de temperatura quente
        if (qtd_quente_verao > qtd_quente_inverno && qtd_quente_verao > qtd_quente_outono)
        {
            Console.WriteLine($"Estação mais quente: Verão — {qtd_quente_verao} registros");
        } 
        else if (qtd_quente_inverno > qtd_quente_outono)
        {
            Console.WriteLine($"Estação mais quente: Inverno — {qtd_quente_inverno} registros");
        } 
        else
        {
            Console.WriteLine($"Estação mais quente: Outono — {qtd_quente_outono} registros");
        }

        // Determina e exibe qual estação teve mais registros de temperatura fria
        if (qtd_frio_verao > qtd_frio_inverno && qtd_frio_verao > qtd_frio_outono)
        {
            Console.WriteLine($"Estação mais fria: Verão — {qtd_frio_verao} registros");
        }
        else if (qtd_frio_inverno > qtd_frio_outono)
        {
            Console.WriteLine($"Estação mais fria: Inverno — {qtd_frio_inverno} registros");
        }
        else
        {
            Console.WriteLine($"Estação mais fria: Outono — {qtd_frio_outono} registros");
        }

        // Determina e exibe qual estação teve mais registros de temperatura amena
        if (qtd_ameno_verao > qtd_ameno_inverno && qtd_ameno_verao > qtd_ameno_outono)
        {
            Console.WriteLine($"Estação mais amena: Verão — {qtd_ameno_verao} registros");
        }
        else if (qtd_ameno_inverno > qtd_ameno_outono)
        {
            Console.WriteLine($"Estação mais amena: Inverno — {qtd_ameno_inverno} registros");
        }
        else
        {
            Console.WriteLine($"Estação mais amena: Outono — {qtd_ameno_outono} registros");
        }
    }
}