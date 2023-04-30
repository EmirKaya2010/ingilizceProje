using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class quizManager : MonoBehaviour
{
    public List<MainButton> mainbuttonscriptlist;
    public GameObject[] options;
    public int currentquestion;

    public Text questionsText;

    private void Start()
    {
        generatorQ();
    }
    
    public void correct()
    {
        mainbuttonscriptlist.RemoveAt(currentquestion);
        generatorQ();
    }

    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<Answer>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<Text>().text = mainbuttonscriptlist[currentquestion].answers[i];

            if(mainbuttonscriptlist[currentquestion].correctAnswers == i+1)
            {
                options[i].GetComponent<Answer>().isCorrect = true;
            }
        }
    }

    void generatorQ()
    {
        currentquestion = Random.Range(0,mainbuttonscriptlist.Count);
        questionsText.text = mainbuttonscriptlist[currentquestion].questions;
        SetAnswers();
    }
}
