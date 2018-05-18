using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public Vector3 target;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            target = hit.point;
            if(hit.transform.tag.Equals("Enemy"))
            {
                Destroy(hit.transform.gameObject);
            }
        }
        transform.LookAt(target);
	}

}
