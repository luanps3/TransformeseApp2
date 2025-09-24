using TransformeseApp2.DAL;
using TransformeseApp2.DTO;

namespace TransformeseApp2.BLL
{
    public class AlunoBLL
    {
        public void CadastrarAluno(AlunoDTO alunoDTO)
        {
            alunoDTO.Id = Database.Alunos.Any() ? Database.Alunos.Max(aluno => aluno.Id) + 1 : 1;
            //Validação antes de salvar o aluno
            if (string.IsNullOrWhiteSpace(alunoDTO.Nome))
                throw new Exception("Nome é  obrigatório");

            Database.Alunos.Add(alunoDTO);
        }

        public List<AlunoDTO> ListarAlunos() => Database.Alunos;

        public void RemoverAluno(int id)
        {
            var aluno = Database.Alunos.FirstOrDefault(a => a.Id == id);

            if(aluno == null)
            {
                throw new Exception("Aluno não encontrado");
            }

            Database.Alunos.Remove(aluno);
        }



    }
}
