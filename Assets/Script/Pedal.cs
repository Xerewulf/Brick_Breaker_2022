using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pedal : MonoBehaviour
{
     [SerializeField] float ekranGenisligiUnitCinsinden = 16f;  // Start is called before the first frame update
   void Update()
    {
        float farePozUnitCinsinden = Input.mousePosition.x / Screen.width * ekranGenisligiUnitCinsinden;
        Vector2 pedalPozisyonu = new Vector2(farePozUnitCinsinden, transform.position.y);
        pedalPozisyonu.x  = Mathf.Clamp(pedalPozisyonu.x, 0,18f);
        transform.position = pedalPozisyonu;

    }
  
}
