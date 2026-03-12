﻿using System.Runtime.InteropServices;

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
        guessed.Add('_');
    }
}
if (word != "")
{
    while(lives != 0)
    {
        bool f = false;
        bool ff = false;
        for(int i = 0; i < word.Length; i++)
        {
            _guessed += guessed[i] + " ";
        }
        Console.WriteLine(_guessed);
        Console.WriteLine($"Попыток осталось: {lives}");
        Console.Write("Угадайте букву: ");
        guess = Convert.ToChar(Console.ReadLine());

        for(int i = 0; i < word.Length; i++)
        {
            if (guess == word[i])
            {
                guessed[i] = guess;
                f = true;
            }
        }
        if (f == false)
        {
             lives--;
        }
        _guessed = "";
        Console.Clear();
        for(int i = 0; i < word.Length; i++)
        {
            if(guessed[i] == '_')
            {
                ff = true;
            }
        }
        if(ff == false)
        {
            Console.WriteLine($"Слово было отгадано: {word}");
            Console.ReadLine();
            Console.Clear();
            word = "";
            break;
        }
        

        if (lives == 0)
        {   
            Console.WriteLine($"Слово было: {word}");
            Console.ReadLine();
            Console.Clear();
            word = "";
            break;
        }
    }
    
}
