using TransformeseApp2.DAL;
using TransformeseApp2.DTO;

namespace TransformeseApp2.BLL
{
    public class AlunoBLL
    {
        public void CadastrarAluno(AlunoDTO alunoDTO)
        {
            //Validação antes de salvar o aluno
            if (string.IsNullOrWhiteSpace(alunoDTO.Nome))
                throw new Exception("Nome é  obrigatório");

            Database.Alunos.Add(alunoDTO);
        }

        public List<AlunoDTO> ListarAlunos() => Database.Alunos;

    }
}
