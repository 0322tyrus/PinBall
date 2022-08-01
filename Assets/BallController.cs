using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //ボールが見える可能性のあるz軸の最小値
    private float visiblePosZ = -6.5f;
    int score = 0;
    

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;
    private GameObject scoreText;


 
    
    // Start is called before the first frame update
    void Start()
    {
        score = 0;

        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
        this.scoreText = GameObject.Find("ScoreText");
       
    }


       // Update is called once per frame
    void Update()
    {


        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SmallStarTag")
        {
            this.score += 10;
            this.scoreText.GetComponent<Text>().text =score.ToString();
        }
        else if (collision.gameObject.tag == "LargeStarTag")
        {
            this.score += 20;
            this.scoreText.GetComponent<Text>().text =score.ToString();
        }

    }
}
