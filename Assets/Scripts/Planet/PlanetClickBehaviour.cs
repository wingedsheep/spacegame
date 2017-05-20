using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetClickBehaviour : MonoBehaviour {
	public GameObject planetClickDialog;

	void Start() {
	}
	
	// Update is called once per frame
	void Update(){
		if (Input.GetMouseButtonDown(0)) {
			//Converting Mouse Pos to 2D (vector2) World Pos
			Vector2 worldPoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			RaycastHit2D hitInfo = Physics2D.Raycast (worldPoint, Vector2.zero);
			if (hitInfo) {
				Debug.Log ("Object Hit is 2D " + hitInfo.collider.gameObject.name);
				PlanetDialog planetDialog = (PlanetDialog) planetClickDialog.GetComponent(typeof(PlanetDialog));
				planetDialog.UpdatePosition (hitInfo.collider.gameObject);
			} else {
				Debug.Log ("Nothing Hit is 2D ");
				PlanetDialog planetDialog = (PlanetDialog) planetClickDialog.GetComponent(typeof(PlanetDialog));
				planetDialog.Hide ();
			}

			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast (ray, out hit))
			if (hit.collider != null) {
				hit.collider.transform.localScale += new Vector3(0.1F, 0.1F, 0.1F);
			}
		}
	}
}
