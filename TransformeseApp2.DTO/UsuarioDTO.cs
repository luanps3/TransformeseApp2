namespace TransformeseApp2.DTO
{
    public class UsuarioDTO : PessoaDTO
    {
        public string Login { get; set; }
        public string Senha { get; set; }

        public override void ExibirInfo()
        {
            Console.WriteLine($"Id{Id}, Usuário: {Nome}, Username: {Login}, Senha: {Senha}");
        }


    }
}
