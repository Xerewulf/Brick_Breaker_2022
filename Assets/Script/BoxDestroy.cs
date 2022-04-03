using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDestroy : MonoBehaviour
{
    // Start is called before the first frame update
     [SerializeField] private AudioClip Sclip;
 private void OnCollisionEnter2D()
 {
      SoundControl.Cont.PlaySound(Sclip);
      Object.Destroy(gameObject, 0f);
      
      GameManager.score++;
 }


}
