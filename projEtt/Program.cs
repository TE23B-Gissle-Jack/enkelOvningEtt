if(Console.ReadLine().ToLower() == "noname")
{
    if(Console.ReadLine().ToLower() == "nopass")
    {
        Console.WriteLine("welcome");
    }
    else Console.WriteLine("Wrong password");
}
else Console.WriteLine("Wrong username");

for(int i = 0; i<32;i++)
{
    Console.WriteLine("Hello World!");
}
for(int i = 0; i<5;i++)
{
    int siffra;
    bool ahhhh = int.TryParse(Console.ReadLine(), out siffra);
    if(ahhhh)
    {
        if(siffra > 5)Console.WriteLine("högre än 5!");
        else Console.WriteLine("lägre än 5!");
    }
    else Console.WriteLine("inte ett tal");
}
int ahahaha;
bool ha = int.TryParse(Console.ReadLine(), out ahahaha);
while(!ha)
{
    ha = int.TryParse(Console.ReadLine(), out ahahaha);
}

int tal = Random.Shared.Next(10);
int guess = -1;
while(guess!=tal)
{
    int.TryParse(Console.ReadLine(), out guess);
}
Console.WriteLine("Det är rätt! Svaret var "+ tal);
Console.ReadLine();