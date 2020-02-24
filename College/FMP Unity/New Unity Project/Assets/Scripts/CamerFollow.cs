using UnityEngine;
using System.Collections;
using System.Collections.Generic;

//Camera Follow.
public class CamerFollow : MonoBehaviour
{
  public Transform target;

  public float smoothSpeed = 0.125f;
  
  //Delay For Smooth Scrolling.
  public Vector3 offset;

    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }

}
