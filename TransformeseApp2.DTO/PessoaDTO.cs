namespace TransformeseApp2.DTO
{
    // Classe base com propriedades comuns
    public abstract class PessoaDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
        public string Sexo { get; set; }

        public string? UrlFoto { get; set; }

        // Método abstrato > Exemplo de abstração
        public abstract void ExibirInfo();
    }
}
