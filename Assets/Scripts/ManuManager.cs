using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ManuManager : MonoBehaviour
{
    public string theName;
    public GameObject inputField;
    public GameObject textDisplay;
    public GameObject ScoreText;




    public void StoreName()
    {
        theName = inputField.GetComponent<TextMeshProUGUI>().text;
        textDisplay.GetComponent<TextMeshProUGUI>().text = "wellcom" + " " + theName;
    }



    public void StartButton()
    {
        SceneManager.LoadScene(1);
    }

    
    public void QuitButton()
    {
        Application.Quit();  
    }
}
