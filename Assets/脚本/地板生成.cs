using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 地板生成 : MonoBehaviour
{
    public GameObject block;
    public GameObject block2;
    private Vector3 sc;
    private Vector3 sp;
    private Vector3 sk;
    public float Length;
    public float width;
    public static float x;
    public static float y;
       void Start()
    {
        x=Length;
        y=width;

        sp=new Vector3(1f,1f,1f);
        block2.transform.localScale=sp;     //初始化大小为（1*0.8*1）

        sc=new Vector3(0f,0.0f,1f);
        for(int i=1;i<Length;i++){
            block2.transform.localScale+=sc;
    }                                       //将图形长值增大（Length-1）次,高度不改变
        sc=new Vector3(1f,0.0f,0f);
        for(int i=1;i<width;i++){
            block2.transform.localScale+=sc;
    }                                       //将图形宽值增大（width-1）次,高度不改变

        sk=new Vector3(0.2f,0.0f,0.2f);
        block2.transform.localScale+=sk;    //将图像长宽再增加0.2

        
        Vector3 temp1=new Vector3((width-1f)*0.5f,-0.1f,(Length-1f)*0.5f);
        Instantiate(block2,transform.position+temp1,Quaternion.identity);     //生成蓝色框架

        for (int y=0; y<Length; ++y){
           for (int x=0; x<width; ++x)
           {
               Vector3 temp2=new Vector3(x,0,y);
               Instantiate(block,transform.position+temp2, Quaternion.identity);     //生成Length*width个方块
           }
       }
    }

}
