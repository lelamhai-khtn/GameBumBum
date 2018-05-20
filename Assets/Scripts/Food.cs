using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour {
    public Vector3 posFood = new Vector3();
    // Use this for initialization
    void Start () {
        positionFood();
    }

    public Vector3 positionFood()
    {
        posFood.x = transform.position.x;
        posFood.y = transform.position.y;
        posFood.z = transform.position.z;
        return posFood;
    }
}
