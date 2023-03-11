int Reading(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}

string Procession(int N, int num)
{
    string geosuper = String.Empty;
    for (int i= 1; i<=N; i++)
    {
        geosuper = geosuper + Math.Pow(i, num) + " ";
    }
    return geosuper;
}   
int k = Reading("Вводи чиселку: ");
Console.WriteLine(Procession(k, 1));
Console.WriteLine(Procession(k, 3));
// Вариант 2
int topnum = Reading("А введи-ка еше раз число, попробуем решить по другому");
int h = 1;
int cubic = 0;
int numDigitsCube = 0;
string firstStr = "\u2551 Число:    \u2551";
string secStr = "\u2551 Куб числа:\u2551";
while(h<topnum)
{
    cubic = (int)Math.Pow(h, 3);
    numDigitsCube = (int)Math.Log10(cubic) + 1;// вычисляем количество цифр в числе через логарифм
    firstStr = firstStr+((h).ToString()).PadRight(numDigitsCube)+ "\u2551";
    secStr = secStr + cubic.ToString() + "\u2551";
    h++;
}
DrawUniLine(firstStr, "\u2554", "\u2556", "\u2557");
Console.WriteLine(firstStr);
DrawUniLine(firstStr, "\u2560", "\u256C", "\u2563");
Console.WriteLine(secStr);
DrawUniLine(firstStr, "\u255A", "\u2569", "\u255D");

void DrawUniLine(string Samplestr, string startSym, string midSym, string stopSym)
{
    Console.Write(startSym); //рисуем левый верхний угол таблицы
    int r = 1;
    while(r<Samplestr.Length-1)
    {
        if (Samplestr[r] == '\u2551') Console.Write(midSym);
        else Console.Write("\u2550");
        r++;
    }
    Console.WriteLine(stopSym);

}


