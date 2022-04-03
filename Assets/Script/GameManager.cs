using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager gamemanagertool;
    // Start is called before the first frame update
    public Top ball {get; private set; }
    public Pedal pedal {get; private set; }
    public static int score=0;
    
    public int life =5;
private void Awake()
{
SceneManager.sceneLoaded += OnLevelLoaded;    

     
}

private void OnLevelLoaded(Scene scene ,LoadSceneMode mode )
{
this.ball = FindObjectOfType<Top>();
this.pedal = FindObjectOfType<Pedal>();
}
    public void Miss()
    {
        this.life--;
        if(life>0)
            ResetGame();
        else
            GameOver();
        
    }

    public void GameOver()
    {
        SceneManager.LoadScene(2);
    }

    public void ResetGame()
    {
        this.ball.ResetBall();
        
    }
public int GetScore()
{
    return score;
}



}
