using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pasarsala : MonoBehaviour {




    AudioSource fuenteAudio;
    private void Start()
    {
        fuenteAudio = GetComponent<AudioSource>();
    }

    public void PlayGame()
    {
        fuenteAudio.mute = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
       
    }


}
