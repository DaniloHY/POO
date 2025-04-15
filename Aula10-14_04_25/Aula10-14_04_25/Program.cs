using Aula10_14_04_25;
//Classe abstrata só não pode ser instanciada, ela faz o que o resto das classes fazem, mas servem mais para a herança

//Isso não funciona
//Livro livro = new Livro();

//Isso funciona
Livro livro1 = new LivroAcademico();

//Metodos abstratos são metodos do pai, sem uma implementação
livro1.ImprimirDetalhes();


//Sobrecarga