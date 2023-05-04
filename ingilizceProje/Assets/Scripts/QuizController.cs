using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO;

public class QuizController : MonoBehaviour {

    public Text questionText;
    public Text scoreText;
    public Button[] optionButtons;

    private Question[] questions;
    private int currentQuestionIndex;
    private int score;

    private class Question {
        public string question;
        public string[] options;
        public int answerIndex;
    }

    void Start () {
        LoadQuestions();
        ShowQuestion();
    }

    void LoadQuestions () {
        string filePath = Application.streamingAssetsPath + "/questions.txt";
        string[] lines = File.ReadAllLines(filePath);

        int numQuestions = lines.Length / 6;
        questions = new Question[numQuestions];

        for (int i = 0; i < numQuestions; i++) {
            questions[i] = new Question();
            questions[i].question = lines[i * 6];
            questions[i].options = new string[4];
            for (int j = 0; j < 4; j++) {
                questions[i].options[j] = lines[i * 6 + j + 1];
            }
            questions[i].answerIndex = int.Parse(lines[i * 6 + 5]);
        }
    }

    void ShowQuestion () {
        Question question = questions[currentQuestionIndex];

        questionText.text = question.question;
        for (int i = 0; i < 4; i++) {
            optionButtons[i].GetComponentInChildren<Text>().text = question.options[i];
        }
    }

    public void AnswerQuestion (int answerIndex) {
        Question question = questions[currentQuestionIndex];
        if (answerIndex == question.answerIndex) {
            score++;
        }

        currentQuestionIndex++;
        if (currentQuestionIndex >= questions.Length) {
            EndQuiz();
        } else {
            ShowQuestion();
        }
    }

    void EndQuiz () {
        questionText.text = "Quiz completed. Score: " + score;
        scoreText.gameObject.SetActive(false);
        foreach (Button button in optionButtons) {
            button.gameObject.SetActive(false);
        }
    }
}