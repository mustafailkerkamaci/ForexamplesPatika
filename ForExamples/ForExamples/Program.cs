//KONSOL EKRANINA 10 KERE METIN YAZDIRMAK.
for (int i = 0; i <10; i++) // i dergerini tanimladik ve 10 kere calisacagi icin i<10 dedik. Daha sonra i yi 1er 1er  arttirdik.
{
    Console.WriteLine("Kendime guveniyorum, ben bu yazilim isini hallederim.");
}


//1 ilek 20 arasindaki sayilari konsol ekranin yazdirmak .
for ( int i=1; i<=20; i++) // 1 ile 20 arasinda oldugu icin i degerine 1 tanimladik ve 20 arasindaki sayilari istedigi  icin i<20 dedik. Daha sonra i yi 1er 1er  arttirdik.
{
    Console.WriteLine(i);
}


//1 ile 20 arasindaki cift sayilari konsol ekranina yazdirmak.
for (int i = 0; i < 20; i += 2) // 1 ile 20 arasinda oldugu icin i degerine 0 tanimladik ve 1 ile 20 arasindaki cift degerleri istedigi  icin i<20 dedik. Daha sonra cift sayilari gorebilmek icin 2 ser olarak arttirdik.
{
    Console.WriteLine(i);
}

// 50 ile 150 arasindaki sayilarin toplamaini yazdirmak. 

int sum = 0; // sum degiskenini tanimladik ve 0 degerini atadik. Cunku hicbir sayi toplanmadi

for(int i =50; i <= 150; i++) // 50 ile 150 arasinda oldugu icin i degerine 50 tanimladik ve 50 ile 150 arasindaki sayilari istedigi  icin i<=150 dedik. Daha sonra i yi 1er 1er  arttirdik.
{
    sum += i; // her dongu sonunda i degiskeninin degeri toplam degiskenine eklenir.
}
Console.WriteLine($"50 ile 150 arasindaki sayilarin toplami: {sum}");

//1 ile 120 arasindaki tek ve cift sayilarinin toplamlarini ayri ayri yazdirmak.

int singleSum = 0;
int doubleSum = 0; // Tek ve cift sayilarin toplamlarini ayri ayri tutmak icin degisken atadik.

for(int i=1; i<=120; i++) // Dongu 1 den baslar ve 1er 1er artarak 120 ye kadar devam eder.
{
    if (i % 2 == 0)  // i degiskeni  ye tam bolunuyorsa kalan 0 ise bu bir cift sayidir.
    {
        doubleSum += i; // sayi cift ise doublesum degiskenin eklenir.
    }
    else // Eger sayi cift degilse tek sayidir
    {
        singleSum += i; // sayi singlesum degiskenine atanir.
    }
}
Console.WriteLine($"Tek sayilarin toplami: {singleSum}");
Console.WriteLine($"Cift sayilarin toplami: {doubleSum}");