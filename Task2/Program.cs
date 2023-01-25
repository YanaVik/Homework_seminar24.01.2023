// Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
string num = Console.ReadLine();
int len = num.Length;
int[] nums = new int[len];
int sum = 0;
int count = 0;

while (count < len)
{
    nums[count] = Convert.ToInt32(num[count].ToString());
    count++;
}

for (int i = 0; i < len; i++)
    sum += nums[i];

Console.WriteLine("Сумма цифр в данном чисде: " + sum);