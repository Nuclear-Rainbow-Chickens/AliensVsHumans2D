using UnityEngine;
using System.Collections;

public class IgnoreScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Physics2D.IgnoreCollision(collider2D, GameObject.FindGameObjectWithTag("Player").collider2D);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
