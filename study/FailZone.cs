using UnityEngine;
using System.Collections;

public class FailZone : MonoBehaviour {

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.name == "Ball")
        {
            Application.LoadLevel("Game");
        }

    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
