using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    public GameObject Food;
    public GameObject EnemyController;
    public GameObject Gun;
    public float height = 0;
    public float width = 0;

    // event position food
    public delegate void GetPositionFood(Vector3 pos);
    public static event GetPositionFood onGetPositionFood;

    // Use this for initialization
    void Start()
    {
        if(onGetPositionFood != null)
        {
            onGetPositionFood(Food.GetComponent<Transform>().position);
        }

        //GetCamera();
        //Debug.Log(Food.GetComponent<Food>().positionFood());
    }

    //private void GetCamera()
    //{
    //    Camera cam = Camera.main;
    //    height = 2f * cam.orthographicSize;
    //    width = height * cam.aspect;
    //}

    // Update is called once per frame
    void Update()
    {

    }

    
}
