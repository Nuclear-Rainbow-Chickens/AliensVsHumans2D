using UnityEngine;
using System.Collections;

public class AISet : MonoBehaviour {

	public float time;
	public float timea;
	void Start () {
	}
	void OnEnable () {
		timea = Time.time + time;
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.time > timea) {
			BeginAI();
			timea = 0;
		}
	}
	public void  BeginAI() {
		GetComponent<AI>().enabled = true;
	}
}
