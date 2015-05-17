using UnityEngine;
using System.Collections;

public class Script_Menu : MonoBehaviour {

	// Use this for initialization

	Ray posPC;
	RaycastHit2D hitPC;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){				
			posPC = Camera.main.ScreenPointToRay(Input.mousePosition);
			hitPC = Physics2D.GetRayIntersection(posPC);
			if (hitPC != null && hitPC.collider != null) {			
				switch (hitPC.collider.gameObject.name){
				case "t1":
					Application.LoadLevel("game");
					break;
				case "t2":
					Application.Quit();
					break;
				}

			}
		}
	}
}
