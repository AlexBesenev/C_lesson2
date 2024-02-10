double[] arr = {120, 101, 301, 85, 30, 101, 55, 41, 63, 65 };
int i = 0;
while (i < arr.Length)
{
    if (arr[i] % 2 == 0)
    {
        System.Console.Write($"{arr[i]} "); // $"{}" для того чтобы вывел массив а не текст
    }
    i = i + 1;

}
// double a = 101;
// System.Console.WriteLine(a%2);