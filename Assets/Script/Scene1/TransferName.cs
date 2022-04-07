using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TransferName : MonoBehaviour
{

    public static string PlayerName;
    public Text inputField;
 

    public void StoreName()
    {
        PlayerName = inputField.text;
    
       
        
   }
  
}
