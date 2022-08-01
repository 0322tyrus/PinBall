using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    //�{�[����������\���̂���z���̍ŏ��l
    private float visiblePosZ = -6.5f;
    int score = 0;
    

    //�Q�[���I�[�o��\������e�L�X�g
    private GameObject gameoverText;
    private GameObject scoreText;


 
    
    // Start is called before the first frame update
    void Start()
    {
        score = 0;

        //�V�[������GameOverText�I�u�W�F�N�g���擾
        this.gameoverText = GameObject.Find("GameOverText");
        this.scoreText = GameObject.Find("ScoreText");
       
    }


       // Update is called once per frame
    void Update()
    {


        //�{�[������ʊO�ɏo���ꍇ
        if (this.transform.position.z < this.visiblePosZ)
        {
            //GameoverText�ɃQ�[���I�[�o��\��
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
