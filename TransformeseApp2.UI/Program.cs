using TransformeseApp2.BLL;
using TransformeseApp2.DTO;

AlunoBLL alunoBLL = new AlunoBLL();
CursoBLL cursoBLL = new CursoBLL();
UnidadeBLL unidadeBLL = new UnidadeBLL();

while (true)
{
    Console.Clear();
    Console.WriteLine(" === Sistema Transforme-se === ");
    Console.WriteLine(" 1 - Cadastrar Aluno ");
    Console.WriteLine(" 2 - Listar Alunos ");
    Console.WriteLine(" 3 - Cadastrar Curso ");
    Console.WriteLine(" 4 - Listar Cursos ");
    Console.WriteLine(" 5 - Cadastrar Unidade");
    Console.WriteLine(" 6 - Listar Unidades");
    Console.WriteLine(" 0 - Sair");

    Console.WriteLine(" Escolha uma opção: ");

    string opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Nome do aluno: ");
            string nomeAluno = Console.ReadLine();

            Console.WriteLine("ID do Curso: ");
            int cursoId = int.Parse(Console.ReadLine());

            Console.WriteLine("ID do Unidade: ");
            int unidadeId = int.Parse(Console.ReadLine());

            alunoBLL.CadastrarAluno(new AlunoDTO
            {
                Nome = nomeAluno,
                CursoId = cursoId,
                UnidadeId = unidadeId

            });

            Console.WriteLine($"Aluno {nomeAluno} cadastrado com sucesso");
            Pause();
            break;

        case "2":
            Console.Clear();
            Console.WriteLine(" === LISTA DE ALUNOS === ");

            var alunos = alunoBLL.ListarAlunos();

            foreach (var aluno in alunos)
            {
                var curso = cursoBLL.GetById(aluno.CursoId);
                var unidade = unidadeBLL.GetById(aluno.UnidadeId);

                //?? - operador de coalêscencia nula
                Console.WriteLine(
                    $"""
                    ID: {aluno.Id}
                    Nome: {aluno.Nome}
                    Curso: {curso?.Nome ?? "não encontrado"} 
                    Unidade: {unidade?.Nome ?? "não encontrada"}
                    """
                    );
            }

            Pause();
            break;

            case "3":
            Console.WriteLine("Nome do Curso:");

            string nomeCurso = Console.ReadLine();

            cursoBLL.CadastrarCurso(new CursoDTO { Nome = nomeCurso });

            Console.WriteLine("Curso cadastrado com sucesso!");
            Pause(); 
            break;

            case "4":
            Console.Clear();
            var cursos = cursoBLL.ListarCursos();
            foreach (var curso in cursos) 
            {
                Console.WriteLine(
                    $"ID: {curso.Id}, " +
                    $"Nome: {curso.Nome}, " +
                    $"Carga Horária: {curso.CargaHoraria}"
                    ); 
              
            }
            Pause();
            break;
    }

}

static void Pause()
{
    Console.WriteLine("\nPressione qualquer tecla para continuar.");
    Console.ReadKey();

    //Console.WriteLine("\nPressione 'F' para continuar...");

    //while (true)
    //{
    //    ConsoleKeyInfo keyInfo = Console.ReadKey(true); // true para não mostrar a tecla no console
    //    if (keyInfo.Key == ConsoleKey.F)
    //    {
    //        break; // Sai do loop e continua a aplicação
    //    }
    //    else
    //    {
    //        Console.WriteLine("Tecla inválida. Pressione 'S' para continuar.");
    //    }
    //}

    //ou

    //Console.WriteLine("\nPressione 'F' para continuar.");
    //while (Console.ReadKey(true).Key != ConsoleKey.F) { }

}
