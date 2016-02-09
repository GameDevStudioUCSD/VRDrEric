using UnityEngine;
using System.Collections;

public class ChangeGravity : MonoBehaviour {

    public Vector3 direction = Vector3.down * 9.81f;
    public float speed = 9f;
    //public float 

    Vector3 randDirection = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
    void OnCollisionEnter(Collision collision)
    {
        Physics.gravity = speed * randDirection.normalized;
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(this.gameObject);
        }
    }

    void Update()
    {
        if(transform.position.magnitude > 50)
        {
            Destroy(this.gameObject);
        }
    }
	
}
