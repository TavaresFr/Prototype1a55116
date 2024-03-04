using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController: MonoBehaviour
{
    float speed = 25f;
    float turnSpeed = 45f;
    float verticalInput;
    float horizontalInput;
    float jumpInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        jumpInput = Input.GetAxis("Jump");

        if (verticalInput > 0) // Moving forward
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);
        }
        else if (verticalInput < 0) // Moving backward
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);
            transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * -horizontalInput); // Negative for backward turns
        }

        if (jumpInput != 0)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime * jumpInput);
        }
    }
}


//currentPosition = transform.position;
        //currentPosition.z += .05f;
        //transform.position = currentPosition;

        //transform.Translate(0, 0, .05f);

        //Move o veiculo para a frente continuamente
        //transform.Translate(Vector3.forward * speed * Time.deltaTime); // (0,0,1)