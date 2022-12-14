using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        UIManager.GetInstance().SetEventSystem();
        UIManager.GetInstance().OpenUI("UIMenu");
    }
}
