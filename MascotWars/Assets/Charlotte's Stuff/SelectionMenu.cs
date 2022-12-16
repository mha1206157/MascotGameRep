using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectionMenu : MonoBehaviour
{
    public GameObject RotateGrizzly;
    public GameObject RotateHickory;

    public void RotateGrizzlySelection()
    {
        RotateGrizzly.SetActive(true);
        RotateHickory.SetActive(false);
        Debug.Log("Yes");
    }
    public void SelectedOne()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void RotateHickorySelection()
    {
        RotateGrizzly.SetActive(false);
        RotateHickory.SetActive(true);
        Debug.Log("yes2");
    }















}