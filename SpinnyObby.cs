using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnyObby : MonoBehaviour
{   //creating variable, giving it a name, and setting it so you can modify the speed while in unity.
    [SerializeField] float rotateSpeed;
    // Start is called before the first frame update
    void Start()
    {
        //setting the rotate speed ot 2
        rotateSpeed = 2;
    }

    // Update is called once per frame
    void Update()
    {
        //rotating the object 27 to the right times the set rotate speed times the universal unity speed.
        transform.Rotate(0, 27 * Time.deltaTime * rotateSpeed, 0);
    }
}
