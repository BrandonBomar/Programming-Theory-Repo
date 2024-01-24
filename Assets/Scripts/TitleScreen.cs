using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class TitleScreen : MonoBehaviour
{
    // Title Screen Components
    public GameObject startButton;
    public GameObject exitButton;
    public GameObject titleText;
    public GameObject transparentScreen;

    // Game Screen Components
    public GameObject inheritanceButton;
    public GameObject abstractionButton;
    public GameObject polymorphismButton;
    public GameObject encapsulationButton;
    public GameObject overviewButton;
    public GameObject backButton;

    // Start is called before the first frame update
    void Start()
    {   
        startButton.SetActive(true);
        exitButton.SetActive(true);
        titleText.SetActive(true);
        transparentScreen.SetActive(true);

        inheritanceButton.SetActive(false);
        abstractionButton.SetActive(false);
        polymorphismButton.SetActive(false);
        encapsulationButton.SetActive(false);
        overviewButton.SetActive(false);
        backButton.SetActive(false);
    }

    public void StartNew()
    {
        startButton.SetActive(false);
        exitButton.SetActive(false);
        titleText.SetActive(false);
        transparentScreen.SetActive(false);

        inheritanceButton.SetActive(true);
        abstractionButton.SetActive(true);
        polymorphismButton.SetActive(true);
        encapsulationButton.SetActive(true);
        overviewButton.SetActive(true);
        backButton.SetActive(true);
    }
    
    public void Exit()
    {
        #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
        #else
        Application.Quit();
        #endif
    }

    public void Back()
    {
        startButton.SetActive(true);
        exitButton.SetActive(true);
        titleText.SetActive(true);
        transparentScreen.SetActive(true);

        inheritanceButton.SetActive(false);
        abstractionButton.SetActive(false);
        polymorphismButton.SetActive(false);
        encapsulationButton.SetActive(false);
        overviewButton.SetActive(false);
        backButton.SetActive(false);
    }
}
