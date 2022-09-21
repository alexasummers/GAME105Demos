using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Vector3 _movement;
    private CharacterController controller;
    private float moveX = 0;
    private float moveZ = 0;
    public float playerMovementSpeed = 30;
    private Vector3 rotationX1;
    private Vector3 rotationX2;
    private Vector3 rotationZ1;
    private Vector3 rotationZ2;


  
    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        moveX = Input.GetAxis("Horizontal") / playerMovementSpeed;
        moveZ = Input.GetAxis("Vertical") / playerMovementSpeed;
        _movement = new Vector3(moveX, 0, moveZ);
        controller.Move(_movement);

        rotationX1 = new Vector3(-90, 0, 0);
        rotationX2 = new Vector3(90, 0, 0);
        rotationZ1 = new Vector3(0, 0, -90);
        rotationZ2 = new Vector3(0, 0, 90);

        if(moveX < 0)
        {
            transform.LookAt(rotationX1);
        }

        if(moveX > 0)
        {
            transform.LookAt(rotationX2);
        }

        if(moveZ < 0)
        {
            transform.LookAt(rotationZ1);
        }

        if(moveZ > 0)
        {
            transform.LookAt(rotationZ2);
        }

    }
}
