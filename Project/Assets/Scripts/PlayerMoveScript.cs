using UnityEngine;
using System.Collections;
public class PlayerMoveScript : MonoBehaviour {

	public float speed;
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 mouseposition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Quaternion rot = Quaternion.LookRotation(transform.position - mouseposition,Vector3.forward);
		transform.eulerAngles = new Vector3(0,0,rot.eulerAngles.z);
		rigidbody2D.AddForce(transform.up * speed * Input.GetAxis("Vertical"));
	}
}
