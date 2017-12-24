using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;

public class App : MonoBehaviour
{
	private StateMachine fsm;

	void Start() {
		// Init and run the state machine
		fsm = gameObject.AddComponent<StateMachine>();
	}

	public void Update() {
	}

	public void OnApplicationQuit() {
		// {all app shutdown code}
	}
}
