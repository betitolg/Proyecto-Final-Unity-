using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField]
    [Range(1f, 10f)]
    private float speed = 3f;
    private float cameraAxisX = 0f;
    void Start()
    {
    
    }
 
    // Update is called once per frame
    void Update()
    {
        MovePlayer(Vector3.forward);
        
        RotatePlayer();
        if (Input.GetKey(KeyCode.W))
        {
            MovePlayer(Vector3.forward);
        }

        if (Input.GetKey(KeyCode.S))
        {
            MovePlayer(Vector3.back);
        }

        if (Input.GetKey(KeyCode.A))
        {
            MovePlayer(Vector3.left);
        }

        if (Input.GetKey(KeyCode.D))
        {
            MovePlayer(Vector3.right);
        }
    }
    private void MovePlayer(Vector3 direction)
    {
        transform.Translate(direction * (speed * Time.deltaTime));
    }

    private void RotatePlayer()
    {
 
       
        cameraAxisX += Input.GetAxis("Mouse X");
        
        Quaternion newRotation = Quaternion.Euler(0, cameraAxisX, 0);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, 2.5f * Time.deltaTime);
    }
}
