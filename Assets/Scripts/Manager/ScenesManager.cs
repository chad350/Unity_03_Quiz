using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum Scene
{
    Quiz,
    Menu,
    Main,    
}

public class ScenesManager : MonoBehaviour
{
    #region Singletone
    private static ScenesManager instance = null;

    public static ScenesManager GetInstance()
    {
        if (instance == null)
        {
            GameObject go = new GameObject("@ScenesManager");
            instance = go.AddComponent<ScenesManager>();

            DontDestroyOnLoad(go);
        }

        return instance;
    }
    #endregion

    #region Scene Control
    public Scene currentScene = Scene.Menu;
    public Scene prevScene = Scene.Menu;

    public void ChangeScene(Scene scene)
    {
        UIManager.GetInstance().ClearList();

        prevScene = currentScene;
        currentScene = scene;        
        SceneManager.LoadScene(scene.ToString());        
    }
    #endregion
}
