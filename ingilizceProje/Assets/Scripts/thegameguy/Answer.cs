using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer : MonoBehaviour
{
    public bool isCorrect = false;
    public quizManager quizmana;

    public void answers()
    {
        if(isCorrect)
        {
            Debug.Log("Correct");
            quizmana.correct();
        }
        else
        {
            Debug.Log("Wrong");
            quizmana.correct();
        }
    }
}
