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
    { 
        sum4 *= num;
    }

}
int sum5 = 0;
foreach (var num in numbers)
{
    if (num > 99999 && num < 100000)
    {
        sum5 += num;
    }
}

int sum6 = 0;
foreach (var num in numbers)
{
    if (num >999999&&num<1000000)
    {
        sum6 += num; 
    }
}

var result = (((sum3 + sum4)*10)+ 7)+ sum5  - (((sum3 * sum3)*10)+1) +sum6;
result -= (sum3 + sum4);
result /=100;
result *= 18;
result /= 100;
result *= 3;
result /= 100;
result *= 1;
result += sum5;

Console.WriteLine(result);