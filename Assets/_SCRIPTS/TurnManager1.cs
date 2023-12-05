using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TurnManager1 : MonoBehaviour
{
    public NumberToImageAssigner player1;
    public NumberToImageAssigner player2;
    public NumberToImageAssigner player3;

    public GameObject Button;

    public GameObject Slider1;
    public GameObject Slider2;
    public GameObject Slider3;


    private NumberToImageAssigner currentPlayer;



    private void Start()
    {
        StartCoroutine(StartTurns());
    }

    IEnumerator StartTurns()
    {
        while (true)
        {
            yield return StartCoroutine(PlayerTurn(player1, 10.0f));
            yield return StartCoroutine(PlayerTurn(player2, 10.0f));
            yield return StartCoroutine(PlayerTurn(player3, 10.0f));
        }
    }

    IEnumerator PlayerTurn(NumberToImageAssigner player, float turnDuration)
    {
        currentPlayer = player;

        Debug.Log($"Player {player.gameObject.name}'s Turn");

        if(player==player2 )
        {
            Button.SetActive(false);
            Slider2.SetActive(true);

            Slider1.SetActive(false);
            Slider3.SetActive(false);
        }

        else if (player == player3)
        {

            Button.SetActive(false);
            Slider3.SetActive(true);

            Slider1.SetActive(false);
            Slider2.SetActive(false);
        }

        else
        {
            Button.SetActive(true);
            Slider1.SetActive(true);

            Slider2.SetActive(false);
            Slider3.SetActive(false);
        }

        // Simulating a delay for the player's turn (replace this with your actual turn logic)
        yield return new WaitForSeconds(turnDuration);
    }
}
