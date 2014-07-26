using UnityEngine;
using System.Collections;
public class GunControl : MonoBehaviour {

	public int Selected = 0;
	public float Sensitivity;
	MonoBehaviour[] GunList = new MonoBehaviour[2];
	// Use this for initialization
	void Start () {
		GunList[0] = GetComponent<PistolScript> ();
		GunList[1] = GetComponent<MachineGunScript> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			Weapon(0);
		}
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			Weapon(1);
		}
	}

	void Weapon(int a) {
		for(int i = 0; i < GunList.Length; i++) {
			if( i == a) {
				GunList[i].enabled = true;
			}
			else {
				GunList[i].enabled = false;
			}
		}
	}
}
