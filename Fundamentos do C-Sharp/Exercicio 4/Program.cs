Console.WriteLine("Digite uma frase:");
string phrase = Console.ReadLine();

string[] words = phrase.Split(' ');

foreach (string word in words)
{
    Console.WriteLine($"A palavra {word} tem {word.Length} caracteres");
}
    

