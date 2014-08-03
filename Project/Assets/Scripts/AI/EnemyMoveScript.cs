using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyMoveScript : MonoBehaviour {

	public GameObject Waypoint_Control;
	public Transform Goal;
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
				if(Vector2.Distance(transform.position, Directions[1]) > 0.5) {
					transform.position = Vector2.MoveTowards(transform.position, Directions[1], Speed * Time.time);
					continue;
				}
				else {
					Debug.Log("next");
				}
			}
			catch(System.ArgumentOutOfRangeException) {
			}

			yield return new WaitForSeconds(NextSearch);
			Waypoint_Control.GetComponent<WaypointControl>().Scrub();
			Debug.Log("Scrubbed");


		}
	}
}
