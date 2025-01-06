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
			// O objeto � vis�vel, fa�a algo (como ativar o renderer)
			renderer.enabled = true;
		}
		else {
			// O objeto est� fora do frustum, desative o renderer
			renderer.enabled = false;
		}
	}
}
