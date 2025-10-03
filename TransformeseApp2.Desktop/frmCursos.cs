using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransformeseApp2.BLL;
using TransformeseApp2.DAL;
using TransformeseApp2.DTO;

namespace TransformeseApp2.Desktop
{
    public partial class frmCursos : Form
    {
        private readonly AlunoBLL alunoBLL = new();
        public frmCursos()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                var aluno = new AlunoDTO
                {
                    Id = Database.Alunos.Count + 1,
                    Nome = txtNome.Text,
                    CursoId = (int)cboCurso.SelectedValue,
                    UnidadeId = (int)cboUnidade.SelectedValue,
                };

                alunoBLL.CadastrarAluno(aluno);

                MessageBox.Show(
                                $"Aluno {txtNome.Text} cadastrado com sucesso!",
                                "Cadastro de Aluno",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information
                                );
                txtNome.Clear();
                AtualizarGrid();



            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro: {erro.Message}");
            }
        }

        private void AtualizarGrid()
        {
            var lista = alunoBLL.ListarAlunos()
                                .Select(aluno => new
                                {
                                    aluno.Id,
                                    aluno.Nome,
                                    Curso = Database.Cursos.First(curso => curso.Id == aluno.CursoId).Nome,
                                    Unidade = Database.Unidades.First(unidade => unidade.Id == aluno.UnidadeId).Nome

                                }).ToList();

            dgAlunos.DataSource = lista;



        }
    }
}
