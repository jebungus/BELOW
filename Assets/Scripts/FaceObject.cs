using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaceObject : MonoBehaviour
{
    public GameObject objectToFace;


    // Update is called once per frame
    private void LateUpdate()
    {
        Vector3 objPos = objectToFace.transform.position;
        transform.LookAt(objPos);
        transform.Rotate(0f, 180f, 0f); // Rotate the object 180 degrees around the Y-axis
    }
}
