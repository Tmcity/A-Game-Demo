using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class 选关按钮 : MonoBehaviour
{
    Button b1;
    Button b2;
    int[] LevelsOn;

    void Update(){
        LevelsOn=存档.LevelsOn;
    }
    void Awake(){
            b1=transform.GetChild(1).GetComponent<Button>();
            b2=transform.GetChild(2).GetComponent<Button>();

            b1.onClick.AddListener(delegate {chick(1);});
            b2.onClick.AddListener(delegate {chick(2);});
        }

    void chick(int num){
        if(num==1)
        {
            if(LevelsOn[0]==1)
            {
                SceneManager.LoadScene("关卡Ⅰ");
                print("Load -> 关卡Ⅰ");
            }
        }
        else
        {
            if(num==2)
            {
                if(LevelsOn[1]==1)
                {
                    SceneManager.LoadScene("关卡Ⅱ");
                    print("Load -> 关卡Ⅱ");
                }
                else
                {
                print("未解锁");
                }
            }
        }

    }
}
