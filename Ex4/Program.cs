using Ex4;

//Seguem abaixo os exercicios 4, 5 e 6

List<Pessoa> pessoas = new List<Pessoa>();

Pessoa p1 = new Pessoa("João", 15);
pessoas.Add(p1);
Pessoa p2 = new Pessoa("Leandro", 21);
pessoas.Add(p2);
Pessoa p3 = new Pessoa("Paulo", 17);
pessoas.Add(p3);
Pessoa p4 = new Pessoa("Jessica", 18);
pessoas.Add(p4);

Pessoa maisVelha = pessoas.MaxBy(p => p.Idade);
Console.WriteLine($"O nome da pessoa mais velha é: {maisVelha.Nome}");

for (int i = 0; i < pessoas.Count; i++)
{
    if (pessoas[i].Idade < 18)
    {
        pessoas.Remove(pessoas[i]);
    }

}

Console.WriteLine("Maiores de idade: ");
for (int i = 0; i < pessoas.Count; i++)
{
    Console.WriteLine($"Nome: {pessoas[i].Nome}");
}
for (int i = 0; i < pessoas.Count; i++)
{
    if (pessoas[i].Nome == "Jessica")
    {
        Console.WriteLine($"A Jessica existe e tem {pessoas[i].Idade} anos");
    }
}