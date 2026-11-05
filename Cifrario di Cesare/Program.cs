string frase;
int key;
Console.WriteLine("Inserire la frase:");
frase = Console.ReadLine();
Console.WriteLine("Inserire la chiave:");
key = Convert.ToInt16(Console.ReadLine());

for(int i = 0; i < 2; i++)
{
    string messaggio = "";
    for (int j = 0; j < (frase.Length); j++)
    {
        int codAscii = (int)frase[j];
        if ((codAscii >= 65 && codAscii <= 90) || (codAscii >= 97 && codAscii <= 122))
        {
            for (int k = 0; k < key; k++)
            {
                if ((codAscii + 1 > 90 && codAscii + 1 < 97) || codAscii + 1 > 122)
                {
                    codAscii = codAscii - 25;
                }
                else
                {
                    codAscii++;
                }
            }
        }
        messaggio = messaggio + (char)codAscii;
    }

    if (i == 0)
    {
        Console.WriteLine($"La frase criptata è {messaggio}");
    }
    else
    {
        Console.WriteLine($"La frase decriptata è {messaggio}");
    }

    key = 26 - key;
    frase = messaggio;
}
