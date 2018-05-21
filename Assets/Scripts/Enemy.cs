using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    GameObject Food;
    public float Speed = 0.1f;
	public int EnemyHealth = 3;
	// Use this for initialization
	void Start () {
        Food = GameObject.FindGameObjectWithTag("Food");
    }

	// Update is called once per frame
	void Update ()
    {
        MoveEnemy();
    }

    public void GetHit(int damge)
	{
		EnemyHealth -= damge; 
		if(EnemyHealth <= 0)
		{
			Dead();
		}
	}

	private void Dead()
	{
		Destroy(this.gameObject);
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
