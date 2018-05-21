using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public Vector3 target;
	public int damge = 1;
	Ray ray;
	RaycastHit hit;

	public float FirstTime = 0.3f;
	public float LastTime = 0f;
    
	// Use this for initialization
	void Start () {
		UpdateFireTime();

	}

    void UpdateFireTime()
	{
		LastTime = Time.time;

	}
	
	// Update is called once per frame
	void Update ()
	{
		print("time: " + Time.time);
		print("deltaTime: " + Time.deltaTime);
		RoteGun();
		if(Input.GetMouseButton(0))
		{
			GunShooter();
		}
        
	}

	private void RoteGun()
	{
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            target = hit.point;
        }
		transform.LookAt(target);
	}

	private void GunShooter()
	{
		if(Time.time >= LastTime + FirstTime)
		{
			if (Physics.Raycast(ray, out hit))
            {
                target = hit.point;
                if (hit.transform.tag.Equals("Enemy"))
                {
                    hit.transform.GetComponent<Enemy>().GetHit(damge);
                }
            }

			UpdateFireTime();
		}
	}
}
