using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenuManager : MonoBehaviour
{
    public Canvas Canvas0;
    public Canvas Canvas1;

    private void Start()
    {
        Canvas0.gameObject.SetActive(true);
        Canvas0.transform.GetChild(GameManager.ObjectChoosed + 1).gameObject.SetActive(true);
    }

    public void NextCanvas()
    {
        Canvas0.gameObject.SetActive(false);
        Canvas1.gameObject.SetActive(true);
    }

    public void Restart()
    {
        GameManager.QuestionIndex = 0;
        GameManager.ObjectChoosed = 0;

        SceneManager.LoadScene("MainMenu");
    }
}
