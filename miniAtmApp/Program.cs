// Mini ATM application

int bakiye = 1000;


Console.WriteLine("      Welcome to YILMAZ BANK     ");
Console.WriteLine();
Console.WriteLine("********************************");
Console.WriteLine();
Console.WriteLine("Lütfen yapacağınız işlemi seçiniz.");
Console.WriteLine();
Console.WriteLine("1) Bakiye görüntüleme.");
Console.WriteLine();
Console.WriteLine("2) Para yatırma. ");
Console.WriteLine();
Console.WriteLine("3) Para çekme. ");
Console.WriteLine();

int i = Convert.ToInt32(Console.ReadLine());
if (i == 1)
{
    Console.WriteLine("BAKİYENİZ : " + bakiye + "$");
}
if (i == 2)
{
    Console.WriteLine("Lütfen yatırmak istediğiniz tutarı giriniz");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Yeni bakiyeniz " + (bakiye + x) + "$");
}
if (i == 3)
{
    Console.WriteLine("Lütfen çekmek istediğiniz tutarı giriniz");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Yeni bakiyeniz :" + (bakiye + y) + "$");
}
else
{
    Console.WriteLine("Yaptığınız giriş geçersizdir lütfen tekrar deneyiniz");

}
