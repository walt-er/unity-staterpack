using UnityEngine;

public class Ground : MonoBehaviour {

	public Renderer rend;
	private GameObject[] walls;

	void Start() {
		// Define walls array
		walls = new GameObject[4];

		// Get ground bounds
		rend = GetComponent<Renderer>();
		float minX = rend.bounds.min.x;
		float maxX = rend.bounds.max.x;
		float minZ = rend.bounds.min.z;
		float maxZ = rend.bounds.max.z;


		// for (int i = 0; i < walls.Length; i++) {
		// 	GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
		// 	float xA = i < 2 ? minX : maxX;
		// 	float zA = i % 2 == 0 ? maxZ : minZ;

		// 	int j = (i + 1) % walls.Length;
		// 	float xB = j < 2 ? minX : maxX;
		// 	float zB = j % 2 == 0 ? maxZ : minZ;

		// 	Vector3 pA = new Vector3(xA, 0, zA);
		// 	Vector3 pB = new Vector3(xB, 0, zB);

  //   		// Assuming this is run on a unit cube.
		//     Vector3 between = pB - pA;

		//     Debug.Log(between);

		//     float distance = between.magnitude;
		//     Vector3 localScale = cube.transform.localScale;

		//     if (i % 2 == 0) {
		//     	localScale.x = distance;
	 //    	} else {
	 //    		localScale.y = distance;
	 //    	}

		//     cube.transform.localScale = localScale;
		//     cube.transform.position = pA;
		//     // cube.transform.position = pA + (between / 2.0);
		//     cube.transform.LookAt(pB);
		// }
	}
}
