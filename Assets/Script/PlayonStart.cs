using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayonStart : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private AudioClip Sclip;

  

    private void OnTriggerEnter2D()
    {
        SoundControl.Cont.PlaySound(Sclip);
        
    }

}
