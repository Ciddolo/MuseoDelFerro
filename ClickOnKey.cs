using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickOnKey : MonoBehaviour
{
    public GameObject House;
    public Transform FrontalPos;
    public Transform SidePos;
    public Transform DoorPos;
    
    private RaycastHit hit;
    private bool goingToFront;
    private bool goingToDoor;
    private bool waitForEnter;
    private float fraction;

    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mouse);

        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(castPoint, out hit, 30.0f))
            {
                if (hit.collider.gameObject == gameObject)
                    goingToFront = true;
            }
        }

        if (goingToFront)
        {
            fraction += Time.deltaTime * 0.7f;

            Camera.main.transform.position = Vector3.Slerp(SidePos.position, FrontalPos.position, fraction);
            Camera.main.transform.rotation = Quaternion.Slerp(SidePos.rotation, FrontalPos.rotation, fraction);

            if (fraction >= 1.0f)
            {
                goingToFront = false;
                goingToDoor = true;
                fraction = 0.0f;
            }
        }

        if (goingToDoor)
        {
            fraction += Time.deltaTime;

            Camera.main.transform.position = Vector3.Lerp(FrontalPos.position, DoorPos.position, fraction);
            Camera.main.transform.rotation = Quaternion.Lerp(FrontalPos.rotation, DoorPos.rotation, fraction);

            if (fraction >= 1.0f)
            {
                goingToDoor = false;
                waitForEnter = true;
                fraction = 0.0f;

                House.GetComponent<AudioSource>().Play();
            }
        }

        if (waitForEnter)
        {
            fraction += Time.deltaTime;

            if (fraction >= 2.0f)
                SceneManager.LoadScene("Questions");
        }
    }
}
