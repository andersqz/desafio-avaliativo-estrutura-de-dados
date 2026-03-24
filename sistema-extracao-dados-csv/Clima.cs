class Clima
{
    // declaração dos atributos da classe
    public string Ano;
    public string Mes;
    public string Temperatura;
    public string Precipitacao;
 

    // Classe construtor, sem o this
    public Clima(string ano, string mes, string temperatura, string precipitacao)
    {
        Ano = ano;
        Mes = mes;
        Temperatura = temperatura;
        Precipitacao = precipitacao;
    }

    // esse método ToString serve para exibir na tela os atributos da classe quando solicitado
    // por exemplo, ao printar o objeto instanciado 'clima' da classe Clima, 
    // vai mostrar o conteudo dos atributos da classe
    public override string ToString()
    {
        return $"Ano: {Ano} | Mes: {Mes} | Temperatura: {Temperatura} | Precipitacao: {Precipitacao}";
    }
   

    // Método que recebe como parâmetros o nome do arquivo e uma lista vazia da classe Clima
    // ela le o conteudo do arquivo e salva em uma variável 'linha', essa variável linha é repartida com o 'Split(',')' 
    // em cada virgula do arquivo, cada pedaço separado é salvo no vetor 'partes', após, é salvo cada posição desse vetor
    // em uma variavel local correspondente com o dado do arquivo, depois é instanciado um objeto da classe Clima com os parametros
    // ano, mes, temperatura e precipitação, esse objeto pe salvo na lista que foi passada como parâmetro, cada iteração do loop,
    // pega uma linha e segue o fluxo falado acima
    public static List<Clima> LerDadosEpassarParaLista(string nomeArquivo, List<Clima> lista)
    {  
        string[] linhas = File.ReadAllLines(nomeArquivo);
 
        for (int i = 1; i < linhas.Length; i++)
        {
            string linha = linhas[i];
            string[] partes = linha.Split(',');
 
            string ano = (partes[0]);
            string mes = partes[1];
            string temperatura = partes[2];
            string precipitacao = partes[3];
 
            Clima clima = new Clima(ano, mes, temperatura, precipitacao);
            lista.Add(clima);
        }
        return lista;
    }
 

    // método que recebe a lista com todos os dados climáticos e usa um loop foreach
    // para percorrer a lista por completo, e exibir na tela
    public static void ExibirListaGeral(List<Clima> lista)
    {
        foreach (Clima elemento in lista)
        {
            System.Console.WriteLine(elemento.ToString());
        }
    }
 
    public static List<Clima> DadosVerao(List<Clima> lista)
    {
        List<Clima> dadosVerao = new List<Clima>();
        string[] mesesVerao = {"Dezembro", "Janeiro", "Fevereiro", "Março"};

        foreach (Clima clima in lista)
        {
            foreach (string mes in mesesVerao)
            {
                if (clima.Mes == mes)
                {
                    dadosVerao.Add(clima);
                    break;
                }
            }
        }
        return dadosVerao;
    }


    public static List<Clima> DadosInverno(List<Clima> lista)
    {
        List<Clima> dadosInverno = new List<Clima>();
        string[] mesesInverno = {"Agosto", "Setembro", "Outubro", "Novembro"};

        foreach (Clima clima in lista)
        {
            foreach (string mes in mesesInverno)
            {
                if (clima.Mes == mes)
                {
                    dadosInverno.Add(clima);
                    break;
                }
            }
        }
        return dadosInverno;
    }


    public static List<Clima> DadosOutono(List<Clima> lista)
    {
        List<Clima> dadosOutono = new List<Clima>();
        string[] mesesOutono = {"Abril", "Maio", "Junho", "Julho"};

        foreach (Clima clima in lista)
        {
            foreach (string mes in mesesOutono)
            {
                if (clima.Mes == mes)
                {
                    dadosOutono.Add(clima);
                    break;
                }
            }
        }
        return dadosOutono;
    }


    
    //método que recebe a lista dadosClimaticos e retorna em uma lista apenas as linhas que sejam == "Quente"
    public static List<Clima> MaisQuente(List<Clima> lista) {

        List<Clima> quente = new List<Clima>();

        foreach (Clima clima in lista) {
            if (clima.Temperatura == "Quente")
            {
                quente.Add(clima);
            }
        }
        foreach (Clima n in quente) {
            Console.WriteLine(n);
        }
        return quente;
    }


    // método que recebe a lista dadosClimaticos e retorna em uma lista apenas as linhas que sejam == "Frio"
    public static List<Clima> MaisFrio(List<Clima> lista)
    {
        List<Clima> frio = new List<Clima>();

        foreach (Clima clima in lista)
        {
            if (clima.Temperatura == "Frio")
            {
                frio.Add(clima);
            }
        }
        foreach (Clima n in frio)
        {
            Console.WriteLine(n);
        }
        return frio;

    }

    // método que recebe a lista dadosClimaticos e retorna em uma lista apenas as linhas que contém a temperatura == "Ameno
    public static List<Clima> MaisAmeno(List<Clima> lista)
    {
        List<Clima> ameno = new List<Clima>();

        foreach (Clima clima in lista)
        {
            if (clima.Temperatura == "Ameno")
            {
                ameno.Add(clima);
            }
        }
        foreach (Clima n in ameno)
        {
            Console.WriteLine(n);
        }
        return ameno;
    }   


    // método que recebe a lista com todas as linhas que contém a temperatura "Quente" e soma quantas temperaturas "Quente" tem na estação verão
    public static int QuantidadeQuenteEmVerao(List<Clima> lista)
    {   
        int qntdQuenteEmVerao = 0;
        string[] mesesVerao = {"Dezembro", "Janeiro", "Fevereiro", "Março"};
        foreach (Clima clima in lista)
        {
            foreach (string i in mesesVerao)
            {
                if (clima.Mes == i)
                {
                    qntdQuenteEmVerao++;
                    break;
                }
            }
        }

        return qntdQuenteEmVerao;
    }


    // método que recebe a lista com todas as linhas que contém temperatura "Frio" e soma quantas temperaturas "Frio" tem na estação verão
    public static int QuantidadeFrioEmVerao(List<Clima> lista)
    {
        string[] mesesVerao = {"Dezembro", "Janeiro", "Fevereiro", "Março"};
        int qntdFrioEmVerao = 0;
        foreach (Clima clima in lista)
        {
            foreach (string i in mesesVerao)
            {
                if (clima.Mes == i)
                {
                    qntdFrioEmVerao++;
                    break;
                }
            }
        }
        return qntdFrioEmVerao;
    }


        // método que recebe a lista com todas as linhas que contém temperatura "Ameno" e soma quantas temperaturas "Ameno" tem na estação verão
    public static int QuantidadeAmenoEmVerao(List<Clima> lista)
    {
        string[] mesesVerao = {"Dezembro", "Janeiro", "Fevereiro", "Março"};
        int qntdAmenoEmVerao = 0;
        foreach (Clima clima in lista)
        {
            foreach (string i in mesesVerao)
            {
                if (clima.Mes == i)
                {
                    qntdAmenoEmVerao++;
                    break;
                }
            }
        }
        return qntdAmenoEmVerao;
    }


    // método que recebe a lista com as linhas que contém a temperatura == "Quente" e soma quantas Temperaturas "Quente" tem na estação inverno
    public static int QuantidadeQuenteEmInverno(List<Clima> lista)
    {
        string[] mesesInverno = {"Agosto", "Setembro", "Outubro", "Novembro"};
        int qntdQuenteEmInverno = 0;
        foreach (Clima clima in lista)
        {
            foreach (string i in mesesInverno)
            {
                if (clima.Mes == i)
                {
                    qntdQuenteEmInverno++;
                    break;
                }
            }
        }
        return qntdQuenteEmInverno;
    }

    
    // método que recebe a lista com as linhas que contém a temperatura == "Frio" e soma quantas Temperaturas "Frio" tem na estação inverno
    public static int QuantidadeFrioEmInverno(List<Clima> lista)
    {
        string[] mesesInverno = {"Agosto", "Setembro", "Outubro", "Novembro"};
        int qntdFrioEmInverno = 0;
        foreach (Clima clima in lista)
        {
            foreach (string i in mesesInverno)
            {
                if (clima.Mes == i)
                {
                    qntdFrioEmInverno++;
                    break;
                }
            }
        }
        return qntdFrioEmInverno;
    }


    // método que recebe a lista com linhas que contém a temperatura == "Ameno" e soma quantas Temperaturas "Amenos" tem na estação inverno
    public static int QuantidadeAmenoEmInverno(List<Clima> lista)
    {
        string[] mesesInverno = {"Agosto", "Setembro", "Outubro", "Novembro"};
        int qntdAmenoEmInverno = 0;
        foreach (Clima clima in lista)
        {
            foreach (string i in mesesInverno)
            {
                if (clima.Mes == i)
                {
                    qntdAmenoEmInverno++;
                    break;
                }
            }
        }
        return qntdAmenoEmInverno;
    }


    // método que recebe a lista com linhas que contém a temperatura == "Quente" e soma quantas Temperaturas "Quente" tem na estação outono
    public static int QuantidadeQuenteEmOutono(List<Clima> lista)
    {
        string[] mesesInverno = {"Abril", "Maio", "Junho", "Julho"};
        int qntdQuenteEmOutono = 0;
        foreach (Clima clima in lista)
        {
            foreach (string i in mesesInverno)
            {
                if (clima.Mes == i)
                {
                    qntdQuenteEmOutono++;
                    break;
                }
            }
        }
        return qntdQuenteEmOutono;
    }


    // método que recebe a lista com linhas que contém a temperatura == "Frio" e soma quantas Temperaturas "Frio" tem na estação Outono
    public static int QuantidadeFrioEmOutono(List<Clima> lista)
    {
        string[] mesesInverno = {"Abril", "Maio", "Junho", "Julho"};
        int qntdFrioEmOutono = 0;
        foreach (Clima clima in lista)
        {
            foreach (string i in mesesInverno)
            {
                if (clima.Mes == i)
                {
                    qntdFrioEmOutono++;
                    break;
                }
            }
        }
        return qntdFrioEmOutono;
    }

    // método que recebe a lista com linhas que contém a temperatura == "Ameno" e soma quantas Temperaturas "Ameno" tem na estação Outono
    public static int QuantidadeAmenoEmOutono(List<Clima> lista)
    {
        string[] mesesInverno = {"Abril", "Maio", "Junho", "Julho"};
        int qntdAmenoEmOutono = 0;
        foreach (Clima clima in lista)
        {
            foreach (string i in mesesInverno)
            {
                if (clima.Mes == i)
                {
                    qntdAmenoEmOutono++;
                    break;
                }
            }
        }
        return qntdAmenoEmOutono;
    }
}