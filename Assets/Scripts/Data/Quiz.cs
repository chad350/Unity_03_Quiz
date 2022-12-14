using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quiz
{
    public string question;

    public int score;

    public int correctAnswerIdx;
    public string[] answerList;

    public Quiz(string question, int score, int correctAnswerIdx, string[] answerList)
    {
        this.question = question;
        this.score = score;
        this.correctAnswerIdx = correctAnswerIdx;
        this.answerList = answerList;
    }
}
