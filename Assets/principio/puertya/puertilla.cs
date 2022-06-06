using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Puertilla : MonoBehaviour
{

    public Button puerta;

    void OnEnable()
    {

        puerta.onClick.AddListener(() => buttonCallBack(puerta));

    }
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("sala de espera");
    }
    private void buttonCallBack(Button buttonPressed)
    {
        if (buttonPressed == puerta)
        {

            Debug.Log("INCORRECTO");
            SceneManager.LoadScene("sala de espera");
        }

    }
}

