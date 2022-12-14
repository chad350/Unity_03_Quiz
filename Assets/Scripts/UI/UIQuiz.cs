using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIQuiz : MonoBehaviour
{
    [SerializeField] private TMP_Text txtQuiz;

    [SerializeField] private Button[] btnAnswers;
    [SerializeField] private TMP_Text[] txtAnswers;

    int quizIdx;

    Quiz[] quizList;

    void Start()
    {
        for (int i = 0; i < btnAnswers.Length; i++)
        {
            int curIdx = i;
            btnAnswers[curIdx].onClick.AddListener(()=> {
                OnAswer(curIdx);
            });
        }
        
        StartQuiz();        
    }

    private void StartQuiz()
    {
        QuizManager.GetInstance().correctCount = 0;
        QuizManager.GetInstance().score = 0;

        quizList = QuizManager.GetInstance().GetQuizList();
        quizIdx = 0;        

        RefreshUI();
    }

    private void NextQuiz()
    {
        quizIdx++;
        if (quizList.Length > quizIdx)
        {
            RefreshUI();
        }
        else
        {
            ScenesManager.GetInstance().ChangeScene(Scene.Main);
        }        
    }

    private void RefreshUI()
    {
        txtQuiz.text = quizList[quizIdx].question;
        for (int i = 0; i < btnAnswers.Length; i++)
        {
            if (quizList[quizIdx].answerList.Length > i)
            {
                btnAnswers[i].gameObject.SetActive(true);
                txtAnswers[i].text = quizList[quizIdx].answerList[i];
            }
            else
            {
                btnAnswers[i].gameObject.SetActive(false);
            }
        } 
    }

    private void OnAswer(int idx)
    {
        if (quizList[quizIdx].correctAnswerIdx == idx)
        {
            QuizManager.GetInstance().correctCount++;
            QuizManager.GetInstance().score += quizList[quizIdx].score;
        }
        
        NextQuiz();
    }
}
