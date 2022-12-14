using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIQuizResult : MonoBehaviour
{
    [SerializeField] private Button btnConfirm;

    [SerializeField] private TMP_Text txtCount;
    [SerializeField] private TMP_Text txtScore;

    // Start is called before the first frame update
    void Start()
    {
        btnConfirm.onClick.AddListener(()=> {
            gameObject.SetActive(false);
        });

        txtCount.text = $"¸ÂÃá °¹¼ö : {QuizManager.GetInstance().correctCount}";
        txtScore.text = $"Á¡¼ö : {QuizManager.GetInstance().score}";
    }

}
