using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointCount : MonoBehaviour
   {
    // 項目の宣言
     private int total;
     private int scorelargestar;
     private int scoresmallstar;
     private int scorelargecloud;
     private int scoresmallcloud;
     private GameObject GamePointText;

    // Use this for initialization
    void Start () {
        // 合計値のクリア
         total = 0;
        // 大きい星のスコアの設定
         scorelargestar = 100;
        // 小さい星のスコアの設定
         scoresmallstar = 10;
        // 大きい雲のスコアの設定
         scorelargecloud = 500;
        // 小さい雲のスコアの設定
         scoresmallcloud = 200;
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
