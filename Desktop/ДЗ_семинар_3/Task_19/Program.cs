//Вариант 1
int Reading(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}
bool Paltest(int num)
{
    bool res = false;
    if ((num/10000==num%10) && ((num/1000)%10) == ((num/10)%10))
    {
        res = true;
    }
    return res;
}
int k = Reading("Введите число: ");
Console.WriteLine(Paltest(k));
//Вариант 2
Dictionary <int, bool> palindroms = new Dictionary<int, bool>();
palindroms.Add(1001, true);  
palindroms.Add(1221, true);
palindroms.Add(1331, true);
palindroms.Add(1441, true);
palindroms.Add(1551, true);
palindroms.Add(1661, true);
palindroms.Add(1771, true);
palindroms.Add(1881, true);
palindroms.Add(1991, true);
palindroms.Add(2002, true);
palindroms.Add(2112, true);
palindroms.Add(2222, true);
palindroms.Add(2332, true);
palindroms.Add(2442, true);
palindroms.Add(2552, true);
palindroms.Add(2662, true);
palindroms.Add(2772, true);
palindroms.Add(2882, true);
palindroms.Add(2992, true);
palindroms.Add(3003, true);
palindroms.Add(3113, true);
palindroms.Add(3223, true);
palindroms.Add(3333, true);
palindroms.Add(3443, true);
palindroms.Add(3553, true);
palindroms.Add(3663, true);
palindroms.Add(3773, true);
palindroms.Add(3883, true);
palindroms.Add(3993, true);
palindroms.Add(4004, true);
palindroms.Add(4114, true);
palindroms.Add(4224, true);
palindroms.Add(4334, true);
palindroms.Add(4444, true);
palindroms.Add(4554, true);
palindroms.Add(4664, true);
palindroms.Add(4774, true);
palindroms.Add(4884, true);
palindroms.Add(4994, true);
palindroms.Add(5005, true);
palindroms.Add(5115, true);
palindroms.Add(5225, true);
palindroms.Add(5335, true);
palindroms.Add(5445, true);
palindroms.Add(5555, true);
palindroms.Add(5665, true);
palindroms.Add(5775, true);
palindroms.Add(5885, true);
palindroms.Add(5995, true);
palindroms.Add(6006, true);
palindroms.Add(6116, true);
palindroms.Add(6226, true);
palindroms.Add(6336, true);
palindroms.Add(6446, true);
palindroms.Add(6556, true);
palindroms.Add(6666, true);
palindroms.Add(6776, true);
palindroms.Add(6886, true);
palindroms.Add(6996, true);
palindroms.Add(7007, true);
palindroms.Add(7117, true);
palindroms.Add(7227, true);
palindroms.Add(7337, true);
palindroms.Add(7447, true);
palindroms.Add(7557, true);
palindroms.Add(7667, true);
palindroms.Add(7777, true);
palindroms.Add(7887, true);
palindroms.Add(7997, true);
palindroms.Add(8008, true);
palindroms.Add(8118, true);
palindroms.Add(8228, true);
palindroms.Add(8338, true);
palindroms.Add(8448, true);
palindroms.Add(8558, true);
palindroms.Add(8668, true);
palindroms.Add(8778, true);
palindroms.Add(8888, true);
palindroms.Add(8998, true);
palindroms.Add(9009, true);
palindroms.Add(9119, true);
palindroms.Add(9229, true);
palindroms.Add(9339, true);
palindroms.Add(9449, true);
palindroms.Add(9559, true);
palindroms.Add(9669, true);
palindroms.Add(9779, true);
palindroms.Add(9889, true);
palindroms.Add(9999, true);
int ReadLine(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine() ?? "0");
}
int Process(int k)
{
    k = int.Parse(k.ToString().Remove(2, 1));
    return k;
    
}

int s = ReadLine("Давай число: ");
int l = Process(s);

if (palindroms.ContainsKey(l))
{
    Console.WriteLine(palindroms[l]);

}
else
{
    Console.WriteLine("false");
}
