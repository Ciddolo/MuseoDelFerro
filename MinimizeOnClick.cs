using UnityEngine;

public class MinimizeOnClick : MonoBehaviour
{
    private RaycastHit hit;
    private bool thatsMe;

    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mouse);

        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(castPoint, out hit, 30))
            {
                if (hit.collider.gameObject == gameObject)
                    thatsMe = true;
            }
        }

        if (thatsMe)
            MinimizeMe();
    }
    
    void MinimizeMe()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, Vector3.zero, Time.deltaTime);
        if (transform.localScale.x <= 0.3)
            gameObject.SetActive(false);
    }
}
