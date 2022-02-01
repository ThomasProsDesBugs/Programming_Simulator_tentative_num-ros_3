using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_systeme : MonoBehaviour
{
    public Text scoreText;
    float targetScore = 100;
  
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString() + "POINTS";
        

    }
}
