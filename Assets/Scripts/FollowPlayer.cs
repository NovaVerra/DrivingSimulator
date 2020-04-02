using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
	[SerializeField] GameObject	Player;
	[SerializeField] Vector3	CameraOffset = new Vector3(0.0f, 5.0f, -10.0f);

	// Start is called before the first frame update
	void Start()
	{
		
	}

	// Update is called once per frame
	void Update()
	{
		transform.position = Player.transform.position + CameraOffset;
	}
}
