using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitScore : MonoBehaviour
{
    //labeling number variable and setting it to 0
    int hits = 0;

    
    void OnCollisionEnter(Collision other)
    {
        //when colliding with an object tagged anything other than "Safe" it will start increasing the variable number and send a message in the Debug.Log.
        if (other.gameObject.tag != "Safe")
        {
            hits++;
            Debug.Log("Ouch! You hit something " + hits + " time(s), be careful!");
        }

    }
    void Update()
    {
        //if the variable reaches to 4, it will load the "lose" menu scene from Unity's scene manager.
        if (hits >= 4)
        {
            SceneManager.LoadScene(2);
        }
    }
}
