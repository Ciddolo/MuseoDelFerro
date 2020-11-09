using UnityEngine;

[ExecuteInEditMode]
public class Renaminator : MonoBehaviour
{
    public bool Rename;
    public string Name;

    void Update()
    {
        if (Rename)
        {
            int childCount = transform.childCount;

            for (int i = 0; i < childCount; i++)
                transform.GetChild(i).gameObject.name = Name + i;

            Rename = false;
        }
    }
}
