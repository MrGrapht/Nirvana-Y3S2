using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetMaze : MonoBehaviour {

//	public GameObject sphereMaze;
	public GameObject spawnPointMaze;

	void Start () {

	}
	
	void OnTriggerEnter(Collider other) {
        
        //sphereMaze.
        transform.position = spawnPointMaze.transform.position;
        Debug.Log("Maze Sphere Position Reset");
    }
}
