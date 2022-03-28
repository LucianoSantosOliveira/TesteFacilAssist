namespace TesteFacilAssist
{
    public class Cliente
    {
        string nome;
        string cpf;
        string? tipoCliente;
        string sexo;
        string? situacaoCliente;


        public Cliente(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string TipoCliente { get => tipoCliente; set => tipoCliente = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string SituacaoCliente { get => situacaoCliente; set => situacaoCliente = value; }
    }
}
