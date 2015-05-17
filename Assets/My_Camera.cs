using UnityEngine;
using System.Collections;

public class My_Camera : MonoBehaviour {
	public Transform target;
	public int asd;
	
	void Update ()
	{
		//transform.LookAt(target);
		transform.position = new Vector3(target.position.x ,transform.position.y , target.position.z+asd);
	}
}
