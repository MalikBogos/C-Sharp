for(var i = 0; i < 20; i++)
{
    if (i % 3 == 0)
    {
        continue;
    }
    Console.WriteLine("I is :" + i);
}

Console.WriteLine("The loop is finished");
Console.ReadKey();