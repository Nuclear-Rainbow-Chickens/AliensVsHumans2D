using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class AISetF : MonoBehaviour {

	public GameObject Waypoint_Control;
	public List<Vector2> WayList;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnDrawGizmos () {
		Gizmos.color = Color.red;
		Gizmos.DrawSphere (transform.position, 0.9f);
	}
	public void  BeginAI() {
		GetComponent<AI>().enabled = true;
	}
}
