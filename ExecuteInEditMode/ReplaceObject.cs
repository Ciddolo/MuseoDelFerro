using UnityEngine;

[ExecuteInEditMode]

public class ReplaceObject : MonoBehaviour
{
    public GameObject[] Prefabs;

    public bool Replace;

    private Vector3[] positions;
    private int n;

    void Update()
    {

        if (Replace)
        {
            GetPositions();
            DestroyAllChild();
            InstanciateNewObjects();

            Replace = false;
        }
    }

    private void GetPositions()
    {
        n = transform.childCount;

        positions = new Vector3[n];

        for (int i = 0; i < n; i++)
            positions[i] = transform.GetChild(i).transform.position;
    }

    private void DestroyAllChild()
    {
        for (int i = 0; i < n; i++)
            DestroyImmediate(transform.GetChild(0).gameObject);
    }

    private void InstanciateNewObjects()
    {
        for (int i = 0; i < n; i++)
        {
            GameObject currentObject = Instantiate(Prefabs[Random.Range(0, Prefabs.Length)], transform);
            currentObject.transform.Rotate(Vector3.up * Random.Range(0, 361));
            currentObject.transform.position = positions[i];
        }
    }
}
