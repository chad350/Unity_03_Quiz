using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScene : MonoBehaviour
{   
    void Start()
    {
        UIManager.GetInstance().SetEventSystem();
        UIManager.GetInstance().OpenUI("UIQuizSelector");

        if(ScenesManager.GetInstance().prevScene == Scene.Quiz)
            UIManager.GetInstance().OpenUI("UIQuizResult");
    }
}
