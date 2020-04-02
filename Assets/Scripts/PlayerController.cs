using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	/** Game Configuration */
	[SerializeField] float	VehicleSpeed = 20.0f;
	[SerializeField] float	TurnSpeed = 10.0f;
	float	HorizontalInput;
	float	VerticalInput;

	// Start is called before the first frame update
	void Start()
	{
	}

	// Update is called once per frame
	void Update()
	{
		HorizontalInput = Input.GetAxis("Horizontal");
		VerticalInput = Input.GetAxis("Vertical");

		transform.Translate(Vector3.forward * Time.deltaTime * VehicleSpeed * VerticalInput);
		transform.Translate(Vector3.right * Time.deltaTime * TurnSpeed * HorizontalInput);
	}
}
