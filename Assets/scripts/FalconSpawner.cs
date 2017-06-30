using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalconSpawner : MonoBehaviour {

	public Rigidbody2D falconPrefab;

	public Vector3 position = new Vector3(2, 3.5f, 1);
	public float spawnTime = 3f;


	void Start () {
		InvokeRepeating ("SpawnFalcon", spawnTime, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void SpawnFalcon ()
	{
		Instantiate(
			falconPrefab,
			position,
			Quaternion.identity
		);
	}
}
