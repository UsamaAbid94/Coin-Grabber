using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public GameObject targetObject; //Camera will follow this object

    public Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(targetObject.transform.position);
        Quaternion.LookRotation(targetObject.transform.position);
        transform.position = targetObject.transform.position + offset;
        
    }
}
