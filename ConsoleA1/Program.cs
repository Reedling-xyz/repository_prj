string[] words = {"гроб", "витамин", "чудо", "брюки", "костюм", "середина", "ввод", "услуга", "стадион", "образец", "правило", "замечание", "духи", "бабочка", "буря", "наука", "касса", "движение", "ванная", "целое"};

string word = "";
List <char> guessed = new List <char>();
string _guessed = "";
char guess = ' ';
int lives = 10;
Random rnd = new Random();
if(word == "")
{
    
    word = words[rnd.Next(words.Length)];
    for(int i = 0; i < word.Length; i++)
    {
        guessed[i] = '_';
    }
    
}