using System.Runtime.InteropServices;

string[] words = {"гроб", "витамин", "чудо", "брюки", "костюм", "середина", "ввод", "услуга", "стадион", "образец", "правило", "замечание", "духи", "бабочка", "буря", "наука", "касса", "движение", "ванная", "целое"};

string word = "";
List <char> guessed = new List <char>();
string _guessed = "";
char guess = ' ';
int lives = 10;
Random rnd = new Random();
if(word == "")
{
    lives = 10;
    _guessed = "";
    guess = ' ';
    word = "";
    guessed.Clear();
    word = words[rnd.Next(words.Length)];
    for(int i = 0; i < word.Length; i++)
    {
        guessed[i] = '_';
    }
}
if (word != "")
{
    if(lives != 0)
    {
        for(int i = 0; i < word.Length; i++)
        {
            _guessed += guessed[i] + " ";
        }
        Console.WriteLine(guessed);
        Console.WriteLine($"Попыток осталось: {lives}");
        Console.Write("Угадайте букву: ");
        guess = Convert.ToChar(Console.Read());

        for(int i = 0; i < word.Length; i++)
        {
            if (guess == word[i])
            {
                guessed[i] = guess;
            }
        }
    }
    if (lives == 0)
    {   
    Console.WriteLine(word);
    lives = 10;
    word = "";
    }
}