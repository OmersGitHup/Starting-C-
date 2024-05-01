// See https://aka.ms/new-console-template for more information
using CalculatorwithClassMethod;

Console.WriteLine("Hello, World!");

Console.WriteLine("Yapmak İstediğiniz İşlemin Sembolünü Yazınız");
string key=Console.ReadLine();
calculator cal = new calculator();
int x, y;
Console.WriteLine("Birinci Sayıyı Giriniz");
x=Convert.ToInt16(Console.ReadLine());
Console.WriteLine("İkinci Sayıyı Giriniz");
y=Convert.ToInt16(Console.ReadLine());

if (key == "+")
{
    cal.Sum(x,y);
}else if (key == "*")
{
    cal.time(x,y);
}else if(key == "/")
{
    cal.div(x,y);
}else if (key == "-"){
    cal.sub(x,y);

}
else
{
    Console.WriteLine("Yanlış Sembol ve ya Sayı Girdiniz");
}
