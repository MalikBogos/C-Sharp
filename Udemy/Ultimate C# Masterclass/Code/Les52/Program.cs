char[,] letters = new char[2, 3];

letters[0, 0] = 'A';
letters[0, 1] = 'B';
letters[0, 2] = 'C';
letters[1, 0] = 'D';
letters[1, 1] = 'E';
letters[1, 2] = 'F';

var height = letters.GetLength(0);
var width = letters.GetLength(1);
Console.WriteLine("Height is:" + height);
Console.WriteLine("Width is:" + width);

for(int i =  0; i < height; i++)
{
    Console.WriteLine("i is: " + i);

    for(int j = 0; j< width; j++)
    {
        Console.WriteLine("j is: " + j);
        Console.WriteLine("Element is: " + letters[i, j]);
    }
}



char[,] letters2 = new char[2, 3]
{
    { 'A', 'B', 'C'},
    { 'D', 'E', 'F' }
};



Console.ReadKey();
