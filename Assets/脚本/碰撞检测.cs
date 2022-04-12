using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 碰撞检测 : MonoBehaviour
{
    public GameObject DestroyObj;
    public static int flag;
    public GameObject Sphere;
    public GameObject Sphere2;

    void Start()
    {
        flag=1;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider other){    //让碰撞发生时
        if(gameObject==Sphere){         //当触发此脚本的对象为Sphere时，将flag设为0
            Destroy(DestroyObj.gameObject);     //销毁“DestoyObj”
            flag=0;
        }
        if(gameObject==Sphere2){         //当触发此脚本的对象为Sphere时，将flag设为0
            flag=6;
        }
    }
}
