using UnityEngine;
using System.Collections;

public class Cannon : MonoBehaviour {


    public GameObject objectToFire;
    public float timeBetweenFires;
    public float firingForce = 10;

    private float lastFireTime;

	void Start () {
        lastFireTime = Time.time;
	}
	
	void Update () {
        if(Time.time - lastFireTime > timeBetweenFires)
        {
            CreateNewBullet();
            lastFireTime = Time.time;
        }
	}

    void CreateNewBullet()
    {
        GameObject currentInstance = (GameObject)GameObject.Instantiate(objectToFire, transform.position, transform.rotation);
        Rigidbody instanceRB = currentInstance.AddComponent<Rigidbody>();
        Vector3 instanceFiringForce = firingForce * transform.forward.normalized;
        instanceRB.AddForce(instanceFiringForce, ForceMode.Impulse);
    }
}
