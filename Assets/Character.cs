using UnityEngine;

public class Character : MonoBehaviour {
	public int speed;
	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start() {

	}

	// Update is called once per frame
	void Update() {
		if (Input.GetKey(KeyCode.W))
			transform.position += speed * Time.deltaTime * Vector3.forward;
		if (Input.GetKey(KeyCode.S))
			transform.position += speed * Time.deltaTime * Vector3.back;
		if (Input.GetKey(KeyCode.A))
			transform.Rotate(5 * speed * Time.deltaTime * Vector3.down);
		if (Input.GetKey(KeyCode.D))
			transform.Rotate(5 * speed * Time.deltaTime * Vector3.up);
	}
}
