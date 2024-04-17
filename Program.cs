// 1. Tub Son.

using System;

class Program
{
    // Funksiya, berilgan sonni tub sonmi yoki emasmi aniqlaydi
    static bool TubSonmi(int n)
    {
        if (n <= 1)
            return false;
        
        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
                return false;
        }
        
        return true;
    }

    static void Main(string[] args)
    {
        // Sonni foydalanuvchidan olish
        Console.Write("Istalgan sonni kiriting: ");
        int son = Convert.ToInt32(Console.ReadLine());

        // Sonni tekshirish
        if (TubSonmi(son))
        {
            Console.WriteLine(son + " - tub son.");
        }
        else
        {
            Console.WriteLine(son + " - tub bolmagan son.");
        }
    }
}


// 2. Bo'luvchisiz sonlar.
using System;

class Program
{
    static void Main()
    {
        // Foydalaniuvchan son olish.
        System.Console.Write("Istalgan sonni kiriting:");
        int son = Convert.ToInt32(Console.ReadLine());

        // 2 dan 10 gacha bo'lgan bo'luvchilarini aniqlash va natijani ekranga chiqarish 
        for (int i =2; i<= 10; i++)
            if (son % i ==0)

            {
                System.Console.WriteLine(i);
            }
    }
}


// 3. Daraja hisoblash.
using System;
class Program
{
    static void Main()
    {
        System.Console.Write("Sonni kiriting:");
        int son = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Darajani kiriting:");
        int daraja = Convert.ToInt32(Console.ReadLine());

        int natija = 1 ;
        for (int i=1; i<= daraja; i++)
        {
            natija *= son;
        }
        
        System.Console.WriteLine($"Natija: {son}^{daraja}={natija}");
    }
}



// 4. Harajatlar to'plamini hisoblash

using System;

class Program
{
    static void Main(string[] args)
    {
        // Foydalanuvchidan to'plam miqdorlarni olish
        Console.WriteLine("Qancha to'plam miqdor kiritmoqchisiz?");
        int n = Convert.ToInt32(Console.ReadLine());

        // To'plam miqdorlarni saqlash uchun massiv yaratish
        int[] toplamlar = new int[n];

        // Foydalanuvchidan miqdorlarni kiritish
        for (int i = 0; i < n; i++)
        {
            Console.Write("To'plam miqdorni kiriting: ");
            toplamlar[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Miqdorlarni qo'shib yig'indisini hisoblash
        int jami = 0;
        for (int i = 0; i < n; i++)
        {
            jami += toplamlar[i];
        }

        // Natijani ekranga chiqarish
        Console.WriteLine("Qo'shib yig'indisi: " + jami);
    }
}


// 5.Armstrong sonlar:

using System;

class Program
{
    // Funksiya, berilgan sonni Armstrong son ekanligini tekshiradi
    static bool ArmstrongSon(int n)
    {
        int originalNumber = n;
        int length = n.ToString().Length;
        int sum = 0;

        while (n > 0)
        {
            int digit = n % 10;
            sum += (int)Math.Pow(digit, length);
            n /= 10;
        }

        return sum == originalNumber;
    }

    static void Main(string[] args)
    {
        // Foydalanuvchidan sonni olish
        Console.Write("Sonni kiriting: ");
        int son = Convert.ToInt32(Console.ReadLine());

        // Sonni Armstrong son ekanligini tekshirish
        if (ArmstrongSon(son))
        {
            Console.WriteLine(son + " Armstrong son.");
        }
        else
        {
            Console.WriteLine(son + " Armstrong son emas.");
        }
    }
}
