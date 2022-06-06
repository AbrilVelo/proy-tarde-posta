using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {

    public Transform follow;
    public float followspeed;
    float Zpos;
    public float YOffset;
    public float XOffset;

	void Start () {
        if (!follow)
            Destroy(gameObject);
        Zpos = transform.position.z;
	}
	
	void Update ()
    {
		if(Vector2.Distance(transform.position, follow.position) > 0.01f)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(follow.position.x + XOffset, follow.position.y + YOffset, Zpos), Time.deltaTime * followspeed);
        }
        else
        {
            transform.position = new Vector3(follow.position.x + XOffset, follow.position.y + YOffset, Zpos);
        }
	}
}
