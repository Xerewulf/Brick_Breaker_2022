using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NameIn : MonoBehaviour
{

string namever = TransferName.scene1.PlayerName;
    public int disscore=GameManager.gamemanagertool.GetScore();
 
public Text testDisplay;
public void StoreName() {
    

    testDisplay.text = $"{namever} Score is +{disscore}";
}

}
