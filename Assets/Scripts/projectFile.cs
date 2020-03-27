using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectFile : MonoBehaviour {
	public float speed;
	public float lifeTime;
	public GameObject explosion;

	// Use this for initialization
	void Start () {
		//Destroy (gameObject, lifeTime);
		Invoke ("DestroyProjectile", lifeTime);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector2.up * -speed * Time.deltaTime);
	}

	void DestroyProjectile(){
		Instantiate (explosion, transform.position, Quaternion.identity);
		Destroy (gameObject);
	}
}
