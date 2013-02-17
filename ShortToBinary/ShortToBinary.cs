using System;
/*I use the same logic as in DecimalToBinary, only the bit's representation is for short*/
class ShortToBinary
{
    static void Main()
    {
        Console.Write("Enter a number of type short (from -32768 to 32767): ");
        short number = short.Parse(Console.ReadLine());
        Console.WriteLine(DecToBin(number));
    }
    static string DecToBin(short number) //this algorithm is based on the size of an integer, which has 15 bits(including 0)
    {
        char[] bit = new char[16];
        short pos = 15;
        short i = 0;

        while (i < 16)
        {
            if ((number & (1 << i)) != 0) //go to each position and check with this bitwise operation if the value is 0 or 1
            {
                bit[pos] = '1';
            }
            else
            {
                bit[pos] = '0';
            }
            pos--;
            i++;
        }
        return new string(bit);
    }
}