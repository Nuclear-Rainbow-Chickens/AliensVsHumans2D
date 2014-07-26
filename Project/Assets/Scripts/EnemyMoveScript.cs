using UnityEngine;
using System.Collections;

public class EnemyMoveScript : MonoBehaviour {
	public float speed;
	private GameObject player;
	// Use this for initialization
	void Start () {
		player = GameObject.Find ("player");
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float z = Mathf.Atan2((player.transform.position.y - transform.position.y), (player.transform.position.x - transform.position.x)) * Mathf.Rad2Deg - 90;
		transform.eulerAngles = new Vector3 (0, 0, z);
		rigidbody2D.AddForce (transform.up * speed);
	}
}
