using System.Security.Cryptography;

const int DezenasPorJogada = 6;
const int MaxValorSorteio = 60;

Console.WriteLine("--- Surpresinha ---\n");

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write("Quantas jogadas? ");
Console.ResetColor();
Console.ForegroundColor = ConsoleColor.DarkYellow;
int numeroJogadas = Convert.ToInt32(Console.ReadLine());

int[][] jogadas = new int[numeroJogadas][];
Console.ResetColor();
for (int jogadaAtual = 0; jogadaAtual < numeroJogadas; jogadaAtual++)
{
    int[] dezenasJogadaAtual = new int[DezenasPorJogada];

    int dezenaAtual = 0;
    while (dezenaAtual < DezenasPorJogada)
    {
            int dezenaSorteada = RandomNumberGenerator.GetInt32(1, MaxValorSorteio + 1);
        dezenasJogadaAtual[dezenaAtual] = dezenaSorteada;

        bool dezenaRepetida = false;
        for (int dezenaAnterior = 0; dezenaAnterior < dezenaAtual; dezenaAnterior++)
        {
            if (dezenasJogadaAtual[dezenaAnterior] == dezenaSorteada)
            {
                dezenaRepetida = true;
                break;
            }
        }
       if (dezenaRepetida) continue;
            dezenaAtual++;
        }
        Array.Sort(dezenasJogadaAtual);
    jogadas[jogadaAtual] = dezenasJogadaAtual;
}
for (int jogada = 0; jogada < numeroJogadas; jogada++)
{
    for (int dezena = 0; dezena < DezenasPorJogada; dezena++)
    {
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write($"{jogadas[jogada][dezena].ToString("D2")}");
        if (dezena < 5) Console.Write($" - ");
    }
        Console.WriteLine();
        Console.ResetColor();
}
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Write("Boa Sorte!....");
Console.ResetColor();
