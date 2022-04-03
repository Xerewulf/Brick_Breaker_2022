using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TransferName : MonoBehaviour
{
public static TransferName scene1;
    public string PlayerName;
    public Text inputField;
 

    public void StoreName()
    {
        PlayerName = inputField.text;
    
       
        
   }
   public string GetName()
   {

       return this.PlayerName;
   }
}
