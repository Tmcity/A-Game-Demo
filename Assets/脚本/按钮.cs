using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class 按钮 : MonoBehaviour
{
    Button NewBt;
    public GameObject DestroyObj;

    void Awake(){
            NewBt=transform.GetChild(1).GetComponent<Button>();

            NewBt.onClick.AddListener(Close);
        }

    void Close(){
        Destroy(DestroyObj.gameObject);
        Destroy(this.gameObject);
    }
}
