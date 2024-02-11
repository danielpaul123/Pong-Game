using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public void loadgameplay()
    {
        SceneManager.LoadScene(1);
    }

    public void quitGame()
    {
        Debug.Log("Quitting the game...");

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
    }
}
