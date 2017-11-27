using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class App : MonoBehaviour
{
	private EventForwarder forwarder;

	void Start()
	{
		// Make ground
        Instantiate(Resources.Load("Ground"), new Vector3(0, -6, 0), Quaternion.identity);
        Random rnd = new Random();

		for (int y = -12; y <= 0; y++) {
            for (int x = -6; x <= 5; x++) {
            	Vector3 vector = new Vector3((x * 3) + (Random.value * 2) - 1, (y * -3) + (Random.value * 2) - 1, 0);
                GameObject sphere = (GameObject)Instantiate(Resources.Load("Sphere"), vector, Quaternion.identity);
				forwarder = sphere.AddComponent<EventForwarder>();
				forwarder.StartEvent += HandleStartEvent;
            }
        }
	}

	public void Update()
	{
		// {all app logic}
	}

	public void OnApplicationQuit()
	{
		// {all app shutdown code}
	}

	private void HandleStartEvent()
	{
		// Stop listening for it to start
		forwarder.StartEvent -= HandleStartEvent;

		// Do something in response to the event
		Debug.Log("Detected other game object's Start()");
	}
}
