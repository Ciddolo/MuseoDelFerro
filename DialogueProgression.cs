using UnityEngine;

public class DialogueProgression : MonoBehaviour
{
    public GameObject[] Dialogues;
    public GameObject ClickableObjects, CameraArrows;
    public GameObject ObjToDisable;
    private GameObject currentDialogue;
    private int index;

    private void Start()
    {
        if (ClickableObjects.transform.childCount >= 1)
        {
            for (int i = 0; i < ClickableObjects.transform.childCount; i++)
                ClickableObjects.transform.GetChild(i).gameObject.GetComponent<MinimizeOnClick>().enabled = false;
        }

        if (ObjToDisable)
        {
            ObjToDisable.GetComponent<ClickOnHammer>().enabled = false;
        }

        index = 0;
        currentDialogue = Dialogues[index];
        currentDialogue.gameObject.SetActive(true);
    }

    public void NextDialogue()
    {
        currentDialogue.gameObject.SetActive(false);
        currentDialogue = Dialogues[++index];
        currentDialogue.gameObject.SetActive(true);
    }

    public void LastDialogue()
    {
        currentDialogue.gameObject.SetActive(false);

        if (ClickableObjects.transform.childCount >= 1)
        {
            for (int i = 0; i < ClickableObjects.transform.childCount; i++)
                ClickableObjects.transform.GetChild(i).gameObject.GetComponent<MinimizeOnClick>().enabled = true;
        }

        if (ObjToDisable)
        {
            ObjToDisable.GetComponent<ClickOnHammer>().enabled = true;
        }

        CameraArrows.SetActive(true);
    }
}
