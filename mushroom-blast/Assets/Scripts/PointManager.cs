using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//usint TMPro;

public class PointManager : MonoBehaviour
{
    public int score;
    //public TMP_Text scoreText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateScore(int points)
    {
        score += points;
        //scoreText.text = "Score: " + score;
    }
}
