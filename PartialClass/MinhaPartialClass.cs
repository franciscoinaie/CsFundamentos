namespace PartialClass
{
    //definindo os metodos da classe
    public partial class MinhaPartialClassProps
    {
        public TimeSpan CalculaIdade (DateTime DataNascimento)
        {
            return (DateTime.Now.Date - DataDeNascimento);
        }
        public TimeSpan DiferencaEntreDatas(DateTime data1, DateTime data2) 
        {
            var diferenca = data1.Subtract(data2);
            return diferenca;
        }
    }
}
