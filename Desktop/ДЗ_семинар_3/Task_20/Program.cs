int Reading(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
void Printex(string msg, double col)
{
    Console.WriteLine(msg+col);
}
double Process(int x1, int x2, int y1, int y2, int z1, int z2)
{
    
    return Math.Round(Math.Sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2)+(z1-z2)*(z1-z2)), 2);
}
int x1 = Reading("Введите 1-ую координату x");
int y1 = Reading("Введите 1-ую координату y");
int z1 = Reading("Введите 1-ую координату z");
int x2 = Reading("Введите 2-ую координату x");
int y2= Reading("Введите 2-ую координату y");
int z2= Reading("Введите 2-ую координату z");
double rez = Process(x1, x2, y1, y2, z1, z2);
Printex("Результатик ", rez);