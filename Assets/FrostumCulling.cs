using UnityEngine;

public class FrostumCulling : MonoBehaviour {
	private Camera mainCamera;
	void Start() {
		mainCamera = Camera.main;
	}
	void Update() {
		Plane[] planes = GeometryUtility.CalculateFrustumPlanes(mainCamera);
		Renderer renderer = GetComponent<Renderer>();

		if (GeometryUtility.TestPlanesAABB(planes, renderer.bounds)) {
			// O objeto é visível, faça algo (como ativar o renderer)
			renderer.enabled = true;
		}
		else {
			// O objeto está fora do frustum, desative o renderer
			renderer.enabled = false;
		}
	}
}
