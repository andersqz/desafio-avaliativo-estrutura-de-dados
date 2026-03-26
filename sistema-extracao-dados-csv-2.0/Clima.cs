/// <summary>
/// Representa um registro climático mensal, contendo ano, mês, temperatura e precipitação.
/// </summary>
class Clima
{
    /// <summary>Ano do registro climático.</summary>
    public string Ano;

    /// <summary>Mês do registro climático.</summary>
    public string Mes;

    /// <summary>Classificação da temperatura do registro (Quente, Frio ou Ameno).</summary>
    public string Temperatura;

    /// <summary>Nível de precipitação do registro (muita, média, pouca ou nada).</summary>
    public string Precipitacao;

    /// <summary>Meses que pertencem à estação do Verão.</summary>
    public static string[] meses_verao = {"Dezembro", "Janeiro", "Fevereiro", "Março"};

    /// <summary>Meses que pertencem à estação do Inverno.</summary>
    public static string[] meses_inverno = {"Agosto", "Setembro", "Outubro", "Novembro"};

    /// <summary>Meses que pertencem à estação do Outono.</summary>
    public static string[] meses_outono = {"Abril", "Maio", "Junho", "Julho"};


    /// <summary>
    /// Cria um novo registro climático com os dados fornecidos.
    /// </summary>
    /// <param name="ano">Ano do registro.</param>
    /// <param name="mes">Mês do registro.</param>
    /// <param name="temperatura">Classificação da temperatura (Quente, Frio ou Ameno).</param>
    /// <param name="precipitacao">Nível de precipitação (muita, média, pouca ou nada).</param>
    public Clima(string ano, string mes, string temperatura, string precipitacao)
    {
        this.Ano = ano;
        this.Mes = mes;
        this.Temperatura = temperatura;
        this.Precipitacao = precipitacao;
    }


    /// <summary>
    /// Retorna uma string formatada com todos os dados do registro climático.
    /// </summary>
    /// <returns>String no formato: Ano | Mes | Temperatura | Precipitação</returns>
    public override string ToString()
    {
        return $"Ano: {this.Ano} | Mes: {this.Mes} | Temperatura: {this.Temperatura} | Precipitação: {this.Precipitacao}";
    }


    /// <summary>
    /// Lê um arquivo CSV e popula uma lista com os registros climáticos encontrados.
    /// </summary>
    /// <param name="nome_arquivo">Caminho do arquivo CSV a ser lido.</param>
    /// <param name="dados_csv">Lista vazia que receberá os registros lidos.</param>
    /// <returns>Lista preenchida com todos os registros do arquivo.</returns>
    public static List<Clima> getDadosCsv(string nome_arquivo, List<Clima> dados_csv)
    {  
        string[] linhas = File.ReadAllLines(nome_arquivo);

        for (int i = 1; i < linhas.Length; i++)
        {
            string linha = linhas[i];
            string[] partes = linha.Split(',');

            string ano = partes[0];
            string mes = partes[1];
            string temperatura = partes[2];
            string precipitacao = partes[3];

            Clima clima = new Clima(ano, mes, temperatura, precipitacao);
            dados_csv.Add(clima);
        }
        return dados_csv;
    }


    /// <summary>
    /// Filtra uma lista de registros climáticos por tipo de temperatura.
    /// </summary>
    /// <param name="lista">Lista geral com todos os registros climáticos.</param>
    /// <param name="temperatura">Tipo de temperatura a filtrar (Quente, Frio ou Ameno).</param>
    /// <returns>Nova lista contendo apenas os registros com a temperatura informada.</returns>
    public static List<Clima> FiltroPorTemperatura(List<Clima> lista, string temperatura)
    {
        List<Clima> resultado = new List<Clima>();

        foreach (Clima clima in lista)
        {
            if (clima.Temperatura == temperatura)
            {
                resultado.Add(clima);
            }
        }
        return resultado;
    }


    /// <summary>
    /// Conta quantos registros de uma lista pertencem a uma determinada estação do ano.
    /// </summary>
    /// <param name="lista">Lista de registros já filtrada por temperatura.</param>
    /// <param name="meses">Array com os meses da estação desejada.</param>
    /// <returns>Quantidade de registros que pertencem à estação informada.</returns>
    public static int ContarPorEstacao(List<Clima> lista, string[] meses)
    {   
        int count = 0;
        foreach (Clima clima in lista)
        {
            if (meses.Contains(clima.Mes))
            {
                count++;
            }
        }
        return count;
    }


    /// <summary>
    /// Exibe no console todos os registros de uma lista, seguidos de uma linha separadora.
    /// </summary>
    /// <param name="lista">Lista de registros climáticos a ser exibida.</param>
    public static void ExibeLista(List<Clima> lista)
    {
        foreach (Clima i in lista)
        {
            System.Console.WriteLine(i);
        }
        System.Console.WriteLine("-----------------------------------------------------------------------");
    }
}