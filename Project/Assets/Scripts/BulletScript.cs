using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

	public float LifeTime;
	public int Damage;
	public float Speed;
	private float TestTime;
	private Vector3 Direction;
	// Use this for initialization
	void Start () {

	}
	void OnEnable () {
		TestTime = Time.time + LifeTime;
		Direction = GameObject.FindGameObjectWithTag ("Player").transform.up;
		Physics2D.IgnoreCollision (gameObject.collider2D, GameObject.FindGameObjectWithTag ("Player").collider2D);
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > TestTime) {
			this.gameObject.SetActive (false);
		}
		transform.Translate (Direction * Speed);
	}
}
