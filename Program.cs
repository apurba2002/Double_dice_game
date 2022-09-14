
while (true)
{
    Console.WriteLine("Enter the first player name :");
    string player1 = Console.ReadLine();
    Console.WriteLine("Enter the second player name :");
    string player2 = Console.ReadLine();
    Random rd = new Random();
    int p1d1 = rd.Next(0,7);
    int p2d1 = rd.Next(0,7);
    if (p1d1 > p2d1 )
    {
        Console.WriteLine("The winner is :");
        Console.WriteLine(player1);
        continue;
    }
    if ( p2d1 > p1d1)
    {
        Console.WriteLine("The winner is :");
        Console.WriteLine(player2);
        continue;
    }
    else
    {
        Console.WriteLine("Match draw");
        continue;
    }
}
