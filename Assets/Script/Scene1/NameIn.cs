using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NameIn : MonoBehaviour
{

string namever = TransferName.PlayerName;
    //public int disscore=GameManager.score;
 
public Text testDisplay;


public void StoreName() {
    
    Debug.Log(GameManager.score);
    testDisplay.text = namever + "'s Score is:" +  GameManager.score;
}

}
