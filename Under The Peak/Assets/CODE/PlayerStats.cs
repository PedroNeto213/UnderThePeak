using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour 
{
	public float hunger = 1000;
	public float thirst = 1000;
	public float bodyTemp = 1000;

	Inventory inventory;

	void Awake () 
	{
		inventory = GameObject.FindGameObjectWithTag("GameManager").GetComponent<Inventory>();
	}

	void Update () 
	{
		hunger = hunger -0.01f;
		thirst = thirst -0.01f;
		bodyTemp = bodyTemp-0.01f;

		hunger = Mathf.Clamp(hunger,0,100);
		thirst = Mathf.Clamp(thirst,0,100);
		bodyTemp = Mathf.Clamp(bodyTemp,0,100);

		if(hunger <= 0)
			hunger = 0;

		if(thirst <= 0)
			thirst = 0;
		
		if(bodyTemp <= 0)
			bodyTemp = 0;

		//Eat Apple Test
		if(Input.GetKeyDown(KeyCode.Q))
		{
			if(inventory.apples > 0)
			{
				inventory.apples--;
				hunger = hunger + 10;
			}
		}
	}
}
