using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickOnIron : MonoBehaviour
{
    RaycastHit hit;
    public GameObject dialogIron, Question;

    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mouse);

        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(castPoint, out hit, 30))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    
                    if (GameManager.HaveHammer)
                    {
                        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
                        GameManager.HaveHammer = false;
                        Question.SetActive(true);
                        gameObject.SetActive(false);
                    }
                    else
                    {
                        dialogIron.SetActive(true);
                    }
                }
            }
        }
    }


    public void disableDialogueIron()
    {
        dialogIron.SetActive(false);
    }
}
