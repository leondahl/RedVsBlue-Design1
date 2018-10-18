using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{	
    void OnClickMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    void OnClickLevel()
    {
        SceneManager.LoadScene("Level_1");
    }
    void OnClickExit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit;
#endif
    }
}
