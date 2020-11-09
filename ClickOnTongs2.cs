using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ClickOnTongs2 : MonoBehaviour
{
    RaycastHit hit;
    public Texture2D text;

    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mouse);

        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(castPoint, out hit, 30))
            
                if (hit.collider.gameObject == gameObject)
                    GameManager.HaveTongs = true;
            
        }

        if (GameManager.HaveTongs)
        {
            Cursor.SetCursor(text, new Vector2(30,80), CursorMode.ForceSoftware);
            gameObject.SetActive(false);
        }
    }
}
