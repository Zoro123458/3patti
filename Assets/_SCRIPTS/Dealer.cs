using UnityEngine;

public class Dealer : MonoBehaviour
{
    private int[] generatedNumbers = new int[9];
    private const int minNumber = 0;
    private const int maxNumber = 51;

    private int firstRandomNumber;
    private int secondRandomNumber;
    private int thirdRandomNumber;
    private int fourthRandomNumber;
    private int fifthRandomNumber;
    private int sixthRandomNumber;
    private int seventhRandomNumber;
    private int eighthRandomNumber;
    private int ninthRandomNumber;



    public NumberToImageAssigner player_1;
    public NumberToImageAssigner player_2;
    public NumberToImageAssigner player_3;
    // Start is called before the first frame update
    void Start()
    {
        GenerateUniqueRandomNumbers();
        DealCard(player_1);
        DealCard2(player_2);
        DealCard3(player_3);
    }
    public void DealCard(NumberToImageAssigner player)
    {
        player.DealCard(firstRandomNumber, 1);
        player.DealCard(secondRandomNumber, 2);
        player.DealCard(thirdRandomNumber, 3);
    }
    public void DealCard2(NumberToImageAssigner player)
    {
        player.DealCard(fourthRandomNumber, 1);
        player.DealCard(fifthRandomNumber, 2);
        player.DealCard(sixthRandomNumber, 3);
    }
    public void DealCard3(NumberToImageAssigner player)
    {
        player.DealCard(seventhRandomNumber, 1);
        player.DealCard(eighthRandomNumber, 2);
        player.DealCard(ninthRandomNumber, 3);
    }
    void GenerateUniqueRandomNumbers()
    {
        for (int i = 0; i < 9; i++)
        {
            int randomNumber = GenerateUniqueRandomNumber();

            // Store the generated number in separate variables
            switch (i)
            {
                case 0:
                    firstRandomNumber = randomNumber;
                    break;
                case 1:
                    secondRandomNumber = randomNumber;
                    break;
                case 2:
                    thirdRandomNumber = randomNumber;
                    break;
                case 3:
                    fourthRandomNumber = randomNumber;
                    break;
                case 4:
                    fifthRandomNumber = randomNumber;
                    break;
                case 5:
                    sixthRandomNumber = randomNumber;
                    break;
                case 6:
                    seventhRandomNumber = randomNumber;
                    break;
                case 7:
                    eighthRandomNumber = randomNumber;
                    break;
                case 8:
                    ninthRandomNumber = randomNumber;
                    break;
            }

            Debug.Log($"Generated Number {i + 1}: {randomNumber}");
        }

        // Now you can use firstRandomNumber, secondRandomNumber, ..., ninthRandomNumber in your script.
    }

    int GenerateUniqueRandomNumber()
    {
        int randomNumber;

        do
        {
            // Generate a random number between minNumber and maxNumber (inclusive)
            randomNumber = Random.Range(minNumber, maxNumber + 1);
        } while (ArrayContains(generatedNumbers, randomNumber));

        // Store the generated number to check for uniqueness next time
        StoreGeneratedNumber(randomNumber);

        return randomNumber;
    }

    void StoreGeneratedNumber(int number)
    {
        // Store the generated number in the array
        for (int i = 0; i < generatedNumbers.Length; i++)
        {
            if (generatedNumbers[i] == 0)
            {
                generatedNumbers[i] = number;
                break;
            }
        }
    }

    bool ArrayContains(int[] array, int value)
    {
        // Check if the array contains the given value
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == value)
            {
                return true;
            }
        }
        return false;
    }
}
