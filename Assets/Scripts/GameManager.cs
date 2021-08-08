using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    public TMP_Text timeText;

    public GameObject GameOver;

    public RectTransform rectTransform;

    public GameObject LabelLevel;
    public GameObject LabelWS;
    public GameObject LabelRaiseDown;
    public GameObject LabelAttack;

    public static int count = 0;

    public GameObject WonUI;

    public int ToWin;

    public GameObject Pause;

    public TMP_Text bitescounter;

    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;


        StartCoroutine(ShowWS());
    }

    IEnumerator ShowWS()
    {
        
        yield return new WaitForSeconds(6f);
        LabelWS.SetActive(false);
        LabelLevel.SetActive(false);
        StartCoroutine(ShowRaiseDown());
    }

    IEnumerator ShowRaiseDown()
    {

        yield return new WaitForSeconds(6f);
        LabelRaiseDown.SetActive(true);
        StartCoroutine(ShowAttack());
        
    }

    IEnumerator ShowAttack()
    {
        
        yield return new WaitForSeconds(6f);
        LabelRaiseDown.SetActive(false);
        LabelAttack.SetActive(true);


        Invoke("ShowHide", 6f);
    }
    
    private void ShowHide()
    {
        LabelAttack.SetActive(false);
    }



    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                GameOver.SetActive(true);
                
            }
        }

        if(rectTransform.localScale.x < 0.1f)
        {
            GameOver.SetActive(true);
        }

        if(count == ToWin)
        {
            WonUI.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause.SetActive(true);
            Time.timeScale = 0f;
            AudioListener.pause = true;
        }


        bitescounter.text = count.ToString();

    }

    

    public void ResumeGame()
    {
        Pause.SetActive(false);
        Time.timeScale = 1;
        AudioListener.pause = false;

    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("Time left: {0:00}:{1:00}", minutes, seconds);
    }
}