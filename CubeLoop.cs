using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeLoop : MonoBehaviour
{
    //creating variables and giving them names, and giving a name to the objects rigid body.
    float enemyAspeedA;
    float enemyAspeedB;
    Rigidbody enemyRigidbodyA;
    // Start is called before the first frame update
    void Start()
    {
        //setting unit speeds to the variables and acknowledging the rigid body component connected to the object to the player object can collide with it.
        enemyAspeedA = 8f;
        enemyAspeedB = 8f;
        enemyRigidbodyA = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //objects starts by moving 8 across the x axis times the universal unity speed.
        transform.Translate(enemyAspeedA * Time.deltaTime, 0, 0);

        //if the object is positioned at a unit less than or equal to 131 on the x axis in game, it will set B speed to 8 and A speed to zero, changing the objects movement direction to -8 on the z axis times the universal unity speed.
        if (transform.position.z <= 131f)
        {

            enemyAspeedB = 8f;
            transform.Translate(0, 0, -enemyAspeedB * Time.deltaTime);
            enemyAspeedA = 0f;

        }
        //when the objects position reaches -17.5 on the z axis in game, it will set B speed to 0, set A speed to 8, and position the object where it originally started and it will repeat
        if (transform.position.x <= -17.5)
        {
            enemyAspeedB = 0;
            transform.position = new Vector3(4.3f, 7.9f, 162.4f);
            enemyAspeedA = 8f;

        }

    }
}
