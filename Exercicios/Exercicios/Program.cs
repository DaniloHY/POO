/*Funcionario funcionario1 = new Funcionario("Eu", "isso", 1500);
Funcionario funcionario2 = new Funcionario("Tu", "Eai", 1800);

funcionario1.ImprimirSalario();
funcionario2.ImprimirSalario();

*/

/*
Retangulo retangulo = new Retangulo(20,10);
Console.WriteLine(retangulo.Area());
Console.WriteLine(retangulo.Perimetro());
*/


/*
 * Aula 5 - Ex 3?
Aluno[] alunos = new Aluno[10];
alunos[0] = new Aluno("João", 8.5);
alunos[1] = new Aluno("Maria", 7.0);
alunos[2] = new Aluno("Pedro", 9.2);
alunos[3] = new Aluno("Ana", 6.8);
alunos[4] = new Aluno("Carlos", 7.5);
alunos[5] = new Aluno("Mariana", 8.0);
alunos[6] = new Aluno("Ricardo", 6.5);
alunos[7] = new Aluno("Fernanda", 9.0);
alunos[8] = new Aluno("Gustavo", 7.3);

*/

/*
List<Animal> animais = new List<Animal>
{
    new Cachorro("Rex", 5, "Labrador"),
    new Cachorro("Max", 3, "Bulldog"),
    new Cachorro("Bob", 4, "Golden Retriever"),
    new Gato("Mimi", 3, "Branco"),
    new Gato("Luna", 2, "Preto"),
    new Gato("Felix", 4, "Cinza")
};

foreach (var animal in animais)
{
    Console.WriteLine($"Nome: {animal.Nome}, Idade: {animal.Idade}");
    animal.Andar();

    if (animal is Cachorro cachorro)
    {
        Console.WriteLine($"Raça: {cachorro.Raca}");
        cachorro.Latir();
    }
    else if (animal is Gato gato)
    {
        Console.WriteLine($"Cor do pelo: {gato.Cor}");
        gato.Miar();
    }
    Console.WriteLine();
}
*/

/* Lista 1 Ex 1
FuncionarioLista funcionario1 = new FuncionarioLista("Eu", "123456", 5005);
funcionario1.Salario();
*/

/* EX 2
List<Disciplina> disciplinas = new List<Disciplina>
        {
            new Disciplina("Algoritmos", 5),
            new Disciplina("Cálculo", 7)
        };

disciplinas[0].AdicionarAluno(new Alunos("João", new List<double> { 6, 7, 5 }));
disciplinas[0].AdicionarAluno(new Alunos("Maria", new List<double> { 4, 5, 3 }));
disciplinas[1].AdicionarAluno(new Alunos("Carlos", new List<double> { 8, 7, 9 }));
disciplinas[1].AdicionarAluno(new Alunos("Ana", new List<double> { 6, 7, 6 }));

foreach (var disciplina in disciplinas)
{
    Console.WriteLine($"\nDisciplina: {disciplina.Nome}");
    Console.WriteLine("-----------------------------------");
    foreach (var aluno in disciplina.Aluno)
    {
        Console.WriteLine($"Aluno: {aluno.Nome}, Média: {aluno.CalcularMedia():F2}, Aprovado: {(aluno.CalcularMedia() >= disciplina.NotaAprovacao ? "Sim" : "Não")}");
    }
}
*/

AgendaTelefonica agenda = new AgendaTelefonica();

agenda.AdicionarContato(new Contato("João Silva", "joao@email.com", "1234-5678"));
agenda.AdicionarContato(new Contato("Maria Souza", "maria@email.com", "8765-4321"));

Console.WriteLine("Lista de Contatos:");
agenda.ListarContatos();

Console.WriteLine("\nBuscando contato por nome: João Silva");
Console.WriteLine("Telefone: " + agenda.BuscarContatoPorNome("João Silva"));

Console.WriteLine("\nBuscando contato por email: maria@email.com");
Console.WriteLine("Telefone: " + agenda.BuscarContatoPorEmail("maria@email.com"));

Console.WriteLine("\nAlterando contato de João Silva");
agenda.AlterarContato("João Silva", "joao.novo@email.com", "1122-3344");
agenda.ListarContatos();

Console.WriteLine("\nRemovendo contato de Maria Souza");
agenda.RemoverContato("Maria Souza");
agenda.ListarContatos();
