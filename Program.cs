// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Gamers!");


//Coin Flip

static int CoinFlip()
{
    Random rand = new Random();
    int result = rand.Next(0, 2);
        if (result == 1)
        {
            Console.WriteLine("Heads");
        }
        else if (result == 0)
        {
            Console.WriteLine("Tails");
        }
        return result;
    }
int flipResult = CoinFlip();



// //Dice

static int DiceRoll()
{
    Random rand = new Random();
    int dieOne = rand.Next(1, 7);
    int dieTwo = rand.Next(1, 7);

    int result = dieOne + dieTwo;

    Console.WriteLine("You rolled " + dieOne + " and a " + dieTwo + " the total is " + result);
    return result;
}
int dieResult = DiceRoll();





//Stat roll

static int StatRoll()
{
    int result = 0; 
    for (int i = 1; i < 5; i++)
    {
        
        Random rand = new Random();
        int dieOne = rand.Next(1, 7);
        
        result = dieOne + result;
        Console.WriteLine("you rolled a "+dieOne+ " on roll "+i+".. your total is "+result+"!");
        
    }
    return result;
}
int statResult = StatRoll();



//Roll Until

static int DiceRolls(int sides)
{
    Random rand = new Random();
    return rand.Next(1, sides + 1);
}

static string RollUntil(int number, int sides)
{
    if(number > sides)
    {
        return "Please choose another number";
    }
    int count = 0;
    int result = DiceRolls(sides);
    while(result != number)
    {
        count++;
        result = DiceRolls(sides);
    }
    return $"Rolled a {number} after {count} tries";
}

Console.WriteLine(RollUntil(12, 20));