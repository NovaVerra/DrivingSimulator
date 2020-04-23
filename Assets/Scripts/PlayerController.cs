using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	/** Game Configuration */
	// [SerializeField] float	VehicleSpeed = 20.0f;
	[SerializeField] float	HorsePower = 50000.0f;
	[SerializeField] float	TurnSpeed = 50.0f;
	[SerializeField] GameObject	CenterOfMass;
	float	HorizontalInput;
	float	VerticalInput;
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
}
