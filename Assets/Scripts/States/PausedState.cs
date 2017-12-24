using UnityEngine;
using System.Collections;

class PausedState : MonoBehaviour {
	private bool paused;
	private GameState game;
	private StateMachine fsm;

	void Start() {
        game = gameObject.GetComponent<GameState>();
        fsm = gameObject.GetComponent<StateMachine>();
	}

    public IEnumerable State() {
        paused = true;

        while (paused) {
            paused = false;
            Pause();
            yield return new WaitForSecondsRealtime(2);
        }

        Unpause();
    }

	public void Pause() {
		Debug.Log("paused");
		Time.fixedDeltaTime = 0;
		Time.timeScale = 0;
	}

	public void Unpause() {
		Debug.Log("unpausing");
		Time.timeScale = 1;
		Time.fixedDeltaTime = 0.02F * Time.timeScale;

		// Restart game
        fsm.state = game.State();
	}
}
