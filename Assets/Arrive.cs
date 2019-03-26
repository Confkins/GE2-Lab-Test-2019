using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Arrive: SteeringBehaviour
{
    public Vector3 targetPosition = Vector3.zero;
    public float slowingDistance = 15.0f;
    public RaycastHit hit;
    public GameObject targetGameObject;
    

    public override Vector3 Calculate()
    {
        return boid.ArriveForce(targetPosition, slowingDistance);
    }
    public void Update()
    {
        if(targetGameObject == null)
        {
            targetGameObject = GameObject.FindGameObjectsWithTag("Base")[UnityEngine.Random.Range(0, 3)];
        }
        else
        {
            targetPosition = targetGameObject.transform.position;
        }
    }
}