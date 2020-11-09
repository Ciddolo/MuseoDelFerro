using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickOnCoal : MonoBehaviour
{
    RaycastHit hit;

    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mouse);

        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(castPoint, out hit, 30))
            {
                if (hit.collider.gameObject == gameObject)
                    SceneManager.LoadScene("Questions");
            }
        }
    }
}
