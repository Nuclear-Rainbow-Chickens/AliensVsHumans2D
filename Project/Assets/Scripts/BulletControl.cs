using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BulletControl : MonoBehaviour {
	public float NumberOfBullets;
	public GameObject NonStaticBulletObject;
	public static GameObject BulletObject;
	public static List<GameObject> BulletList = new List<GameObject>();
	void Start () {
		BulletObject = NonStaticBulletObject;
		for (int i = 0; i < NumberOfBullets; i++)
		{
			GameObject temp = (GameObject) Instantiate (BulletObject, Vector3.zero, Quaternion.identity);
			temp.SetActive(false);
			BulletList.Add (temp);
		}

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			GameObject bullet = Spawn ();
			bullet.SetActive(true);
			Debug.Log (bullet);
		}

	}
	public static GameObject Spawn() {
		while (true) {
			foreach (GameObject temp in BulletList) {
				if(!temp.activeInHierarchy) {
					return temp;
				}
			} 
			GameObject newtemp = (GameObject) Instantiate (BulletObject, Vector3.zero, Quaternion.identity);
			newtemp.SetActive (false);
			BulletList.Add (newtemp);
			Debug.Log("NOT ENOUGH BULLETS");
			return newtemp;
		}
	}

}


