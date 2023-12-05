using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuManager : MonoBehaviour
{


    public string gameVersion = "1.0";

    public TextMeshPro CoStateText, PlayerCountText;
    public bool checkGameStart;

    public GameObject MainButtons;

    public GameObject PlayButton, HerosParent;

    public Canvas MainCanvas, RegisterCanvas;

    public InputField LocalUsernameIF;

    public Text UsernameText, MoneyText;

    public GameObject MainUI, ShopUI, ProfileUI, RewardsUI, RateUI, SettingsUI, RoomUI, ScrollUI;
    public GameObject cashItemsPanel, DiverItemsPanel;

    public enum MatchFilters
    {

        None,
        NORMAL,

    }

    public MatchFilters currentMacthFilter;

    void Start()
    {
        if (PlayerPrefs.HasKey("USERNAME"))
        {
            LoadMainUI();
        }
        else
        {
            MainCanvas.enabled = false;
            RegisterCanvas.enabled = true;
        }
        

    }

   

    public void ValidateLocalRegister()
    {
        if (LocalUsernameIF.text != "")
        {

            PlayerPrefs.SetString("USERNAME", LocalUsernameIF.text);
            PlayerPrefs.SetInt("MONEY", 100000);

            LoadMainUI();

        }
    }

    public void HOME()
    {

        LoadMainUI();

    }

    public void DisplayShop()
    {
        MainUI.SetActive(false);
        ScrollUI.SetActive(false);
        ShopUI.SetActive(true);
        DisplayCashPanelItems();
    }

    public void DisplayProfile()
    {
        MainUI.SetActive(false);
        ScrollUI.SetActive(false);
        ProfileUI.SetActive(true);
    }

    public void DisplayRewards()
    {
        MainUI.SetActive(false);
        ScrollUI.SetActive(false);
        RewardsUI.SetActive(true);
    }

    public void DisplayRate()
    {
        MainUI.SetActive(false);
        ScrollUI.SetActive(false);
        RateUI.SetActive(true);
    }

    public void DisplaySettings()
    {
        MainUI.SetActive(false);
        ScrollUI.SetActive(false);
        SettingsUI.SetActive(true);
    }

    public void DisplayCashPanelItems()
    {

        DiverItemsPanel.SetActive(false);
        cashItemsPanel.SetActive(true);

    }

    public void DisplayDiversPanelItems()
    {

        cashItemsPanel.SetActive(false);
        DiverItemsPanel.SetActive(true);

    }

    void LoadMainUI()
    {
        ShopUI.SetActive(false);
        ProfileUI.SetActive(false);
        RewardsUI.SetActive(false);
        RateUI.SetActive(false);
        SettingsUI.SetActive(false);
        MainUI.SetActive(true);
        ScrollUI.SetActive(true);

        RegisterCanvas.enabled = false;
        MainCanvas.enabled = true;

        UsernameText.text = PlayerPrefs.GetString("USERNAME");
        MoneyText.text = PlayerPrefs.GetInt("MONEY") + " $";


    }


    public void PLAY_NORMAL()
    {
        SceneManager.LoadScene(1);
    }


}
