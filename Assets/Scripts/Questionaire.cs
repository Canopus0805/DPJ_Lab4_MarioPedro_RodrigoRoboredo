using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Questionaire : MonoBehaviour
{
    [SerializeField] private QuestionSO questionSO;
    [SerializeField] private TextMeshProUGUI questionText;
    [SerializeField] private int correctAnswerIndex;
    [SerializeField] private GameObject[] buttons;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetNextQuestion();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnAnswerSelected(int index)
    {
        if (index == questionSO.GetCorrectAnswerIndex())
        {
            questionText.text = "Correto";
        }
        else
        {
            int correctAnswerIndex = questionSO.GetCorrectAnswerIndex();
            string correctAnswer = questionSO.GetAnswer(correctAnswerIndex);
            questionText.text = "Incorreto, a resposta certa é," + correctAnswer;
        }
        SetButtonState(false);
    }

    public void DisplayQuestion()
    {
        questionText.text = questionSO.GetQuestion();
        for (int i = 0; i < buttons.Length; i++)
        {
            TextMeshProUGUI text = buttons[i].GetComponentInChildren<TextMeshProUGUI>();
            text.text = questionSO.GetAnswer(i);
        }
    }

    public void SetButtonState(bool state)
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            Button button = buttons[i].GetComponent<Button>();
            button.interactable = state;
        }
    }

    public void GetNextQuestion()
    {
        SetButtonState(true);
        DisplayQuestion();
    }

}
