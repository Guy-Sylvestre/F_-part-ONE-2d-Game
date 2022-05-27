using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public float moveSpeed = 8f;
    private float horizontal;
    private float vertical;
    public float diagnolSpeedLimit = 0.7f;

    private Transform body;
    // Start is called before the first frame update
    void Start()
    {
        body = transform;
    }

    // Update is called once per frame
    void Update()
    {
        InputCollection();
        Movement();
    }

    private void InputCollection()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    } 

    private void Movement()
    {
        float horizontalSpeed = horizontal * moveSpeed;
        float verticalSpeed = vertical * moveSpeed;

        if (horizontal != 0 && vertical != 0)
        {
            body.position += new Vector3(horizontalSpeed * diagnolSpeedLimit * Time.deltaTime, verticalSpeed * diagnolSpeedLimit *Time.deltaTime, 0f);
        }
        else
        {
            body.position += new Vector3(horizontalSpeed * Time.deltaTime, verticalSpeed * Time.deltaTime, 0f);
        }
    }
}
