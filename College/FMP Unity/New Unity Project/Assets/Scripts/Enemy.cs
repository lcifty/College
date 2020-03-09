using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float distance;

    public float rotationSpeed;

    private void Start()
    {
        Physics2D.queriesStartInColliders = false;
    }



    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector2.up * rotationSpeed * Time.deltaTime);



        RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, transform.right, distance);
        if (hitInfo.collider != null)
        {
            Debug.DrawLine(transform.position, hitInfo.point, Color.red);

            if (hitInfo.collider.CompareTag("Player")){
                Destroy(hitInfo.collider.gameObject);
            }
        }
        else
        {
            Debug.DrawLine(transform.position, transform.position + transform.right * distance, Color.green);
        }

       
    }




   
}
