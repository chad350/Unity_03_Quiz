using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIQuizSelector : MonoBehaviour
{
    [SerializeField] private Button btnSelect1;
    [SerializeField] private Button btnSelect2;

    void Start()
    {
        btnSelect1.onClick.AddListener(()=> {
            OnSelectQuizeList(1);
        });

        btnSelect2.onClick.AddListener(() => {
            OnSelectQuizeList(2);
        });
    }

    void OnSelectQuizeList(int quizListIdx)
    {
        QuizManager.GetInstance().SetQuizList(quizListIdx);
        ScenesManager.GetInstance().ChangeScene(Scene.Quiz);
    }
}
