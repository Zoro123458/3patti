using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TurnManager : MonoBehaviour
{
    public bool Player1;
    public bool Player2;
    public bool Player3;

    public NumberToImageAssigner player1;
    public NumberToImageAssigner player2;
    public NumberToImageAssigner player3;


    public int x, y, z;
    public static TurnManager instance;
    public Text winder;
    void Start()
    {
        instance = this;
        Player1 = true;
        Player2 = false;
        Player3 = false;
       

    }

    // Update is called once per frame
   public  void NextTurn()
    {
        EconomyManager.instance.Add_Tokens(20);
        EconomyManager.instance.Update_UI();
        return;
    }
    IEnumerator placeOtherPlayerBids(bool player)
    {
        player = !player;
        yield return new WaitForSeconds(1f);
        

    }

    public void ShowAllPlayers()
    {
        player3.ShowCards();
        player2.ShowCards();
        
        x = player1.GetValues();
        y = player2.GetValues();
        z = player3.GetValues();
        if(x>y && x > z)
        {
            winder.text = "Player 1 Wins";
            Debug.Log("P1  1ins");
        }
        if (y >x && y > z)
        {
            winder.text = "Player 2 Wins";
            Debug.Log("P2  1ins");
        }
        if (z > x && z > y)
        {
            winder.text = "Player 3 Wins";
            Debug.Log("P3  1ins");
        }

    }
 
}
