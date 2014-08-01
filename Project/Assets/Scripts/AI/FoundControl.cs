using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class FoundControl : MonoBehaviour {

	public LinkedList<Vector2> Directions = new LinkedList<Vector2>();
	public List<Vector2> DirectionsList;
	public Transform Waypoint1st;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		try {
			if(Directions.First.Value.Equals((Vector2)Waypoint1st.position)) {
				DirectionsList = new List<Vector2>(Directions);
				for(int i = 0; i < DirectionsList.Capacity - 1; i++) {
					Debug.DrawLine(DirectionsList[i], DirectionsList[i+1]);
				}
			}
		}

		catch (System.ArgumentOutOfRangeException ) {
		}
		catch (System.NullReferenceException ) {
		}
	}
}
