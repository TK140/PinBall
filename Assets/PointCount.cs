using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCount : MonoBehaviour
   {
    // 項目の宣言
    // 合計値のクリア
     private int total = 0;
    // 大きい星のスコアの設定
     private int scorelargestar = 100;
    // 小さい星のスコアの設定
     private int scoresmallstar = 10;
    // 小さい雲のスコアの設定
     private int scorelargecloud = 500;
    // 小さい雲のスコアの設定
     private int scoresmallcloud = 200;
     private GameObject GamePointText;

    // Use this for initialization
    void Start () {
        
        // スコアテキストのオブジェクトの取得
        this.GamePointText = GameObject.Find("GamePointText");
    }

    // Update is called once per frame
    void Update() { }
          
    //衝突時に呼ばれる関数
        void OnCollisionEnter(Collision other)
        {
        
        // タグごとに点数を加算する
        if (other.gameObject.tag == "SmallStarTag")
            {
                 this.total = this.total + scoresmallstar;
            }
            else if (other.gameObject.tag == "LargeStarTag")
            {
                 this.total = this.total + scorelargestar;
            }
            else if (other.gameObject.tag == "SmallCloudTag")
            {
                 this.total = this.total + scoresmallcloud;
            }
            else if (other.gameObject.tag == "LargeCloudTag")
            {
                 this.total = this.total + scorelargecloud;
            }
          {
         //スコアの表示
           this.GamePointText.GetComponent<Text>().text = " " + this.total;
          }

        }
    }
