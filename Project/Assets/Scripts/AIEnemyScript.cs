using UnityEngine;
using System.Collections;
using AggregatGames.AI.Pathfinding;

public class AIEnemyScript : MonoBehaviour {

	Pathfinder pathfinder;
	PathKnot[] knots;
	int knotIndex = -1;
	Vector3 start;
	public Transform end;

	// Use this for initialization
	void Start () {
		enemy = GetComponent (Pathfinder);
		start = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		}
	void Search(Transform target) {
		if (knotIndex == -1 || knots == null || pathfinder.target != target.position) {
			pathfinder.findPath(transform.position, target.position,Walk();
		}
		else if (knotIndex != -3 && knotIndex != -2) {
			
	}
	public void Walk(Pathinfo info){
		if(info.foundPath) {
			knots = pathfinder.getPath();
			knotIndex = 0;
		}
	}


}
