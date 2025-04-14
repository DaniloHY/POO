/*Cachorro cachorro = new Cachorro("Rex", "Golden", 3, true);
Gato gato = new Gato("Garfield", "Laranja", 2);
Peixe peixe = new Peixe("Nemo", "Palhaço", 2);
Passaro passaro = new Passaro("Frank", "Arara-Azul", 70, true);

List<Animal> animals = new List<Animal>();

animals.Add(cachorro);
animals.Add(gato);
animals.Add(peixe);
animals.Add(passaro);

foreach (Animal animal in animals)
{
    Console.Write($"O {animal.Nome} que é um {animal.Raca} que tem idade de {animal.Idade} anos fez o barulho ");
    animal.EmitirSom();
}*/

Guerreiro guerreiro = new Guerreiro(100,20);
Arqueiro arqueiro = new Arqueiro(80,5, 5);

guerreiro.AtacarPersonagem(arqueiro);
arqueiro.AtacarPersonagem(guerreiro);
arqueiro.AtacarPersonagem(guerreiro);
arqueiro.AtacarPersonagem(guerreiro);
arqueiro.AtacarPersonagem(guerreiro);
arqueiro.AtacarPersonagem(guerreiro);
arqueiro.AtacarPersonagem(guerreiro);