using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class EconomyManager : MonoBehaviour
{
    public int Total_Tokens;
    public static EconomyManager instance;
    public Text UI_Show;


    public void Start()
    {
        instance = this;
        Total_Tokens = 0;
        Update_UI();
       

    }
    public void Add_Tokens(int value)
    {
        Total_Tokens += value;
    }

    public void Minus_Tokens(int value)
    {
        Total_Tokens -= value;
    }

    public void Give_Tokens()
    {

    }
    
    public void Update_UI()
    {
        UI_Show.text = Total_Tokens.ToString();

    }

    public void SceneChanger()
    {
        SceneManager.LoadScene(0);
    }
}
