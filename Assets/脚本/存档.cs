using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BayatGames.SaveGameFree;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class 存档 : MonoBehaviour
{
    public static int[] LevelsOn={0,0,0,0};

    public void Start()
    {
        if(SaveGame.Exists ( "simple.json" )==true){
            Load();
            print("已加载存档");
        }
        else{
            Save(0);
        }
    }

    public void Quit()
    {
        Scene scene = SceneManager.GetActiveScene ();
        print(scene.buildIndex);
        if(scene.buildIndex>1)
        {
            Save(scene.buildIndex-2);
        }

    }


    public void Save(int Level)
    {
        LevelsOn[Level] = 1;
        SaveGame.Save<int[]>("simple.json",LevelsOn);
        print(Level+" Game Saved!");
        Debug.Log("数据位置：" + Application.persistentDataPath);
    }

    public void Load()
    {
        LevelsOn = SaveGame.Load<int[]> ("simple.json");
    }
}
