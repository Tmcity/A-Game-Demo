using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 摄像机切换 : MonoBehaviour
{
    public Camera One;
    public Camera Three;
    public static int fl;
    void Start()
    {
        One.enabled=true;
        Three.enabled=false;
        fl=1;
    }                          //初始化摄像机状态

    void Update()
    {
        fl=碰撞检测.flag;       //获得“碰撞检测”脚本中的变量
        if(fl==6){             //当flag被激活时，切换摄像头
            One.enabled=false;
            Three.enabled=true;
        }
    }
}