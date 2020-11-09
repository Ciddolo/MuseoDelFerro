using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseQuestions : MonoBehaviour
{
    GameObject currentQuestion;

    void Start()
    {
        currentQuestion = transform.GetChild(GameManager.QuestionIndex).gameObject;
        currentQuestion.gameObject.SetActive(true);
    }

    public void NextQuestion()
    {
        currentQuestion.gameObject.SetActive(false);
        GameManager.QuestionIndex++;

        if (GameManager.QuestionIndex == 3)
            SceneManager.LoadScene("LevelMillGarden1");
        else if (GameManager.QuestionIndex == 7)
            SceneManager.LoadScene("LevelMillGarden2");
        else if (GameManager.QuestionIndex == 8)
            SceneManager.LoadScene("LevelForge1");
        else if (GameManager.QuestionIndex == 10)
            SceneManager.LoadScene("LevelForge2");
        else if (GameManager.QuestionIndex == 11)
            SceneManager.LoadScene("LevelForge3");
        else if (GameManager.QuestionIndex == 12)
            SceneManager.LoadScene("LevelForgeQuestion");
        else if (GameManager.QuestionIndex == transform.childCount)
            SceneManager.LoadScene("EndMenu");
        else
        {
            currentQuestion = transform.GetChild(GameManager.QuestionIndex).gameObject;
            currentQuestion.gameObject.SetActive(true);
        }
    }
}
