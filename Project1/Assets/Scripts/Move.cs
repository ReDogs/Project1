using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //キーボードの左矢印が押されている
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.position      //自分のオブジェクトの位置
                -=      //左の値に右の値を加算する記号
                new Vector3(
                    2.0f * Time.deltaTime,    //x座標で1秒間に2移動する
                    0.0f,                    //移動しない
                    0.0f);                  //移動しない
        }
        //キーボードの右矢印が押されている
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.position      //自分のオブジェクトの位置
                +=      //左の値に右の値を加算する記号
                new Vector3(
                    2.0f * Time.deltaTime,    //x座標で1秒間に2移動する
                    0.0f,                    //移動しない
                    0.0f);                  //移動しない
        }
    }
}
