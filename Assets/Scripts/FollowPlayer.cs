using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
	[SerializeField] GameObject	Player;
	[SerializeField] Vector3	CameraOffset = new Vector3(0.0f, 5.0f, -10.0f);

	// Update is called once per frame
	void LateUpdate()
	{
		transform.position = Player.transform.position + CameraOffset;
	}
}
