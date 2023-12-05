using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberToImageAssigner : MonoBehaviour
{
    public Image image1;
    public Image image2;
    public Image image3;


    public int card_1_value;
    public int card_2_value;
    public int card_3_value;


    public Sprite[] allCards;

    public Sprite defaultcard;
    public int Total_Tokens;
    public Text displayTotalTokens, bidText;
    public int Bid_Amount;

    public bool player1=false;
    private void Start()
    {
        image1.sprite = defaultcard;
        image2.sprite = defaultcard;
        image3.sprite = defaultcard;
        Total_Tokens = 1000;
        if (gameObject.tag == "player") { 
        displayTotalTokens.text = Total_Tokens.ToString();
        }
        Bid_Amount = 0;
    }
    public void DealCard(int index, int imageNum)
    {
        switch (imageNum)
        {
            case 1: // iImg 1
                card_1_value = index;
                break;
            case 2:
                card_2_value = index;
                break;
            case 3:
                card_3_value = index;
                break;
            default:
                break;
        }
    }
    public void ShowCards()
    {
      //
                //StartCoroutine();
        AssignToCards(image1, card_1_value);
               // StartCoroutine();
        AssignToCards(image2, card_2_value);
        //StartCoroutine();
        AssignToCards(image3, card_3_value);
        if(player1)
        TurnManager.instance.ShowAllPlayers();




    }
    void AssignToCards(Image image,int index)
    {
        //yield return new WaitForSeconds(.5f);
        image.sprite = allCards[index];
    }
    public void passFunc()
    {
        TurnManager.instance.NextTurn();

    }
     public  int GetValues()
    {
        return card_1_value + card_2_value + card_3_value;
    }
 
    public void Place_Bids()
    {
        if(Total_Tokens>Bid_Amount)
        {
            Total_Tokens -= Bid_Amount;
            displayTotalTokens.text = Total_Tokens.ToString();
            EconomyManager.instance.Add_Tokens(Bid_Amount);
            EconomyManager.instance.Update_UI();
            if (gameObject.tag == "player")
            {
                GetComponent<Chips_Animation>()?.playAnimation1();
            }
        }
        TurnManager.instance.NextTurn();
    }

    public void increaseBid()
    {
        Bid_Amount += 100;
        if(Bid_Amount>Total_Tokens)
        {
            return;
        }
        else
        {
            bidText.text="BID "+Bid_Amount.ToString();
        }
    }
    
    public void decreaseBid()
    {
        Bid_Amount -= 100;
        if(Bid_Amount<0)
        {
            return;
        }
        else 
        {
            bidText.text = "BID " + Bid_Amount.ToString();
        }
    }


   
    public void EndTurn()
    {
        TurnManager.instance.NextTurn();
    }
    
}
