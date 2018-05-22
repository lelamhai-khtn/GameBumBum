using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour {
	GameObject Food;
	int index = 0;
	List<Vector3> ListPos = new List<Vector3>();
	// Use this for initialization
	void Start () {
		Food = GameObject.FindGameObjectWithTag("Food");
		print(Food.gameObject.transform.GetChild(0).position);
		for (int i = 0; i < 4; i++)
		{
			ListPos.Add(new Vector3(Random.Range(1,5), 0 ,Random.Range(1, 5)));
		}

		ListPos.Add(Food.GetComponent<Transform>().position);
	}

	// Update is called once per frame
	void Update () {
		if(index < 5)
		{
			Vector3 pos = (ListPos[index] - transform.position).normalized * 5f * Time.deltaTime;
			transform.position += pos;
			if((ListPos[index] - transform.position).magnitude < 0.5f)
			{
				index++;
			}
		}
	}
}
