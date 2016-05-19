using UnityEngine;
using System.Collections;

public class RedCoin : MonoBehaviour {
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Ball")
        {
            DestoryObstacles();
            Destroy(gameObject);
        }
    }
    void DestoryObstacles()
    {
        GameObject[] obstacles = GameObject.FindGameObjectsWithTag("Obstacle");
        for (int i = 0; i < obstacles.Length; i++)
        {
            Destroy(obstacles[i]);
        }
    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
