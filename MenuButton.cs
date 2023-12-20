using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    //Menu button on the corner of the screen while playing and whe pressed, it will load the the start menu screen from unity's scene manager.
    public void OnPlayButton()
    {
        SceneManager.LoadScene(0);
    }

}
