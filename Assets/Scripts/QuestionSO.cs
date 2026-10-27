using UnityEngine;
using UnityEngine.InputSystem.XR;

[CreateAssetMenu(fileName = "New Question", menuName = "Question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2,5)]
    [SerializeField] private string question = "Pergunta";
    [SerializeField] private string[] answers = new string[4];
    [SerializeField] private int correctAnswer;

    public string GetQuestion()
    {
        return question;
    }
    public int GetCorrectAnswerIndex()
    {
        return correctAnswer;
    }
    public string GetAnswer(int index)
    {
        return answers[index];
    }
    
}
