using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    GameObject Food;
    public float Speed = 0.5f;
	// Use this for initialization
	void Start () {
        Food = GameObject.FindGameObjectWithTag("Food");
    }

	// Update is called once per frame
	void Update ()
    {
        MoveEnemy();
    }

    private void MoveEnemy()
    {
        if (Food != null)
        {
            transform.LookAt(Food.GetComponent<Transform>().position);
            transform.position = Vector3.Lerp(transform.position, Food.GetComponent<Transform>().position, Speed * Time.deltaTime);
        }
    }
}
