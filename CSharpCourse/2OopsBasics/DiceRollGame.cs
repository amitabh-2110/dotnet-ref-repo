namespace CSharpCourse._2OopsBasics;

/**
1. Get the detailed complete requirements.
2. Analyse the requirements.
3. Identity the entities.
4. Identity the responsibilities.
5. Decide the flow.
*/

public class DiceRollGameDriver
{
    public static void DiceRollGameDriverMethod()
    {
        var randomNumber = Dice.RollDice();
        var diceGame = new DiceGame(randomNumber);
        Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");
        while(!diceGame.IsNumberOfAttemptsExhausted())
        {
            var userNumber = ValidateInput.GetUserResponseAndValidate();
            var isMatchedWithRandomNumber = diceGame.CompareWithRandomNumber(userNumber);
            if(isMatchedWithRandomNumber)
            {
                break;
            }
        }
        Console.ReadKey();
    }
}

public static class Dice
{
    public const int _numberOfFaces = 6;

    public static int RollDice()
    {
        var random = new Random();
        int randomNumber = random.Next(1, _numberOfFaces + 1); // here to avoid magic number 7, we created a field _numberOfFaces
        return randomNumber;
    }
}

public class DiceGame
{
    private const int _numberOfTrials = 3;
    private readonly int _randomNumber;
    public int NumberOfAttempts { get; private set; }

    public DiceGame(int randomNumber)
    {
        _randomNumber = randomNumber;
    }

    public bool CompareWithRandomNumber(int userNumber)
    {
        if(userNumber != _randomNumber)
        {
            Console.WriteLine("Wrong number");
            NumberOfAttempts ++;
            return false;
        }
        Console.WriteLine("You win");
        return true;
    }

    public bool IsNumberOfAttemptsExhausted()
    {
        if(NumberOfAttempts == _numberOfTrials)
        {
            Console.WriteLine("You lose");
            return true;
        }
        return false;
    }
}

public static class ValidateInput
{
    public static int GetUserResponseAndValidate()
    {
        int result;
        while(!int.TryParse(Console.ReadLine(), out result) || result < 1 || result > Dice._numberOfFaces)
        {
            Console.WriteLine("Invalid input");
        }
        return result;
    }
}
