using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isGameOver;
    public List<GameObject> enemiesInScreen;
    public Text coinText;
    int coins;
    
     void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            DestroyEnemiesInScreen();
        }
    }

    public void DestroyEnemiesInScreen()
    {
        foreach (GameObject enemy in enemiesInScreen)
        {
            Destroy(enemy);
        }
    }

    public void GameOver()
    {
        isGameOver = true;
    }

    public void AddCoin()
    {
        coins++;
        coinText.text = coins.ToString();
    }
}