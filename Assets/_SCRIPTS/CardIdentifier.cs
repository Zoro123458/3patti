using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CardIdentifier : MonoBehaviour
{
    public static void Main()
    {
        // Example usage:
        int cardIndex = 12; // Replace with the index of the card you want to identify
        IdentifyCard(cardIndex);
    }

    public static void IdentifyCard(int index)
    {
        if (index < 0 || index >= 52)
        {
            Console.WriteLine("Invalid card index. Should be between 0 and 51.");
            return;
        }

        // Determine suit and value
        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
        string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

        int suitIndex = index / 13;
        int valueIndex = index % 13;

        string suit = suits[suitIndex];
        string value = values[valueIndex];

        // Display the result
        Console.WriteLine($"Card at index {index}: {value} of {suit}");
    }
}
