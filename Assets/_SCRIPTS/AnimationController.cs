using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    public Animator anim;
    public string nextAnimation;
    public GameObject[] cardToDisplay;
    public TurnManager1 TT;
    
    // Start is called before the first frame update
    private void Start()
    {
        anim = GetComponent<Animator>();    
    }
    public  void PlayeNext(string value)
    {
        StartCoroutine(playNextAnimation(value));   
    }
    IEnumerator playNextAnimation(string value)
    {
        yield return new WaitForSeconds(.2f);
        anim.Play(value);
        
    }
    public void SetCardActive(int index)
    {
        switch(index)
        {
            case 0:
                cardToDisplay[index].SetActive(true);
                break; 
            case 1:
                cardToDisplay[index].SetActive(true);
                break;
            case 2:
                cardToDisplay[index].SetActive(true);
                break;

            case 3:
                cardToDisplay[index].SetActive(true);
                break;

            case 4:
                cardToDisplay[index].SetActive(true);
                break;

            case 5:
                cardToDisplay[index].SetActive(true);
                break;

            case 6:
                cardToDisplay[index].SetActive(true);
                break;
            case 7:
                cardToDisplay[index].SetActive(true);
                break;
            case 8:
                cardToDisplay[index].SetActive(true);
                break;
            case 9:
                cardToDisplay[index].SetActive(true);
                turn();
                break;

            default: 
                break;

        }
        //GameObject.FindGameObjectWithTag(cardToAcive)?.gameObject.SetActive(true);
    }
    public void turn()
    {
        TT.enabled = true;
    }
}
