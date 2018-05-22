using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    GameObject Food;
    public float Speed = 0.1f;
	public int EnemyHealth = 3;

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
}
