using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WaypointControl : MonoBehaviour {
	public float NumberOfWaypoints;
	public GameObject FirstWaypoint;
	public float Number;
	public GameObject WaypointObject;
	public List<GameObject> WaypointList = new List<GameObject>();
	public bool Found = false;
	public bool scrub = false;
	private Transform self;
	void Start () {
		self = transform;
		for (int i = 0; i < NumberOfWaypoints; i++)
		{
			GameObject temp = (GameObject) Instantiate (WaypointObject, Vector3.zero, Quaternion.identity);
			temp.transform.parent = transform;
			temp.SetActive(false);
			WaypointList.Add (temp);
		}
		FirstWaypoint.SetActive (true);
		FirstWaypoint.GetComponent<AISetF> ().BeginAI ();
	}
	
	// Update is called once per frame
	void Update () {
		Number = WaypointList.Count;
		if(scrub == true) {
			Scrub();

		}
	}
	public void Spawn(Vector2 a, GameObject p) {
		GameObject x;
		foreach (GameObject temp in WaypointList) {
			if(!temp.activeInHierarchy) {
				x = temp;
				x.transform.position = a;
				x.GetComponent<PreviousWaypoint>().Previous = p;
				x.SetActive(true);
				return;
			}
		}
		x = (GameObject)Instantiate (WaypointObject, Vector2.zero, Quaternion.identity);
		WaypointList.Add (x);
		x.transform.position = a;
		x.transform.parent = self;
		x.GetComponent<PreviousWaypoint>().Previous = p;
		x.SetActive (true);
		return;
		
	}
	public void Scrub() {
		foreach(GameObject temp in WaypointList) {
			temp.GetComponent<AI>().enabled = false;
			temp.SetActive(false);
		}
		FirstWaypoint.GetComponent<AI>().enabled = false;
		FirstWaypoint.GetComponent<AISetF> ().BeginAI ();
		GetComponent<FoundControl> ().Directions.Clear ();
		GetComponent<FoundControl> ().DirectionsList.Clear ();
		scrub = false;
	}

		

}


