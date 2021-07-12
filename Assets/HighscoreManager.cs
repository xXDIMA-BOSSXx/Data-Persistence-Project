using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HighscoreManager : MonoBehaviour
{
    MainManager mainManager;
    public Text highscoreText;
    
    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        if (GameManager.Instance != null)
        {
            highscoreText.text = "Best Score: " + GameManager.Instance.playerName + ": " + GameManager.Instance.score;
        }
    }
}
