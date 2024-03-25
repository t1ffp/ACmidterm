using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Transition : MonoBehaviour
{
    public GameObject blackScreen;
    public GameObject gameScreen;

    public GameObject playText;
    public bool canPlay = false;

    public GameObject instructionText;
    public bool isPlaying;


    public GameObject gameAudio;
    public GameObject gameAnim;

    private bool timerOn = false;
    public float gameTimer;
    public TextMeshProUGUI gametimerText;

    public float startTimer;
    public TextMeshProUGUI starttimerText;

    // Start is called before the first frame update
    void Start()
    {
        gameAudio.SetActive(false);
        gameAnim.SetActive(false);
        blackScreen.SetActive(false);  
    }

    private void Update()
    {
        if(canPlay && !isPlaying && Input.GetKeyDown(KeyCode.Space))
        {
            blackScreen.SetActive(true);
            gameScreen.SetActive(true);
            instructionText.SetActive(true);
            ResetTimers();
            timerOn = true;
        }

        if (timerOn)
        {
            starttimerText.enabled = true;
            startTimer -= Time.deltaTime;
            starttimerText.text = (startTimer).ToString("0");
            isPlaying = true;
        }

        if (startTimer < 0)
        {
            timerOn = false;
            starttimerText.enabled = false;
            StartGame();
            
        }

        //EndGame();


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playText.SetActive(true);
            canPlay = true;
            isPlaying = false;
            ResetTimers();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playText.SetActive(false);
            canPlay = false;
            isPlaying = false;
            
        }
    }

    void StartGame()
    {
        if (isPlaying && startTimer < 0)
        {
            gameAudio.SetActive(true);
            gameAnim.SetActive(true);
            EndGame();
            instructionText.SetActive(false);
        }
    }

    void EndGame()
    {
        if(gameAnim.activeInHierarchy)
        {
            gametimerText.enabled = true;
            gameTimer -= Time.deltaTime;
            gametimerText.text = (gameTimer).ToString("0");

            if(gameTimer < 0)
            {
                isPlaying = false;
                canPlay = false;
                gameAudio.SetActive(false);
                gameAnim.SetActive(false);
                gametimerText.enabled = false;
                blackScreen.SetActive(false);
                gameScreen.SetActive(false);
            }
     
        }
    }

    void ResetTimers()
    {
        startTimer = 10f;
        gameTimer = 30f;
    }
}
