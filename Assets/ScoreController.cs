using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{

    int score = 0;
    Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        this.scoreText = GameObject.Find("Text").GetComponent<Text>();
        this.scoreText.text = "Score:" + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
