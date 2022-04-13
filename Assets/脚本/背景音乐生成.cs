using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class 背景音乐生成 : MonoBehaviour
{
    public GameObject bgmPrefab;
    public GameObject bgmInstance = null;

    void Start()
    {
        bgmInstance= GameObject.FindGameObjectWithTag("sound");
        if (bgmInstance==null)
        {
            bgmInstance = (GameObject)Instantiate(bgmPrefab);
        }
        
        Scene scene = SceneManager.GetActiveScene ();
        if(scene.name=="主界面"){
            SceneManager.MoveGameObjectToScene(bgmInstance, SceneManager.GetActiveScene());
            Destroy(bgmInstance);
            bgmInstance = (GameObject)Instantiate(bgmPrefab);
            print("OK");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
