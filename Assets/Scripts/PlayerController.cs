using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public int scrollArea;
	public float camSpeed;
	private float width;
	private float height;

	// Use this for initialization
	void Start () {
		Cursor.visible = true;
		width = Screen.width;
		height = Screen.height;
	}
	
	// Update is called once per frame
	void Update () {
		//Mouse Control
		if (Input.mousePosition.x <= 0 + scrollArea) {
			transform.Translate (Vector3.left * Time.deltaTime * camSpeed);
		}
		if (Input.mousePosition.x >= width - scrollArea) {
			transform.Translate (Vector3.right * Time.deltaTime * camSpeed);
		}
		if (Input.mousePosition.y <= 0 + scrollArea) {
			transform.Translate (Vector3.back * Time.deltaTime * camSpeed);
		}
		if (Input.mousePosition.y >= height - scrollArea) {
			transform.Translate (Vector3.forward * Time.deltaTime * camSpeed);
		}

		//Button Control
		if (Input.GetKey("left")) {
			transform.Translate (Vector3.left * Time.deltaTime * camSpeed);
		}
		if (Input.GetKey("right")) {
			transform.Translate (Vector3.right * Time.deltaTime * camSpeed);
		}
		if (Input.GetKey("down")) {
			transform.Translate (Vector3.back * Time.deltaTime * camSpeed);
		}
		if (Input.GetKey("up")) {
			transform.Translate (Vector3.forward * Time.deltaTime * camSpeed);
		}
		//Zoom Control
	}
}
