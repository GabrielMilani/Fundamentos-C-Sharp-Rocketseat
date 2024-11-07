Console.WriteLine("Verifique se sua placa esta no padrão brasileiro de 2018!");
Console.WriteLine("Digite uma placa:");
string plate = Console.ReadLine();

bool result = true;

if (plate.Length != 7)
{
    result = false;
}

string word = plate.Substring(0, 3);
if (!word.All(char.IsLetter))
{
    result = false;
}


string num = plate.Substring(3, 4);
if (!num.All(char.IsDigit))
{
    result = false;
}


if (result == true)
{
    Console.WriteLine("Placa Valida");
}
else
{
    Console.WriteLine("Placa Invalida");
}