string frase; //la frase da criptare e poi decrifrare che l'utente deve inserire
int key; //la chiave di criptazione e decriptazione che l'utente deve inserire
Console.WriteLine("Inserire la frase:");
frase = Console.ReadLine();
Console.WriteLine("Inserire la chiave:");
key = Convert.ToInt16(Console.ReadLine());

for(int i = 0; i < 2; i++) //il primo giro è per la criptazione il secondo è per la decriptazione
{
    string messaggio = ""; //messaggio criptato o decriptato da dire in output
    for (int j = 0; j < (frase.Length); j++) //ciclo che va da 0 alla lunghezza della frase per scorrere nella stringa
    {
        int codAscii = (int)frase[j]; //converte il carattere corrente nel suo numero ascii
        if ((codAscii >= 65 && codAscii <= 90) || (codAscii >= 97 && codAscii <= 122)) //lo fa solo se l'ascii del carattere ha l'ascii da A a Z o da a a z
        {
            for (int k = 0; k < key; k++) //ciclo che va da 0 alla chiave per sommarla all'ascii del carattere
            {
                if ((codAscii + 1 > 90 && codAscii + 1 < 97) || codAscii + 1 > 122) //se l'ascii del carattere sfora Z/z gli tolglie 25 per tornare ad A/a sennò aumenta di 1
                {
                    codAscii = codAscii - 25;
                }
                else
                {
                    codAscii++;
                }
            }
        }
        messaggio = messaggio + (char)codAscii; //ritrasforma il codice ascii in carattere e lo somma al messaggio
    }

    if (i == 0)
    {
        Console.WriteLine($"La frase criptata è {messaggio}");
    }
    else
    {
        Console.WriteLine($"La frase decriptata è {messaggio}");
    }

    key = 26 - key; //per decriptare al secondo giro
    frase = messaggio;
}
