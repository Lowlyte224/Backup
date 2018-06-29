using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HUD_Manager : MonoBehaviour
{

    public int StartingHealth;
    int CurrentHealth;

    public Slider HealthBar;
    int score;
    public Text scoretext;

    // Use this for initialization
    void Start()
    {
        score = 0;
        scoretext.text = "Score: " + score;
        CurrentHealth = StartingHealth;
        HealthBar.value = CurrentHealth;
    }


    public void UpdateScore(int amount)
    {
        score = score + amount;
        scoretext.text = "score: " + score;
    }

    public void UpdateHealth(int amount)
    {
        CurrentHealth = CurrentHealth + amount;
        HealthBar.value = CurrentHealth;
        if (CurrentHealth <= 0)
        {
            Death();
        }
    }

    void Death()
    {
        SceneManager.LoadScene("e");
    }

}        
        
        
        
        
        

