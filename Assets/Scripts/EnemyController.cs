using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
    public GameObject[] SpawnPoint;
    public GameObject[] Enemy;

    public float MinSpawnTime = 0.2f;
    public float MaxSpawnTime = 1;
    private float LastSpawnTime = 0;
    private float SpawnTime = 0;

	// Use this for initialization
	void Start () {
        UpdateSpawnTime();
	}

    void UpdateSpawnTime()
    {
        LastSpawnTime = Time.time;
        SpawnTime = Random.Range(MinSpawnTime, MaxSpawnTime);
    }
	
	// Update is called once per frame
	void Update () {
		if(Time.time >= LastSpawnTime + SpawnTime)
        {
            //Spawn();
        }
	}

    void Spawn()
    {
		int index = Random.Range(0,2);
		int indexModel = Random.Range(0, 2);
		Instantiate(Enemy[indexModel], SpawnPoint[index].transform.position, Quaternion.identity);
        UpdateSpawnTime();
    }


}
