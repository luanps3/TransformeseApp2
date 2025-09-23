using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransformeseApp2.DAL;
using TransformeseApp2.DTO;
using TransformeseApp2.BLL;

namespace TransformeseApp2.Desktop
{
    public partial class frmAlunos : Form
    {
        private readonly AlunoBLL alunoBLL = new();
        public frmAlunos()
        {
            InitializeComponent();
        }

        private void frmAlunos_Load(object sender, EventArgs e)
        {
            //Preenche Cursos (simulação de banco de dados)
            if (!Database.Cursos.Any())
            {
                Database.Cursos.Add(new CursoDTO { Id = 1, Nome = "Programado de Sistemas" });
                Database.Cursos.Add(new CursoDTO { Id = 2, Nome = "Banco de Dados" });
            }

            //Preenche Unidades (simulação de banco de dados)
            if (!Database.Unidades.Any())
            {
                Database.Unidades.Add(new UnidadeDTO { Id = 1, Nome = "SMP - São Miguel Paulista" });
                Database.Unidades.Add(new UnidadeDTO { Id = 2, Nome = "ITQ - Itaquera" });
            }

            //Populando combobox de cursos
            cboCurso.DataSource = Database.Cursos; // Obtem lista completa de cursos
            cboCurso.DisplayMember = "Nome"; // Atributo que será exibido no combobox
            cboCurso.ValueMember = "Id"; // Atributo que será atrelado ao item exibido

            //Populando combobox de unidades
            cboUnidade.DataSource = Database.Unidades; // Obtem lista completa de unidades
            cboUnidade.DisplayMember = "Nome"; // Atributo que será exibido no combobox
            cboUnidade.ValueMember = "Id"; // Atributo que será atrelado ao item exibido

            cboCurso.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUnidade.DropDownStyle = ComboBoxStyle.DropDownList;

            AtualizarGrid();

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
