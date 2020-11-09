using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickOnIngots : MonoBehaviour
{
    RaycastHit hit;
    public GameObject dialogIron;

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
                    if (GameManager.HaveTongs)
                    {
                        Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
                        GameManager.HaveTongs = false;
                        SceneManager.LoadScene("Questions");

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
