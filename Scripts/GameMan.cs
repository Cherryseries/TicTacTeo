using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMan : MonoBehaviour
{
    // Start is called before the first frame update
    public bool flag = true;
    public Text[] T;
    public Text Winner;
    private int i ,a =0;
    public static GameMan instance;
    void Awake()
    {
        instance = this;
    }
    public void select(int i)
    {
        if(flag == true)
        {
            T[i].text ="O";   
        }
        else 
        {
            T[i].text="X";       
        }
    }
    public void Check()
    {
        if((T[0].text == T[1].text && T[0].text == T[2].text)||(T[0].text == T[3].text && T[0].text == T[6].text)||(T[0].text == T[4].text && T[0].text == T[8].text))
        {
            Winner.text = T[0].text ;
            if(T[0].text == "X"||T[0].text == "O")
            {
                AnimiMan.instance.Fade();
            }
        }
        else if((T[8].text == T[5].text && T[8].text == T[2].text)||(T[8].text == T[6].text && T[8].text == T[7].text))
        {
            Winner.text = T[8].text ;
            if(T[8].text == "X"||T[8].text == "O")
            {
                AnimiMan.instance.Fade();
            }
        }
        else if((T[4].text == T[1].text && T[4].text == T[7].text)||(T[4].text == T[2].text && T[4].text == T[6].text)||(T[4].text == T[3].text && T[4].text == T[5].text))
        {
            Winner.text = T[4].text ;
            if(T[4].text == "X"||T[4].text == "O")
            {
                AnimiMan.instance.Fade();
            }
            
        }
        a+=1;
        //Debug.Log(a);
        if(a == 9)
        {
            AnimiMan.instance.DropDrawPanel();
        }
    }
    public void Change()
    {
        flag = !flag;
    } 
}
