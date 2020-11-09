using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    public GameObject[] ObjectsToForge;
    public GameObject[] Canvas;
    
    private GameObject currentCanvas;
    private int index;
    private bool zoomAndLoad;

    private void Start()
    {
        index = 0;
        currentCanvas = Canvas[index];
        currentCanvas.gameObject.SetActive(true);
    }

    private void Update()
    {
        if (zoomAndLoad)
        {
            Canvas[5].transform.GetChild(0).GetComponent<RectTransform>().localScale = Vector3.Lerp(Canvas[5].transform.GetChild(0).GetComponent<RectTransform>().localScale, new Vector3(2, 2, 2), Time.deltaTime*0.5f);
        }
        if (Canvas[5].transform.GetChild(0).GetComponent<RectTransform>().localScale.x >= 1.9f)
        {
            SceneManager.LoadScene("LevelRiver");
        }
    }

    public void ChooseObjectToForge(int objectToForge)
    {
        GameManager.ObjectChoosed = objectToForge;
        NextPage();
    }

    public void NextPage()
    {
        currentCanvas.gameObject.SetActive(false);
        currentCanvas = Canvas[++index];
        currentCanvas.gameObject.SetActive(true);
    }

    public void LastPage()
    {
        zoomAndLoad = true;
    }

    public void OnPointerEnter(Button button)
    {
        button.transform.localScale = new Vector3(1.2f, 1.2f, 1.2f);
    }

    public void OnPointerExit(Button button)
    {
        button.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

}
