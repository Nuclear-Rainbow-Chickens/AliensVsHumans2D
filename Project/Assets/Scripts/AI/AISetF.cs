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

	public void  BeginAI() {
		GetComponent<AI>().enabled = true;
	}
}
