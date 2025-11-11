namespace TransformeseApp2.DTO
{
    public class UsuarioDTO : PessoaDTO
    {
        public string Usuario { get; set; }
        public string Senha { get; set; }
        public int TpUsuario { get; set; }

        public override void ExibirInfo()
        {
            Console.WriteLine($"Id{Id}, Usuário: {Nome}, Username: {Usuario}, Senha: {Senha}");
        }


    }
}
