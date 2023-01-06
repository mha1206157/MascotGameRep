using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour
{
    public void LoadGame()
    {
    Debug.Log("Works");
        SceneManager.LoadScene("2.1 Character Selection");
    }
}
