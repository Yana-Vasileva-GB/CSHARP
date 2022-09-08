Console.Write("Введите Ваше имя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша") 
// ToLower() - перевод символов в нижний регистр
{
    Console.WriteLine("Ура! Это же МАША!");
}
else
{
    Console.WriteLine($"Привет, {username}!");
}