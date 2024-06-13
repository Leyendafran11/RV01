using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openBook : MonoBehaviour
{
	public GameObject cover;
	public HingeJoint joint;


	 void Start()
	{
		var joint = cover.GetComponent<HingeJoint>();

		joint.useMotor = false;
	}

	public void OpenSesame()
	{
		joint.useMotor = true;
		Debug.Log("motor should be true");
	}
}
