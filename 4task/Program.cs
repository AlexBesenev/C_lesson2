/* Дано 10 гирь с разным весом в случ. порядке. Определить вес самой тяжелой гири.*/
int[] Giri = { 10, 5, 8, 10, 56, 9, 1, 2, 6, 44 };
int i = 0;
int max = Giri[0];

while (i < Giri.Length)
{
    if (Giri[i] > max)
    {
        max = Giri[i];
    }
    i = i + 1;
}
System.Console.WriteLine(max);

max = Giri[0];
for (int j = 0; j < Giri.Length; j++)
{
    if (Giri[j] > max)
    {
        max = Giri[j];
    }
}
System.Console.WriteLine(max);

max = Giri[0];
foreach (int e in Giri)
{
    if (e > max)
    {
        max = e;
    }  
}
System.Console.WriteLine(max);