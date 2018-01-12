using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldController : MonoBehaviour
{
	public ShieldModel sm;
	public ShieldView sView;

	// Use this for initialization
	void Start () {
		sm = new ShieldModel ();
		sView = GetComponent<ShieldView> ();


	}

	void takeDamage(int damage) { 
		sm.TakeDamage (damage);
	}
		
	
	// Update is called once per frame
	void Update () {
		
	}
}
