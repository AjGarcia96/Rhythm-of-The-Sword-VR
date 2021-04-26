using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float startTime = 10.0f;
    public int score = 0;
    public float lifeTime = 1.0f;
    public int hitEnemyScore = 10;
    public float missEnemyLife = 0.05f;
    public float wrongEnemyLife = 0.05f;

    
    public static GameManager instance;

    void Awake()
    {
        instance = this;
    }
       
    //Adds score when hit correct enemy
    public void AddScore ()
    {
        score += hitEnemyScore;
        GameUI.instance.UpdateScoreText();
    }
    //deducts life when enemy reaches missDetector
    public void MissEnemy ()
    {
        lifeTime -= missEnemyLife;
    }
    //deducts life when enemy is hit with wrong weapon
    public void HitWrongEnemy ()
    {
        lifeTime -= wrongEnemyLife;
    }

    void Update()
    {
        if (lifeTime <= 0.0f)
            LoseGame();
        //update the life bar
        GameUI.instance.UpdateLifetimeBar();
    }
    //called when the song is over
    public void WinGame()
    {
        SceneManager.LoadScene(0);
    }
    //called when life bar hits 0
    public void LoseGame ()
    {
        SceneManager.LoadScene(0);
    }
}
