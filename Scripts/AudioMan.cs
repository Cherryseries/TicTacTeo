using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioMan : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource ButtonClick,Draw;
    public AudioClip ButtonClickclip,DrawClip;
    public static AudioMan Instance;
    void Awake ()
    {
        Instance = this;
    }
    void Start()
    {
        ButtonClick = GetComponent<AudioSource>();
        Draw = GetComponent<AudioSource>();
        ButtonClick.clip = ButtonClickclip;
        Draw.clip = DrawClip;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void play()
    {
        ButtonClick.Play();
    }
    public void DrawSound()
    {
        Draw.Play();
    }
}
