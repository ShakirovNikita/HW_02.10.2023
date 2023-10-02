int n = 2;
int count = 1;
int bufer = 1;


while (count < n+1)
{
    if (count%2==0)
    {
        bufer = count;
        Console.WriteLine(bufer);
    }
    count++;
}