using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    public void BackToMenu()
    {
        Debug.Log("BackToMenu was pressed");

        SceneManager.LoadScene("MainMenu");
    }
}
