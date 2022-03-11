using Ex7;

Console.WriteLine("Insira o nome do funcionario: ");
string nome = (Console.ReadLine());
Console.WriteLine("Insira a idade do funcionario: ");
int idade = int.Parse(Console.ReadLine());
Console.WriteLine("Insira o salario do funcionario: ");
float salario = float.Parse(Console.ReadLine());

Funcionario funcionario = new Funcionario(nome, idade, salario);

Console.WriteLine($"Nome: {funcionario.Nome}, Idade: {funcionario.Idade}, Salario: {funcionario.Salario}");

Console.WriteLine("Insira o nome do gerente: ");
string nome2 = (Console.ReadLine());
Console.WriteLine("Insira a idade do gerente: ");
int idade2 = int.Parse(Console.ReadLine());
Console.WriteLine("Insira o salario do gerente: ");
float salario2 = float.Parse(Console.ReadLine());

Gerente gerente = new Gerente(nome2, idade2, salario2);

Console.WriteLine($"Nome: {gerente.Nome}, Idade: {gerente.Idade}, Salario: {gerente.Salario}, Bonificação de salario: {gerente.Bonificacao()}");

Console.WriteLine("Insira o nome do supervisor: ");
string nome3 = (Console.ReadLine());
Console.WriteLine("Insira a idade do supervisor: ");
int idade3 = int.Parse(Console.ReadLine());
Console.WriteLine("Insira o salario do supervisor: ");
float salario3 = float.Parse(Console.ReadLine());

Supervisor supervisor = new Supervisor(nome3, idade3, salario3);

Console.WriteLine($"Nome: {supervisor.Nome}, Idade: {supervisor.Idade}, Salario: {supervisor.Salario}, Bonificação de salario: {supervisor.Bonificacao()}");

Console.WriteLine("Insira o nome do vendedor: ");
string nome4 = (Console.ReadLine());
Console.WriteLine("Insira a idade do vendedor: ");
int idade4 = int.Parse(Console.ReadLine());
Console.WriteLine("Insira o salario do vendedor: ");
float salario4 = float.Parse(Console.ReadLine());

Vendedor vendedor = new Vendedor(nome4, idade4, salario4);

Console.WriteLine($"Nome: {vendedor.Nome}, Idade: {vendedor.Idade}, Salario: {vendedor.Salario}, Bonificação de salario: {vendedor.Bonificacao()}");