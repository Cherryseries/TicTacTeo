using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class ButtonMan : MonoBehaviour
{
    // Start is called before the first frame update
    private int hit0,hit1,hit2,hit3,hit4,hit5,hit6,hit7,hit8 = 0;
    public static ButtonMan instance;
    void Awake()
    {
        instance = this;
    }
    public void show1()
    {
        if(hit0 == 0){
        GameMan.instance.Change();
        AnimiMan.instance.Pop(0);
        GameMan.instance.select(0);
        GameMan.instance.Check();
        hit0+=1;
        }

    }
    public void show2()
    {
        if(hit1 == 0)
        {
        GameMan.instance.Change();
        AnimiMan.instance.Pop(1);
        GameMan.instance.select(1);
        GameMan.instance.Check();
        hit1 +=1;
        }
      
    }
    public void show3()
    {
        if(hit2 == 0)
        {
        GameMan.instance.Change();
        AnimiMan.instance.Pop(2);
        GameMan.instance.select(2);
        GameMan.instance.Check();
        hit2 +=1;
        }
    }
    public void show4()
    {
        if(hit3 == 0){
        GameMan.instance.Change();
        AnimiMan.instance.Pop(3);
        GameMan.instance.select(3);
        GameMan.instance.Check();
        hit3 +=1;
        }
    }
    public void show5()
    {
        if(hit4 == 0){
        GameMan.instance.Change();
        AnimiMan.instance.Pop(4);
        GameMan.instance.select(4);
        GameMan.instance.Check();
        hit4 +=1;
        }
    }
    public void show6()
    {
        if(hit5 == 0){
        GameMan.instance.Change();
        AnimiMan.instance.Pop(5);
        GameMan.instance.select(5);
        GameMan.instance.Check();
        hit5 +=1;
        }
    }
    public void show7()
    {
        if(hit6 == 0){
        GameMan.instance.Change();
        AnimiMan.instance.Pop(6);
        GameMan.instance.select(6);
        GameMan.instance.Check(); 
        hit6 +=1;
        }
    }
    public void show8()
    {
        if(hit7 == 0){
        GameMan.instance.Change();
        AnimiMan.instance.Pop(7);
        GameMan.instance.select(7);
        GameMan.instance.Check(); 
        hit7 +=1;
        }
    }
    public void show9()
    {
        if(hit8 == 0){
        GameMan.instance.Change();
        AnimiMan.instance.Pop(8);
        GameMan.instance.select(8);
        GameMan.instance.Check(); 
        hit8 +=1;
        }
    }
    public void PlayAgain()
    {
       AnimiMan.instance.Fade();
       SceneManager.LoadScene(0);
    }
}
