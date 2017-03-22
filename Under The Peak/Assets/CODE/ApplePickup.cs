using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplePickup : MonoBehaviour 
{
	Inventory inventory;

	void Awake()
	{
		inventory = GameObject.FindGameObjectWithTag("GameManager").GetComponent<Inventory>();
	}

	void OnTriggerStay (Collider col) 
	{
		if(col.tag == "Player")
		{
			if(Input.GetKeyDown(KeyCode.E))
			{
				PickUp();
			}
		}
	}

	void PickUp()
	{
		inventory.apples++;
		Destroy(gameObject.transform.parent.gameObject);
	}
}
