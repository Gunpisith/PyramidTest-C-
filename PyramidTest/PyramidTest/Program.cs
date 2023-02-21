int Space, Number, NumPyramid, level;
string input;
while (true)
{
    try
    {
    Console.Write("Input Level Tree: ");
    input = Console.ReadLine();
    string[] temp = input.Split(",");
    NumPyramid = Convert.ToInt32(temp[0]);
    level = Convert.ToInt32(temp[1]);
    }
    catch (Exception)
    {
        Console.WriteLine("please enter number !");
        continue;
    }

    // all is good
    break;
}

for (int j = 1; j <= NumPyramid; j++)
{
    for (int i = 1; i <= level; i++) // Total number of layer for pramid  
    {
        for (Space = 1; Space <= (level - i); Space++) // Loop For Space  
            Console.Write(" ");
        for (Number = 1; Number <= i; Number++) //increase the value  
            Console.Write('*');
        for (Number = (i - 1); Number >= 1; Number--) //decrease the value  
            Console.Write('*');
        Console.WriteLine();
    }
}
