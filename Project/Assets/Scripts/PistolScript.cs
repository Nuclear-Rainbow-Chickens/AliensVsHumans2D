using UnityEngine;
using System.Collections;

public class PistolScript : MonoBehaviour {
	public float FireRate;
	public int Damage;
	public float BulletSpeed;
	private float FireTime;
	private GameObject GunPosition;
	// Use this for initialization
	void Start () {
		FireTime = Time.time + FireRate;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton(0)) {
			Fire ();
		}
		GunPosition = GameObject.FindGameObjectWithTag ("GunPosition");
	}

	void Fire() {
		if (Time.time > FireTime) {
			GameObject temp = BulletControl.Spawn ();
			temp.GetComponent<BulletScript>().Damage = Damage;
			temp.GetComponent<BulletScript>().Speed = BulletSpeed;
			temp.transform.position = GunPosition.transform.position;
			temp.SetActive(true);
			FireTime = Time.time + FireRate;
		}
	}
}
