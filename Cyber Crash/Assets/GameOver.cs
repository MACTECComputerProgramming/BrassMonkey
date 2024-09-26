using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class GameOver : MonoBehaviour 
{
    public Text pointsText;
    public void setup(int score) 
    { 
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + "Points";
    }
}


    
    