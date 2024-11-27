using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : MonoBehaviour
{
    public static GameOverManager gameOverManager;

   
    [SerializeField] GameObject gameOverPanel;



    private void Awake()
    {
        gameOverManager = this;
    }

    public void InitializeGameOver()
    {
      


        gameOverPanel.SetActive(true);
    }


}

