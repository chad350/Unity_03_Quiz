using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizeScene : MonoBehaviour
{
    void Start()
    {
        UIManager.GetInstance().SetEventSystem();
        UIManager.GetInstance().OpenUI("UIQuiz");
    }
}
