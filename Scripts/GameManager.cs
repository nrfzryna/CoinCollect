using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI TimerText;
    public TextMeshProUGUI endText;
    public GameObject startPanel;
    public GameObject endPanel;

    public float gameDuration = 30f;
    private float timeRemaining;
    private bool gameActive = false;
    private int score = 0;

    void Awake()
    {
        instance = this;
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }
    }

    void Start()
    {
        timeRemaining = gameDuration;
        UpdateScoreUI();
        ShowStartMessage();
    }

    void Update()
    {
        if (gameActive)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimerUI();

            if (timeRemaining <= 0f)
            {
                EndGame();
            }

            UpdateTimerUI();
        }
    }

    public void AddScore(int value)
    {
        score += value;
        UpdateScoreUI();
    }

    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }

    void UpdateTimerUI()
    {
        int minutes = Mathf.FloorToInt(timeRemaining / 60);
        int seconds = Mathf.FloorToInt(timeRemaining % 60);
        TimerText.text = $"{minutes:00}:{seconds:00}";
    }

    void ShowStartMessage()
    {
        startPanel.SetActive(true);
        Invoke(nameof(StartGame), 2f);
    }

    void StartGame()
    {
        startPanel.SetActive(false);
        gameActive = true;
    }

    public void EndGame()
    {
        gameActive = false;
        endPanel.SetActive(true);
        endText.text = $"Game Over! Your score: {score}";
    }
}
