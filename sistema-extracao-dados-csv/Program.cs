class Program
{
    static void Main()
    {
        string nomeArquivo = "dados.csv";
        
        // listas que vao receber os dadosClimaticos separando para cada lista uma estação, lista com dados verao, lista com dados inverno e lista com dados outono
        List<Clima> dadosClimaticos = new List<Clima>();
        List<Clima> dadosVerao = new List<Clima>();
        List<Clima> dadosInverno = new List<Clima>();
        List<Clima> dadosOutono = new List<Clima>();

        // método que recebe o nome do arquivo que esta os dados e uma lista vazia para receber os dados gerais nessa lista
        dadosClimaticos = Clima.LerDadosEpassarParaLista(nomeArquivo, dadosClimaticos);

        // instaciação das listas vazias de cada estação recebendo por argumento os dadosClimaticos separados para cada estação
        dadosVerao = Clima.DadosVerao(dadosClimaticos);
        dadosInverno = Clima.DadosInverno(dadosClimaticos);
        dadosOutono = Clima.DadosOutono(dadosClimaticos);

        // listas declaradas para receber apenas as linhas que são de determinada temperatura, lista com temp quente, lista com temp frio, lista com temp ameno
        List<Clima> Quente = new List<Clima>();
        List<Clima> Frio = new List<Clima>();
        List<Clima> Ameno = new List<Clima>();


        // SAIDA DE DADOS EXIBINDO OS DADOS APENAS NA TEMPERATURA QUENTE E EXIBINDO A QUANTIDADE DE TEMPERATURA QUENTE EM CADA ESTAÇÃO
        Console.WriteLine("----------------------------------------------");
        Quente = Clima.MaisQuente(dadosClimaticos);
        int quenteInVerao = Clima.QuantidadeQuenteEmVerao(Quente);
        int quenteInInverno = Clima.QuantidadeQuenteEmInverno(Quente);
        int quenteInOutono = Clima.QuantidadeQuenteEmOutono(Quente);
        Console.WriteLine($"Quantidade de temperaturas quentes no verão:  {quenteInVerao}");
        Console.WriteLine($"Quantidade de temperaturas quentes no inverno:  {quenteInInverno}");
        Console.WriteLine($"Quantidade de temperaturas quentes no outono:  {quenteInOutono}");
        Console.WriteLine("----------------------------------------------");

        // SAIDA DE DADOS EXIBINDO OS DADOS APENAS NA TEMPERATURA FRIO E EXIBINDO A QUANTIDADE DE TEMPERATURA FRIO EM CADA ESTAÇÃO
        Console.WriteLine("----------------------------------------------");
        Frio = Clima.MaisFrio(dadosClimaticos);
        int frioInVerao = Clima.QuantidadeFrioEmVerao(Frio);
        int frioInInverno = Clima.QuantidadeFrioEmInverno(Frio);
        int frioInOutono = Clima.QuantidadeFrioEmOutono(Frio);
        Console.WriteLine($"Quantidade de temperaturas frias no verão: {frioInVerao}");
        Console.WriteLine($"Quantidade de temperaturas frias no inverno: {frioInInverno}");
        Console.WriteLine($"Quantidade de temperaturas frias no outono: {frioInOutono}");
        Console.WriteLine("----------------------------------------------");

        // SAIDA DE DADOS EXIBINDO OS DADOS APENAS NA TEMPERATURA AMENO E EXIBINDO A QUANTIDADE DE TEMPERATURA AMENO EM CADA ESTAÇÃO
        Console.WriteLine("----------------------------------------------");
        Ameno = Clima.MaisAmeno(dadosClimaticos);
        int amenoInVerao = Clima.QuantidadeAmenoEmVerao(Ameno);
        int amenoInInverno = Clima.QuantidadeAmenoEmInverno(Ameno);
        int amenoInOutono = Clima.QuantidadeAmenoEmOutono(Ameno);
        Console.WriteLine($"Quantidade de temperaturas amenas no verão: {amenoInVerao}");
        Console.WriteLine($"Quantidade de temperaturas amenas no inverno: {amenoInInverno}");
        Console.WriteLine($"Quantidade de temperaturas amenas no outono: {amenoInOutono}");
        Console.WriteLine("----------------------------------------------");
        
        // CONDICIONAIS PARA DESCOBRIR QUAL ESTAÇÃO MAIS QUENTE
        Console.WriteLine("==========================================================");
        if (quenteInVerao > quenteInInverno && quenteInVerao > quenteInOutono)
        {
            Console.WriteLine($"Estação mais quente: Verão");
            Console.WriteLine($"Quantidade de temp quentes: {quenteInVerao}");
        }
        else if (quenteInInverno > quenteInOutono){
            Console.WriteLine($"Estação mais quente: Inverno");
            Console.WriteLine($"Quantidade de temp quentes: {quenteInInverno}");
        }
        else
        {
            Console.WriteLine($"Estação mais quente: Outono");
            Console.WriteLine($"Quantidade de temp quentes: {quenteInOutono}");
        }


        // CONDICIONAIS PARA DESCOBRIR QUAL ESTAÇÃO MAIS FRIA
        //=====================================================================
        if (frioInVerao > frioInInverno && frioInVerao > frioInOutono)
        {
            Console.WriteLine($"Estação mais fria: Verão");
            Console.WriteLine($"Quantidade de temp frias: {frioInVerao}");
        }
        else if (frioInInverno > frioInOutono){
            Console.WriteLine($"Estação mais fria: Inverno");
            Console.WriteLine($"Quantidade de temp frias: {frioInInverno}");
        }
        else
        {
            Console.WriteLine($"Estação mais fria: Outono");
            Console.WriteLine($"Quantidade de temp frias: {frioInOutono}");
        }


        // CONDICIONAIS PARA DESCOBRIR QUAL ESTAÇÃO MAIS AMENO
        //==================================================================
        if (amenoInVerao > amenoInInverno && amenoInVerao > amenoInOutono)
        {
            Console.WriteLine($"Estação mais amena: Verão");
            Console.WriteLine($"Quantidade de temp amenas: {amenoInVerao}");
        }
        else if (amenoInInverno > amenoInOutono){
            Console.WriteLine($"Estação mais ameno: Inverno");
            Console.WriteLine($"Quantidade de temp amenas: {amenoInInverno}");
        }
        else
        {
            Console.WriteLine($"Estação mais fria: Outono");
            Console.WriteLine($"Quantidade de temp frias: {amenoInOutono}");
        }
        Console.WriteLine("==========================================================");
        Console.WriteLine("Fim do sistema!");
        

    } // Fim Método Main
} // Fim Class Princ