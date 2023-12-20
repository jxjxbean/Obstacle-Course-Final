using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //setting a variable and labeling it
    bool isitColliding;

    // Start is called before the first frame update
    void Start()
    {
        //setting the boolean variable to false at the start
        isitColliding = false;
    }

    // Update is called once per frame
    void Update()
    {
        //when the variable is triggered to false by a collision, the object will continuously move 13 to the right times the universal delta time.
        if (isitColliding == false)
        {
            transform.position += new Vector3(13 * Time.deltaTime, 0, 0);
        }

        //when the variable is triggered to true by a collision, the object will continuously move 13 to the left times the universal delta time.
        if (isitColliding == true)
        {
            transform.position += new Vector3(-13 * Time.deltaTime, 0, 0);
        }
    }

    void OnCollisionEnter(Collision other)
    {
        //when the objects connected to the script collides with the object tagged "WallEast" the variable will be triggered to true and will move the object 13 to the left.
        if (other.gameObject.tag == "WallEast")
        {
            isitColliding = true;
            transform.position += new Vector3(0, 0, 0);

        }
        //the variable will trigger to false and will move the object 13 to the right when colling with the object tagged "WallWest" AND the colliding variable is already set to true.
        if(other.gameObject.tag == "WallWest" && isitColliding == true)
        {
            isitColliding=false;
            transform.position += new Vector3(0, 0, 0);
        }
    }
}
