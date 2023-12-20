using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    float horiMovement;
    float verMovement;
    public float movementSpeed;
    float jumpSpeed;
    float jumpMovement;
    // Start is called before the first frame update
    void Start()
    { 
        //assigns set unit speeds to movement and jumping motions
        movementSpeed = 7;
        jumpSpeed = 10;

    }

    // Update is called once per frame
    void Update()
    {
        //calling axes from the imput manager 
        horiMovement = Input.GetAxis("Horizontal");
        verMovement = Input.GetAxis("Vertical");
        jumpMovement = Input.GetAxis("Jump");

        transform.Translate(0, 0, -horiMovement * Time.deltaTime * movementSpeed);
        transform.Translate(verMovement * Time.deltaTime * movementSpeed, 0, 0);
        transform.Translate(0, jumpMovement * Time.deltaTime * jumpSpeed, 0);
    }
}
