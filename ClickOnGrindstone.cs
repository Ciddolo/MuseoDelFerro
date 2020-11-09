using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClickOnGrindstone : MonoBehaviour
{
    private float waitTime;
    private bool goToNext;

    private void Update()
    {
        if (goToNext)
        {
            WaitForASec();
        }
    }

    public void GoToQuestions(Button answer)
    {
        answer.GetComponent<Button>().interactable = false;
        goToNext = true;
    }

    void WaitForASec()
    {
        waitTime += Time.deltaTime;

        if (waitTime >= 2)
            SceneManager.LoadScene("Questions");
    }

}
