using UnityEngine;
using System.Collections;

public class My_Camera : MonoBehaviour {
	public Transform target;
	public Vector3 asd;
	
	void Update ()
	{
		//transform.LookAt(target);
		transform.position = new Vector3(target.position.x + asd.x,transform.position.y + asd.y, target.position.z + asd.z);
	}
}
