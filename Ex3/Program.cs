using Ex3;

Console.WriteLine("Insira o nome do personagem: ");
string nome = Console.ReadLine();
Console.WriteLine("Insira a mana do personagem: ");
int mana = int.Parse(Console.ReadLine());
Console.WriteLine("Insira a vida do personagem: ");
int vida = int.Parse(Console.ReadLine());
Console.WriteLine("Insira o XP do personagem: ");
float xp = float.Parse(Console.ReadLine());
Console.WriteLine("Insira a inteligencia do personagem: ");
int inteligencia = int.Parse(Console.ReadLine());
Console.WriteLine("Insira a força do personagem: ");
int forca = int.Parse(Console.ReadLine());
Console.WriteLine("Insira o level do personagem: ");
int level = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o nome da magia inicial: ");
string magia = Console.ReadLine();
List<string> magias = new List<string>();
magias.Add(magia);

Mago mago = new Mago(nome, mana, vida, xp, inteligencia, forca, level, magias);

Console.WriteLine($"Nome: {mago.Nome}, Mana: {mago.Mana}, Vida: {mago.Vida}, Xp: {mago.Xp}, Inteligencia: {mago.Inteligencia}, Força: {mago.Forca}, " +
    $"Level: {mago.Level}");
Console.WriteLine("Magias: ", mago.Magias);
for (int i = 0; i < mago.Magias.Count; i++)
{
    Console.WriteLine(mago.Magias[i]);
}
mago.LvlUp();
Console.WriteLine("Parabens você ganhou um level: ");
Console.WriteLine(mago.Level);
Console.WriteLine("Parabens você aprendeu uma nova magia");
mago.AprenderMagia("Bola de fogo");
Console.WriteLine("Lista de magias: ");
for (int i = 0; i < mago.Magias.Count; i++)
{
    Console.WriteLine(mago.Magias[i]);
}

Console.WriteLine("O mago atacou");
Console.WriteLine($"O ataque causou: {mago.Attack()}");

Console.WriteLine("Insira o nome do personagem: ");
string nome2 = Console.ReadLine();
Console.WriteLine("Insira a mana do personagem: ");
int mana2 = int.Parse(Console.ReadLine());
Console.WriteLine("Insira a vida do personagem: ");
int vida2 = int.Parse(Console.ReadLine());
Console.WriteLine("Insira o XP do personagem: ");
float xp2 = float.Parse(Console.ReadLine());
Console.WriteLine("Insira a inteligencia do personagem: ");
int inteligencia2 = int.Parse(Console.ReadLine());
Console.WriteLine("Insira a força do personagem: ");
int forca2 = int.Parse(Console.ReadLine());
Console.WriteLine("Insira o level do personagem: ");
int level2 = int.Parse(Console.ReadLine());
Console.WriteLine("Informe o nome da habilidade inicial: ");
string habilidades = Console.ReadLine();
List<string> habilidade = new List<string>();
habilidade.Add(habilidades);

Guerreiro guerreiro = new Guerreiro(nome2, mana2, vida2, xp2, inteligencia2, forca2, level2, habilidade);

Console.WriteLine($"Nome: {guerreiro.Nome}, Mana: {guerreiro.Mana}, Vida: {guerreiro.Vida}, Xp: {guerreiro.Xp}, Inteligencia: {guerreiro.Inteligencia}, Força: {guerreiro.Forca}, " +
    $"Level: {guerreiro.Level}");

Console.WriteLine("Habilidades: ", guerreiro.Habilidades);
for (int i = 0; i < guerreiro.Habilidades.Count; i++)
{
    Console.WriteLine(guerreiro.Habilidades[i]);
}
guerreiro.LvlUp();
Console.WriteLine("Parabens você ganhou um level: ");
Console.WriteLine(guerreiro.Level);
Console.WriteLine("Parabens você aprendeu uma nova habilidade");
guerreiro.AprenderHabilidade("Lamina cortante");
Console.WriteLine("Lista de habilidades: ");
for (int i = 0; i < guerreiro.Habilidades.Count; i++)
{
    Console.WriteLine(guerreiro.Habilidades[i]);
}

Console.WriteLine("O guerreiro atacou");
Console.WriteLine($"O ataque causou: {guerreiro.Attack()}");