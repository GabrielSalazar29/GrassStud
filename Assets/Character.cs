using UnityEngine;

public class Character : MonoBehaviour {
	public int speed;
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start() {

	}

	// Update is called once per frame
	void Update() {
		if (Input.GetKey(KeyCode.W))
			gameObject.transform.position += Vector3.forward * Time.deltaTime * speed;
		if (Input.GetKey(KeyCode.S))
			gameObject.transform.position += Vector3.back * Time.deltaTime * speed;
		if (Input.GetKey(KeyCode.A))
			gameObject.transform.position += Vector3.left * Time.deltaTime * speed;
		if (Input.GetKey(KeyCode.D))
			gameObject.transform.position += Vector3.right * Time.deltaTime * speed;
	}
}
