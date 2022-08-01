using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudController : MonoBehaviour
{

    //最小サイズ
    private float minimum = 1.0f;
    //拡大縮小スピード
    private float magSpeed = 10.0f;
    //拡大率
    private float magnification = 0.07f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //雲を拡大縮小
        this.transform.localScale = new Vector3(this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification, this.transform.localScale.y, this.minimum + Mathf.Sin(Time.time * this.magSpeed) * this.magnification);
   //Mathf.Sinの意味、Sin関数？→角度をいじるもの
   //　スタートからの時間*拡大縮小スピード*拡大率＋初期のサイズ
   
   //拡大縮小どうやっている？→Sin使うことで無限に伸びる時間の糸を半径1の円に巻きつけ、巻き終わった位置を知らせるイメージ（単位円の考え方らしい）、さらにそれに拡大スピードを掛けて拡大率を掛けている


    }
}
