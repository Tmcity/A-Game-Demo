using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class 关卡控制 : MonoBehaviour
{
    int fl_1;
//    int fl_2;
    int temp;
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene ();
        if(scene.name=="关卡Ⅰ"){
            temp=2;
        }
        if(scene.name=="关卡Ⅱ"){
            temp=0;
        }
        //SceneManager.LoadScene("主界面");
        fl_1=1;
//        fl_2=1;
    }

    void Update()
    {
        fl_1=碰撞检测.flag;
//        fl_2=主菜单.flag;
        if(fl_1==0){
            SceneManager.LoadScene(temp);
            fl_1=1;
            print("Load"+"->"+temp);
        }
/*        if(fl_2==0){
            SceneManager.LoadScene(1);
            fl_2=1;
            print("Load"+"->"+"new");
        }*/
    }
}
