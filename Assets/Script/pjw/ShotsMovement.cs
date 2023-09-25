using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotsMovement : MonoBehaviour
{
    public float rotationSpeed;
    public static float xRotate, yRotate, xRotateMove, yRotateMove;

    private Rigidbody rb;
    public float moveSpeed, duration, timer;
    private bool isFlying;
    private void Awake()
    {
        rotationSpeed = 50.0f;
        rb = GetComponent<Rigidbody>();
        moveSpeed = 5.0f;
        duration = 10.0f;
        timer = 0.0f;
        isFlying = false;
        xRotate = 70.0f;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isFlying)
        {
            Debug.Log("fly");
            isFlying = true;
            //rb.velocity = transform.forward * rotationSpeed; // 정면으로 발사
            //transform.position += transform.forward * moveSpeed * Time.deltaTime;

        }

        if(isFlying)
        {
            float zMovement;
            float yMovement;

            if(xRotate>=70.0f)
            {
                zMovement = -moveSpeed * Time.deltaTime;
                yMovement = -moveSpeed * Time.deltaTime;
            }
            else
            {
                zMovement = moveSpeed * Time.deltaTime;
                yMovement = moveSpeed * Time.deltaTime;
            }
            

            transform.position += new Vector3(0, yMovement, zMovement);

            timer += Time.deltaTime;

            if(timer >= duration)
            {
                isFlying = false;
            }
        }

        xRotateMove = -Input.GetAxis("Vertical") * Time.deltaTime * rotationSpeed;
        yRotateMove = Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed;

        yRotate = yRotate + yRotateMove;
        xRotate = xRotate + xRotateMove;

        xRotate = Mathf.Clamp(xRotate, -90, 90);

        Quaternion quat = Quaternion.Euler(new Vector3(xRotate, yRotate, 0));

        transform.rotation = Quaternion.Slerp(transform.rotation, quat, Time.deltaTime);


    }
}
