using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class creador_bichos : MonoBehaviour
{

    public GameObject EnemigoPrefab;
    public Transform[] spawnPos;
    public int cantEnemigosWave = 5;
    int CurrentWave = 0;
    int FinalWave = 4;
    float currentRestTime = 0;
    public float restTime;

    void Update()
    {
        var enemiesInScene = FindObjectsOfType<Enemy>();
        if (enemiesInScene.Length == 0)
        {
            currentRestTime += Time.deltaTime;
            if(currentRestTime > restTime)
            {
                for (int i = 0; i < cantEnemigosWave; i++)
                {
                    Create();
                }
                currentRestTime = 0;
                CurrentWave ++;
                cantEnemigosWave += Mathf.RoundToInt(cantEnemigosWave / 2);
            }
        }
        else if (CurrentWave == FinalWave)
        {
            destruir();
            SceneManager.LoadScene("Ganaste");
        }

    }

    void Create()
    {
        float y = Random.Range(spawnPos[0].position.y, spawnPos[1].position.y);
        float x = Random.Range(spawnPos[0].position.x, spawnPos[1].position.x);
        Vector3 posicion = new Vector3(x, y);
        Instantiate(EnemigoPrefab, posicion, Quaternion.identity);
    }
    void destruir ()
    {
        Destroy(gameObject);
    }
}
