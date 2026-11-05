int key;
string frase, messaggio = "";
Console.WriteLine("Inserire la chiave:");
key = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Inserire la frase:");
frase = Console.ReadLine();

for (int i = 0; i <= (frase.Length); i++ )
{
    char lettera = frase[i];
    if (lettera != ' ' && lettera != '.' && lettera != ',')
    {
        int codAscii = (int)lettera + key;
        char lettera2 = (char)codAscii;
        messaggio = messaggio + lettera2;
    }
    else
    {
        messaggio = messaggio + lettera;
    }
    Console.WriteLine(messaggio);
}