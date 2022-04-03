using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{
    
    public static SoundControl Cont;
    [SerializeField] private AudioSource Clip,Hit;
    

    private void Awake() {
    {
        if (Cont == null)
            Cont = this;
    }
    }

    


    public void PlaySound(AudioClip clip)
    {
       
        Hit.PlayOneShot(clip);

    }
}
