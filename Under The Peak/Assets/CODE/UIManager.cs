using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour 
{
	public GameObject player;

	public Text hungerUI;
	public Text thirstUI;
	public Text btUI;

	PlayerStats playerStats;

	void Awake () 
	{
		Cursor.visible = false;

		playerStats = player.GetComponent<PlayerStats>();
	}

	void Update () 
	{
		hungerUI.text = "Hunger: " + playerStats.hunger.ToString();
		thirstUI.text = "Thirst: " + playerStats.thirst.ToString();
		btUI.text = "Temperature: " + playerStats.bodyTemp.ToString();
	}
}
