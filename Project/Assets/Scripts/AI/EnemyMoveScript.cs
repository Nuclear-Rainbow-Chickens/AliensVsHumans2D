using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyMoveScript : MonoBehaviour {

	public GameObject Waypoint_Control;
	public Vector2 Next;
	public float Speed;
	public float NextSearch;
	public List<Vector2> Directions;
	public int a = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		StartCoroutine ("Move");
		Directions = Waypoint_Control.GetComponent<FoundControl> ().DirectionsList;
	}
	IEnumerator Move() {
		while(Directions.Count > 0) {
			try {
				transform.position = Directions[1];
			}
			catch(System.ArgumentOutOfRangeException) {
			}
			yield return new WaitForSeconds(NextSearch);
			Waypoint_Control.GetComponent<WaypointControl>().Scrub();
			Debug.Log("Scrubbed");

		}
	}
}
