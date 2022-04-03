using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LosingCollider : MonoBehaviour
{
    // Start is called before the first frame update
   
private void OnTriggerEnter2D()
{
    //FindObjectOfType<GameManager>().Miss();
    SceneManager.LoadScene(2);
}


}
