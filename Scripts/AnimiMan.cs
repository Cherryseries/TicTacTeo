using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class AnimiMan : MonoBehaviour
{
    // Start is called before the first frame update
    public RectTransform DrawPanel;
    public CanvasGroup canvasgroup;
    public static AnimiMan instance;
    public RectTransform[] buttons;
    void Awake()
    {
        instance = this;
    }
    public void Fade()
    {
        canvasgroup.DOFade(0,2);    
    }
    public void DropDrawPanel()
    {
        DrawPanel.DOAnchorPos(new Vector2(0,-39),0.5f,false);
    }
    public void Pop(int popcount)
    {
        buttons[popcount].DOScale(new Vector3(0.5f,0.5f,0),0.2f).SetLoops(2,LoopType.Yoyo);
      
    }
}
