using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaffsManager : MonoBehaviour 
{
	public int currentStaff;

	public GameObject[] staffs;

	public GameObject iceCube;

	void Start () 
	{
		currentStaff = 1;
	}

	void Update () 
	{

		//Mudar a variavel currentStaff
		if(Input.GetKeyDown(KeyCode.Alpha1))
			currentStaff = 1;
		
		else if(Input.GetKeyDown(KeyCode.Alpha2))
			currentStaff = 2;

		else if(Input.GetKeyDown(KeyCode.Alpha3))
			currentStaff = 3;

		else if(Input.GetKeyDown(KeyCode.Alpha4))
			currentStaff = 4;


		//Alternar entre osGameobjects dos staffs
	switch(currentStaff)
		{
			case 1:
			staffs[0].SetActive(true);
			staffs[1].SetActive(false);
			staffs[2].SetActive(false);
			staffs[3].SetActive(false);
			break;

		case 2:
			staffs[0].SetActive(false);
			staffs[1].SetActive(true);
			staffs[2].SetActive(false);
			staffs[3].SetActive(false);
			break;

		case 3:
			staffs[0].SetActive(false);
			staffs[1].SetActive(false);
			staffs[2].SetActive(true);
			staffs[3].SetActive(false);
			break;

		case 4:
			staffs[0].SetActive(false);
			staffs[1].SetActive(false);
			staffs[2].SetActive(false);
			staffs[3].SetActive(true);
			break;		
		}

		//Powers
		if(Input.GetMouseButtonDown(0))
		{
			if(currentStaff == 1)
			{
				RedPower();
			}
			else if(currentStaff == 2)
			{
				BluePower();
			}
			else if(currentStaff == 3)
			{
				GreenPower();
			}
			else if(currentStaff == 4)
			{
				PurplePower();
			}
		}
	}

	void RedPower()
	{
		
	}

	void BluePower()
	{
		RaycastHit hit;

		if(Physics.Raycast(Camera.main.ViewportPointToRay(new Vector2(0.5f, 0.5f)), out hit, 50.0f))
		{
			Instantiate(iceCube, hit.point , transform.rotation);	
		}
	}

	void GreenPower()
	{
		
	}

	void PurplePower()
	{
		
	}
}
