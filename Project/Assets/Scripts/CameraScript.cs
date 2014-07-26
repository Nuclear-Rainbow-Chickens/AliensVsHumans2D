using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {
	private Transform player;
	public float HorizontalMargin;
	public float VerticalMargin;
	public float HorizontalSpeed;
	public float VerticalSpeed;
	private float DistanceX;
	private float DistanceY;
	// Use this for initialization
	void Start () {
		player = GameObject.Find("player").transform;
	}
	
	// Update is called once per frame
	void Update () {
		if(DistanceX > HorizontalMargin)
		{
			rigidbody2D.AddForce(new Vector2(-1,0) * HorizontalSpeed * DistanceX);
		}
		if(DistanceX < -1 * HorizontalMargin)
		{
			rigidbody2D.AddForce(new Vector2(1,0) * HorizontalSpeed * DistanceX * -1);
		}
		if(DistanceY > VerticalMargin)
		{
			rigidbody2D.AddForce(new Vector2(0,-1) * VerticalSpeed * DistanceY);
		}
		if(DistanceY < -1 * VerticalMargin)
		{
			rigidbody2D.AddForce(new Vector2(0,1) * VerticalSpeed * DistanceY * -1);
		}
		DistanceX = transform.position.x - player.position.x;
		DistanceY = transform.position.y - player.position.y;
	}
}
