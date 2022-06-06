using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class McPatogeno : MonoBehaviour {

    public GameObject TextBox;
   
    public Button incorrecto;
    public Button incorrecto2;
    public Button correcto;
    public Button incorrecto3;
    

    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("Incorrecto");

    }    

 
    void OnEnable()
    {
        //Register Button Events
        incorrecto.onClick.AddListener(() => buttonCallBack(incorrecto));
        incorrecto2.onClick.AddListener(() => buttonCallBack(incorrecto2));
        correcto.onClick.AddListener(() => buttonCallBack(correcto));
        incorrecto3.onClick.AddListener(() => buttonCallBack(incorrecto3));

	}



    private void buttonCallBack(Button buttonPressed)
    {
        if (buttonPressed == incorrecto)
        {
           
            Debug.Log("INCORRECTO");
            SceneManager.LoadScene("Incorrecto");
        }

        if (buttonPressed == incorrecto2)
        {
           
            Debug.Log("CORRECTO");
        }

        if (buttonPressed == correcto)
        {
           
            Debug.Log("INCORRECTO");
            SceneManager.LoadScene("Incorrecto");
        }

        if (buttonPressed == incorrecto3)
        {
            SceneManager.LoadScene("Incorrecto");
            Debug.Log("INCORRECTO");
        }
    }

	}

 
        