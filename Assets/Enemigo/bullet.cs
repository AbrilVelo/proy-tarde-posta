using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {
    public float speed = 20f;
    public float lifeTime;
    public ParticleSystem destroyPart;

    void Start()
    {
        Destroy(gameObject, lifeTime);
	}

    private void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;
    }

    private void OnDestroy()
    {
        Instantiate(destroyPart, transform.position, transform.rotation);
    }

    private void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(30);
            Destroy(gameObject);
        }
    }
}
