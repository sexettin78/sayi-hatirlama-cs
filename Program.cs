Console.WriteLine("Sayısal Hafıza Oyunu");
Console.WriteLine("Oyuna başlamak için ENTER tuşuna basın...");
Console.ReadLine();
Console.Clear();
Console.WriteLine("Oyun Başlıyor...");

int sayiAdeti = 4; 
int[] sayilar = new int[sayiAdeti];
Random random = new Random();

for (int i = 0; i < sayiAdeti; i++)
{
    sayilar[i] = random.Next(1, 100); 
    Console.Write(sayilar[i] + " ");
    Thread.Sleep(1000);
    Console.Clear();
    Console.Write("   ");
    Thread.Sleep(1000);
}

Console.Clear();
Console.WriteLine("Şimdi sayıları yazın!");
Thread.Sleep(1000); 

int dogruSayilar = 0;
for (int i = 0; i < sayiAdeti; i++)
{
    Console.Write("Sayı {0}: ", i + 1);
    int tahmin = Convert.ToInt32(Console.ReadLine());
    if (tahmin == sayilar[i])
    {
        dogruSayilar++;
    }
   
}

Console.WriteLine("Oyun Bitti!");
Console.WriteLine("Doğru Sayılar: " + dogruSayilar + " / " + sayiAdeti);
