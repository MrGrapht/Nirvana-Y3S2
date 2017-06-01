using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetCubeGame : MonoBehaviour {

//	public GameObject cube;
	public GameObject spawnPointCubeGame;

	void Start () {

	}
	
	void OnTriggerEnter(Collider other) {
        
        //cube.
        transform.position = spawnPointCubeGame.transform.position;
        Debug.Log("Cube Game Cube Position Reset");
    }
}
