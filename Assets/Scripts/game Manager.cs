using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Timeline;
using UnityEngine.SceneManagement;


public class gameManager : MonoBehaviour
{
    public AudioClip failSound;
    [SerializeField] TMP_Text liveText;
    [SerializeField] TMP_Text scoreText;

    int lives = 3;
    int score;

    static public gameManager instance;

    public GameObject gameOverScreen;

    void Start()
    {
        instance = this;

      
        
    }
    

    public void AddScore(int value = 1)
    {
        score += value;
        scoreText.text = score.ToString();
    }
    public void Damage(int value = 1)
    {
        lives-=value;
        if (lives <= 0) GameOver();
        liveText.text = lives + " lives";
        Audio.Play(failSound);
    }
    void GameOver()
    {
        liveText.text = "";
        gameOverScreen.SetActive(true);
        
    }
    public void LoadScene()
    {
        SceneManager.LoadScene(1);
        gameOverScreen.SetActive(false);
    }

}
