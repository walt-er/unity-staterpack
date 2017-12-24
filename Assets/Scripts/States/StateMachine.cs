using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class StateMachine : MonoBehaviour {

	// Variables to hold possible state and current state
	public IEnumerable state;
    Dictionary<string, IEnumerable> states = new Dictionary<string, IEnumerable>();

	// All state classes
    GameState game;
    PausedState paused;

	public void Start() {
        // Add all posible states
        game = gameObject.AddComponent<GameState>();
        paused = gameObject.AddComponent<PausedState>();

		// Default state
		state = paused.State();

		StartCoroutine(Run());
	}

	// Endless loop over current state
	public IEnumerator Run() {
		while (state != null)
		{
			foreach (var cur in state)
			{
				yield return cur;
			}
		}
	}
}
