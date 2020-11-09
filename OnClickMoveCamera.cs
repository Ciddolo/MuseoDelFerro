using UnityEngine;

public class OnClickMoveCamera : MonoBehaviour
{
    public Transform FrontPosition;
    public Transform SidePosition;

    private float fraction;
    private float distance;
    private bool goingSide;
    private bool goingFront;

    void Start()
    {
        Camera.main.transform.position = FrontPosition.position;
    }

    void Update()
    {
        if (goingSide)
        {
            fraction += Time.deltaTime;
            Camera.main.transform.position = Vector3.Slerp(FrontPosition.position, SidePosition.position, fraction);
            Camera.main.transform.rotation = Quaternion.Slerp(FrontPosition.rotation, SidePosition.rotation, fraction);

            if (fraction >= 1)
                goingSide = false;
        }        

        if (goingFront)
        {
            fraction += Time.deltaTime;
            Camera.main.transform.position = Vector3.Slerp(SidePosition.position, FrontPosition.position, fraction);
            Camera.main.transform.rotation = Quaternion.Slerp(SidePosition.rotation, FrontPosition.rotation, fraction);

            if (fraction >= 1)
                goingFront = false;
        }
    }

    public void CameraGoSide()
    {
        distance = (Camera.main.transform.position - FrontPosition.transform.position).magnitude;

        if (distance < 0.1f)
        {
            fraction = 0;
            goingSide = true;
        }
    }

    public void CameraGoFront()
    {
        distance = (Camera.main.transform.position - SidePosition.transform.position).magnitude;

        if (distance < 0.1f)
        {
            fraction = 0;
            goingFront = true;
        }
    }
}
