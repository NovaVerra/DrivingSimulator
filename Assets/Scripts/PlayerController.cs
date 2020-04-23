using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
	/** Game Configuration */
	// [SerializeField] float	VehicleSpeed = 20.0f;
	[SerializeField] GameObject			CenterOfMass;
	[SerializeField] TextMeshProUGUI	Speedometer;
	[SerializeField] TextMeshProUGUI	RPMText;
	[SerializeField] float	HorsePower = 50000.0f;
	[SerializeField] float	TurnSpeed = 50.0f;
	float		Speed;
	float		RPM;
	float		HorizontalInput;
	float		VerticalInput;
	Rigidbody	RB_Player;

	void	Start()
	{
		RB_Player = GetComponent<Rigidbody>();
		RB_Player.centerOfMass = CenterOfMass.transform.position;
	}

	// Update is called once per frame
	void	FixedUpdate()
	{
		GetPlayerInput();
		MoveVehicle();
		UpdateSpeedometer();
	}

	void	GetPlayerInput()
	{
		HorizontalInput = Input.GetAxis("Horizontal");
		VerticalInput = Input.GetAxis("Vertical");
	}

	void	MoveVehicle()
	{
		// transform.Translate(Vector3.forward * Time.deltaTime * VehicleSpeed * VerticalInput);
		RB_Player.AddRelativeForce(Vector3.forward * HorsePower * VerticalInput);
		transform.Rotate(Vector3.up, Time.deltaTime * TurnSpeed * HorizontalInput);
	}

	void	UpdateSpeedometer()
	{
		Speed = Mathf.RoundToInt(RB_Player.velocity.magnitude * 2.237f); // change 2.237 to 3.6 for KPH
		Speedometer.text = "Speed: " + Speed + "mph";
		RPM = Mathf.RoundToInt(Speed % 40) * 60;
		RPMText.text = "RPM: " + RPM;
	}
}
