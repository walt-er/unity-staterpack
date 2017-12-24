using UnityEngine;
using System.Collections;

class GameState : MonoBehaviour {
    private GameObject ground;
    private float countdown;

    private StateMachine fsm;
    private PausedState paused;

    public void Start() {

        fsm = gameObject.GetComponent<StateMachine>();
        paused = gameObject.GetComponent<PausedState>();

        // Make ground
        ground = (GameObject)GameObject.Instantiate(Resources.Load("Ground"), new Vector3(0, 0, 0), Quaternion.identity);

        // Make spheres
        for (int y = -5; y < 0; y++) {
            for (int x = -6; x <= 5; x++) {
                Vector3 vector = new Vector3((x * 3) + (Random.value * 2) - 1, (y * -3) + (Random.value * 2) - 1, (Random.value * 24) - 12);
                GameObject.Instantiate(Resources.Load("Sphere"), vector, Quaternion.identity);
            }
        }

    }

    public IEnumerable State()
    {
        countdown = 3;

        while (countdown > 0) {
            Debug.Log("Playing for " + countdown + "...");
            countdown--;
            yield return new WaitForSecondsRealtime(1);
        }

        fsm.state = paused.State();
    }
}
