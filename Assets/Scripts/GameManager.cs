﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    //gameObjects
    public GameObject ball;
    public GameObject player;

    public bool isActive = false;

    // UI Elements
    public Button startButton;
    public TextMeshProUGUI levelCoverText;
    public Button exitButton;
    public Button controlButton;
    public Button aboutButton;

    public Slider healthBar;
    public Slider dashBar;

    // Start is called before the first frame update
    void Start()
    {
        try {
            startButton.gameObject.GetComponent<Button>();
            startButton.onClick.AddListener(StartGame);
            exitButton.gameObject.GetComponent<Button>();
            exitButton.onClick.AddListener(ExitGame);
            controlButton.gameObject.GetComponent<Button>();
            aboutButton.gameObject.GetComponent<Button>();
            healthBar.gameObject.GetComponent<Slider>();
            dashBar.gameObject.GetComponent<Slider>();
        }
        catch {

        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Start the game
    public void StartGame() {
        isActive = true;
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "StartMenu") {
		    SceneManager.LoadScene("Level1");
        }
        if (scene.name == "Victory") {
		    SceneManager.LoadScene("StartMenu");
        }
        try {
            startButton.gameObject.SetActive(false);
            levelCoverText.gameObject.SetActive(false);
        }
        catch {}
    }

    public void ResetGame(){
        isActive = false;
        Scene scene = SceneManager.GetActiveScene();
        
    }

    public void ExitGame() {
        Application.Quit();
    }
}
