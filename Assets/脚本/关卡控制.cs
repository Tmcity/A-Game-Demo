using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class 关卡控制 : MonoBehaviour
{
    int fl_1;
    int fll;
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
        fll=1;
    }

    void Update()
    {
        fll=主菜单.fgmain;
        fl_1=碰撞检测.flag;

        if(fl_1==0){
            SceneManager.LoadScene(temp);
            print(fl_1);
            print("Load"+"->"+temp);
        }
 /*       if(fll==0){
            SceneManager.LoadScene("关卡Ⅰ");
            fll=1;
            print("Load"+"->"+"new");
        }*/
    }
}
