using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    //triggers when pressing the "play" button in the menu scene, loads the obstacle course scene from Unity's scene manager.
    public void OnPlayButton()
    {
        SceneManager.LoadScene(1);
    }
    //triggers when pressing on the "quite" button in the menu scene, it will close the game.
    public void OnQuitButton()
    {
        Application.Quit();
    }
}
