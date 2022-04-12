using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class 主菜单 : MonoBehaviour
{
    Button NewBt;
    Button End;
    public static int flag;

    void Start()
    {
        flag=1;
    }

    void Awake(){
        NewBt=transform.GetChild(1).GetComponent<Button>();
        End=transform.GetChild(2).GetComponent<Button>();

        End.onClick.AddListener(Exit);
        NewBt.onClick.AddListener(New);
    }

    void New(){
        SceneManager.LoadScene("关卡Ⅰ");
        print("开始游戏");
    }
    void Exit(){
        Application.Quit();
        print("退出游戏");
    }
}