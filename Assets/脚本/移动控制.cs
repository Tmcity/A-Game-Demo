using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 移动控制 : MonoBehaviour
{
    float x;
    float y;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x=地板生成.x-2;
        y=地板生成.y-2;
        Move();
    }
        public void Move(){
        if(Input.GetKeyDown(KeyCode.W)&&transform.position.z<(x-0.2)&&transform.position.z<(x+0.2)){//检测W键按下，并同时z不小于x+0.2~x-0.2
            transform.Translate(Vector3.forward);//按下W键时，控制对象向前
        }
        if(Input.GetKeyDown(KeyCode.S)&&transform.position.z>-0.8){//检测S键按下，并同时z不小于-0.8
            transform.Translate(Vector3.back);//按下S键时，控制对象向后
        }
        if(Input.GetKeyDown(KeyCode.A)&&transform.position.x>-0.8){//检测A键按下，并同时x不小于-0.8
            transform.Translate(Vector3.left);//按下A键时，控制对象向左
        }
        if(Input.GetKeyDown(KeyCode.D)&&transform.position.x<(y-0.2)&&transform.position.x<(y+0.2)){//检测D键按下，并同时x不小于y+0.2~y-0.2
            transform.Translate(Vector3.right);//按下D键时，控制对象向右
        }
    }
}
