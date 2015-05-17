using UnityEngine;
using System.Collections;

public class Shadow_Sphere : MonoBehaviour {
	public Transform target;
	public Vector3 asd;
	
	void Update ()
	{
		//transform.LookAt(target);
		transform.position = new Vector3(target.position.x + asd.x,target.position.y + asd.y, target.position.z + asd.z);
	}
}
