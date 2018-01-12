using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShieldView : MonoBehaviour {
	private Button oneDamage, tenDamage, tickDamage;
	private ShieldModel shieldModel;
	public ShieldController sController;

	void Awake() { 
	}
	// Use this for initialization
	void Start () {
		oneDamage.onClick.AddListener (sController.takeDamage(1));
		tenDamage.onClick.AddListener (sController.takeDamage(10));
		tickDamage.onClick.AddListener (sController.tick());
	}

	void takeDamage() {
		oneDamage.onClick (shieldModel.TakeDamage (1));
	}

	public void SetModel() { 
		this.shieldModel = shieldModel;
	}

	public void ChangeHealth() { 
		if (shieldModel.GetStrength () > 90) { 
			
		}

	}

	public void SetUIText(Text isRepairable, Text Strength) { 
		if (shieldModel.IsRepairable.equals (true)) { 
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
