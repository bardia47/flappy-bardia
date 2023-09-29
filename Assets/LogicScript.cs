using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject scoreText;
    public GameObject liveText;
    public int lives;

    public AudioSource dieSound;
    public AudioSource hitSound;
    public AudioSource scoreSound;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.FindGameObjectWithTag("Score");
        liveText = GameObject.FindGameObjectWithTag("Live");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    public void GameOver() {
        dieSound.Play();
        Time.timeScale = 0;
        gameOverScreen.SetActive(true);
    }

    public int playerScore = 0;

    [ContextMenu("Add Score")]
    public void addScore()
    {

        playerScore++;
        scoreText.GetComponent<Text>().text = playerScore.ToString();
        scoreSound.Play();

    }

    public void changeLive(int num)
    {
        if (lives > 0){ 
        hitSound.Play();
        lives = Mathf.Max(lives-num,0);
            updateLive();
        }
    }

    public void updateLive()
    {

        liveText.GetComponent<Text>().text = lives.ToString();
        if (lives<=0)
            GameOver();

    }

}
