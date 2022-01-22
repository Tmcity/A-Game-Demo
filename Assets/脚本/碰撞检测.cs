using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 碰撞检测 : MonoBehaviour
{

    public GameObject DestroyObj;
    //public GameObject TriggerObj;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other){    //让碰撞发生时
        Destroy(DestroyObj.gameObject);     //销毁“DestoyObj”
    }
}
