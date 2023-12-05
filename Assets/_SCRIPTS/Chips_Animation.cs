using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chips_Animation : MonoBehaviour
{
    public Animator anim_chips1;
    public Animator anim_chip2;
    public Animator anim_chip3;
    public void playAnimation1()
    {
        anim_chips1.enabled = true;
    }
    public void playAnimation2()
    {
        anim_chip2.enabled = true;
    }
    public void playAnimation3()
    {
        anim_chip3.enabled = true;
    }
   

}
