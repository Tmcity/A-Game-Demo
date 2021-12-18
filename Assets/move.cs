using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject sphere;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        PenZhuang();
    }
    public void Move(){
        if(Input.GetKeyDown(KeyCode.W)&&transform.position.z!=1){//检测W键按下，并同时z不等于1
            transform.Translate(Vector3.forward);//按下W键时，控制对象向前
        }
        if(Input.GetKeyDown(KeyCode.S)&&transform.position.z!=-1){//检测S键按下，并同时z不等于-1
            transform.Translate(Vector3.back);//按下S键时，控制对象向后
        }
        if(Input.GetKeyDown(KeyCode.A)&&transform.position.x!=-1){//检测A键按下，并同时x不等于-1
            transform.Translate(Vector3.left);//按下A键时，控制对象向左
        }
        if(Input.GetKeyDown(KeyCode.D)&&transform.position.x!=1){//检测D键按下，并同时x不等于1
            transform.Translate(Vector3.right);//按下D键时，控制对象向右
        }
    }
    public void PenZhuang(){
        if(transform.position==sphere.transform.position){//检测当对象的位置等于sphere对象的位置时
            print("Game Over");//输出“Game Over”
        }
    }
}
