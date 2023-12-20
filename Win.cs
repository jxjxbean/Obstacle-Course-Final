using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    //when player collides with the object tagged "Door" it will load the "Win" menu scene from Unity's scene manager.
    void OnCollisionEnter(Collision Door)
    {
        SceneManager.LoadScene(3);
    }
}
