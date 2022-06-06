using UnityEngine;
using UnityEngine.SceneManagement;
public class cambia_escena : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
        SceneManager.LoadScene("Perdiste");

    }
}
