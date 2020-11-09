using UnityEngine;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour
{
    public Button RightButton;
    public Image GreenBar;

    private float time;
    private float waitTime;
    private bool goToNext;
    private GameObject[] wrongButtons;

    void Start()
    {


        wrongButtons = new GameObject[3];

        time = 1;
        int n = 0;

        for (int i = 1; i < wrongButtons.Length + 2; i++)
        {
            if (transform.GetChild(i).GetComponent<Button>().onClick.GetPersistentMethodName(0) == "WrongAnswer")
            {
                wrongButtons[n] = transform.GetChild(i).gameObject;
                n++;
            }
        }
    }

    void Update()
    {
        if (!goToNext && GreenBar)
            ScaleTimeBar();
        else
            WaitForASec();
    }

    public void WrongAnswer(Button answer)
    {
        answer.GetComponent<Button>().interactable = false;
    }

    public void RightAnswer(Button answer)
    {
        answer.GetComponent<Button>().interactable = false;

        for (int i = 0; i < wrongButtons.Length; i++)
        {
            wrongButtons[i].GetComponent<Button>().enabled = false;

            if (wrongButtons[i].GetComponent<Button>().interactable == false)
                wrongButtons[i].GetComponent<Image>().color = new Vector4(1, 0, 0, 1f);
        }

        goToNext = true;
    }

    public void ScaleTimeBar()
    {
        time -= Time.deltaTime / 45;

        if (time <= 0)
        {
            time = 0;
            RightAnswer(RightButton);
        }

        GreenBar.fillAmount = time;
    }

    void WaitForASec()
    {
        waitTime += Time.deltaTime;

        if (waitTime >= 2)
            transform.parent.GetComponent<ChooseQuestions>().NextQuestion();
    }
}
