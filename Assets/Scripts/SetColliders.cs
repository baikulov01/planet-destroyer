using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class SetColliders : MonoBehaviour
{
    public bool setColliders;

    void Update()
    {
        if (setColliders)
        {
            foreach (Transform item in transform)
            {
                if (item.gameObject.GetComponent<MeshCollider>()==null)
                    item.gameObject.AddComponent<MeshCollider>().convex=true;
            }
        }
    }
}
