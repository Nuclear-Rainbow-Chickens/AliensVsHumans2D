using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class AI : MonoBehaviour {
	GameObject Waypoint;
	public GameObject Waypoint_Control;
	public bool DrawGizmos = false;
	public bool IFound = false;
	public const float RAY_DISTANCE = 1f;
	Vector2 Up = new Vector2(0, RAY_DISTANCE * 2);
	Vector2 Down = new Vector2(0,-RAY_DISTANCE * 2);
	Vector2 Left = new Vector2(-RAY_DISTANCE * 2, 0);
	Vector2 Right = new Vector2(RAY_DISTANCE * 2,0);
	// Use this for initialization
	void Start () {
		Physics2D.IgnoreCollision(collider2D, GameObject.FindGameObjectWithTag("Player").collider2D);

	}
	void OnEnable () {
		Search (gameObject.transform);
		Physics2D.IgnoreCollision(collider2D, GameObject.FindGameObjectWithTag("Player").collider2D);

	}
	
	// Update is called once per frame
	void Update () {
		RaycastHit2D hitup = Physics2D.Raycast (transform.position, Up, RAY_DISTANCE);
		try {
			string test = hitup.collider.gameObject.tag;
			if(test == "Player" && Vector2.Distance(hitup.point, transform.position) < 0.6) {
				Waypoint_Control.GetComponent<FoundControl>().Directions.Clear();
				Report();
			}

		}
		catch (System.NullReferenceException) {}
		
		RaycastHit2D hitdown = Physics2D.Raycast (transform.position, Down, RAY_DISTANCE);
		try {
			string test = hitdown.collider.gameObject.tag;
			if(test == "Player" && Vector2.Distance(hitup.point, transform.position) < 0.6) {
				Waypoint_Control.GetComponent<FoundControl>().Directions.Clear();
				Report();
			}
			
		}
		catch (System.NullReferenceException) {}
		
		RaycastHit2D hitleft = Physics2D.Raycast (transform.position, Left, RAY_DISTANCE);
		try {
			string test = hitleft.collider.gameObject.tag;
			if(test == "Player" && Vector2.Distance(hitup.point, transform.position) < 0.6) {
				Waypoint_Control.GetComponent<FoundControl>().Directions.Clear();
				Report();
			}
			
		}
		catch (System.NullReferenceException ) 	{}
		
		RaycastHit2D hitright = Physics2D.Raycast (transform.position, Right, RAY_DISTANCE);
		try {
			string test = hitright.collider.gameObject.tag;
			if(test == "Player" && Vector2.Distance(hitup.point, transform.position) < 0.6) {
				Waypoint_Control.GetComponent<FoundControl>().Directions.Clear();
				Report();
			}
			
		}
		catch (System.NullReferenceException) {}
		
	}
	void OnDrawGizmos() {
		if(DrawGizmos == true) {
			Gizmos.color = Color.blue;
			Gizmos.DrawLine(transform.position, (Vector2)transform.position + (Vector2.right * RAY_DISTANCE));
			Gizmos.DrawLine(transform.position, (Vector2)transform.position + (Vector2.right * -RAY_DISTANCE));
			Gizmos.DrawLine(transform.position, (Vector2)transform.position + (Vector2.up * RAY_DISTANCE));
			Gizmos.DrawLine(transform.position, (Vector2)transform.position + (Vector2.up * -RAY_DISTANCE));
			if(IFound == true) {
				Gizmos.color = Color.red;
				Gizmos.DrawSphere(transform.position, 0.9f);
			}
		}
	}
	public void Search(Transform a) {
		if(Waypoint_Control.GetComponent<WaypointControl>().Found == false) {
		collider2D.enabled = false;
		

		RaycastHit2D hitup = Physics2D.Raycast (transform.position, Up, RAY_DISTANCE);
			try {
				string test = hitup.collider.gameObject.tag;
			}
			catch (System.NullReferenceException) {
				Waypoint_Control.GetComponent<WaypointControl>().Spawn((Vector2)transform.position + Up,gameObject);
			}

			RaycastHit2D hitdown = Physics2D.Raycast (transform.position, Down, RAY_DISTANCE);
			try {
				string test = hitdown.collider.gameObject.tag;
			}
			catch (System.NullReferenceException) {
				Waypoint_Control.GetComponent<WaypointControl>().Spawn((Vector2)transform.position + Down,gameObject);

			}
		
			RaycastHit2D hitleft = Physics2D.Raycast (transform.position, Left, RAY_DISTANCE);
			try {
				string test = hitleft.collider.gameObject.tag;
			}
			catch (System.NullReferenceException) {
				Waypoint_Control.GetComponent<WaypointControl>().Spawn((Vector2)transform.position + Left,gameObject);
			}

			RaycastHit2D hitright = Physics2D.Raycast (transform.position, Right, RAY_DISTANCE);
			try {
				string test = hitright.collider.gameObject.tag;
				Debug.Log(test);


			}
			catch (System.NullReferenceException) {
				Waypoint_Control.GetComponent<WaypointControl>().Spawn((Vector2)transform.position + Right,gameObject);
			}
			collider2D.enabled = true;
		}

	}


	void Report() {
		Waypoint_Control.GetComponent<FoundControl>().Directions.AddFirst ((Vector2)transform.position);
		try {
			GetComponent<PreviousWaypoint> ().Previous.GetComponent<AI> ().Report ();
		}
		catch (System.NullReferenceException ) {}

	}
}
