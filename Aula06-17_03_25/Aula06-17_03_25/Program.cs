/*
Conta conta1 = null;
int[] numeros = new int[5];

try
{
    //Console.WriteLine($"Seu saldo é: {conta1.Saldo}");
    Console.WriteLine(numeros[5]);
}
catch(Exception ex)
{
    Console.WriteLine ("Deu erro na hora de obter o saldo");
}

catch(IndexOutOfRangeException ex)
{
    Console.WriteLine("Deu erro na hora de obter o valor do array");
}


Console.WriteLine("Continuou aqui");


//Conta conta1 = new Conta(200, "12345");
//Conta conta2 = new Conta(500,"67891");
Console.WriteLine($"Sua conta é: {conta1.NumeroConta}");
Console.WriteLine($"Seu saldo é: {conta2.Saldo}");
Console.WriteLine($"Sua conta é: {conta1.NumeroConta}");*/

Carro carro = new Carro(16,4,"Azul","Ford",20);


Bicicleta bicicleta = new Bicicleta(2, "vermelho", "Caloi", 10);


List<Veiculo> veiculos = new List<Veiculo>();
veiculos.Add(carro);
veiculos.Add(bicicleta);

foreach (Veiculo veiculo in veiculos)
{
    veiculo.Acelerar(20);
    Console.WriteLine(veiculo.Velocidade);
}



//Console.WriteLine($"Velocidade é: {carro.Velocidade} \nPotencia Motor: {carro.PotenciaMotor}");