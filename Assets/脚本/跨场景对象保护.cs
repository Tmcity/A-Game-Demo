using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 跨场景对象保护 : MonoBehaviour
{
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public 存档 other;

    void OnApplicationQuit(){
        other.Quit();
    }
}