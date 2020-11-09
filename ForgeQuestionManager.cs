using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ForgeQuestionManager : MonoBehaviour
{
    private float waitTime;
    private bool goToNext;

    // Update is called once per frame
    void Update()
    {
        if (goToNext)
        {
            WaitForASec();
        }
    }

    void WaitForASec()
    {
        waitTime += Time.deltaTime;

        if (waitTime >= 2)
            SceneManager.LoadScene("Questions");
    }

    public void RightAnswer(Button answer)
    {
        answer.GetComponent<Button>().interactable = false;
        goToNext = true;
    }

    public void WrongAnswer(Button answer)
    {
        answer.GetComponent<Button>().interactable = false;
    }
}
