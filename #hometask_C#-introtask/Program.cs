// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


    int[] numbers = { 224, 334, 1000, 1002, 23211, 23122, 100000 };
    int sum3 = 0;

foreach (var num in numbers )
{
    if (num > 99 && num < 1000) 
    sum3+= num;

}
int sum4 = 1;
foreach ( var num in numbers )
{
    if(num >999&&num < 10000)
    { sum4 *= num; }


}
int sum5 = 0;
if (sum5 > 0)
 sum5=sum3+sum4;


Console.WriteLine(sum5);