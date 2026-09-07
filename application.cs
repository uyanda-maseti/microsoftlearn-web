// // SayHello();

// Console.WriteLine("Generating random numbers:");
// DisplayRandomNumbers();







// void DisplayRandomNumbers()
// {
//     Random random = new Random();
//     for (int i = 0; i < 5; i++)
//     {
//         Console.Write($"{random.Next(1, 100)} ");
//     }
//     Console.WriteLine();
// }

// void SayHello() 
// {
//     Console.WriteLine("Hello World!");
// }

Random random = new Random();

int i = 0;
int r = random.Next(pettingZoo.Length);

string temp = pettingZoo[i];
pettingZoo[i] = pettingZoo[r];
pettingZoo[r] = temp;

for (int i = 0; i < pettingZoo.Length; i++)
{
    int r = random.Next(pettingZoo.Length);

    string temp = pettingZoo[i];
    pettingZoo[i] = pettingZoo[r];
    pettingZoo[r] = temp;
}