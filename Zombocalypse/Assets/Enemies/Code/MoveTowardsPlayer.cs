using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class MOv : MonoBehaviour
{
    public GameObject Follower;
    public float speed;
    public Vector3 PointPos;
    private bool gotToPoint;
    // Update is called once per frame
    bool CheckIfPointPos(Vector3 Pos, Vector3 CurrentPos)
    {
        if((Pos - CurrentPos).magnitude <= 0.1 && !gotToPoint)
        {
            gotToPoint = true;
            return gotToPoint;
        }
        return gotToPoint;
    }
    void FixedUpdate()
    {
        
        PointPos.y = Follower.transform.position.y;
        Vector3 FollowerPos = Follower.transform.position;
        if (CheckIfPointPos(PointPos, FollowerPos))
        {
            GameObject Target = GameObject.FindWithTag("Player");
            Vector3 targetPos = Target.transform.position;
            targetPos.y = 0.00005f;
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            rb.velocity = speed * (new Vector3(targetPos.x, 0, targetPos.z) - new Vector3(FollowerPos.x, 0, FollowerPos.z)).normalized;
            gameObject.transform.LookAt(new Vector3(targetPos.x, gameObject.transform.position.y, targetPos.z));
            rb.angularVelocity = new Vector3(0, 0, 0);
        }
        else 
        {
            //Follower.transform.LookAt(PointPos);
            //Follower.transform.position = Vector3.MoveTowards(FollowerPos, PointPos, Time.deltaTime * speed);
            //Follower.transform.Rotate(-Follower.transform.rotation.eulerAngles.x, 0, -Follower.transform.rotation.eulerAngles.z);
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            rb.velocity = speed * (PointPos-gameObject.transform.position).normalized;
            gameObject.transform.LookAt(PointPos);
            rb.angularVelocity = new Vector3(0, 0, 0);
        }
    }
}
