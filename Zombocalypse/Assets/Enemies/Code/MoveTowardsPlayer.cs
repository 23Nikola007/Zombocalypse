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
    private Healthandstuff healthandstuff;
    private BoxCollider boxcollider;
    private CapsuleCollider capsulecollider;
    // Update is called once per frame
    private void Start()
    {
        healthandstuff = GetComponent<Healthandstuff>();
        boxcollider = GetComponent<BoxCollider>();
        capsulecollider = GetComponent<CapsuleCollider>();
    }
    bool CheckIfPointPos(Vector3 Pos, Vector3 CurrentPos)
    {
        if((Pos - CurrentPos).magnitude <= 0.1 && !gotToPoint)
        {
            gotToPoint = true;
            return gotToPoint;
        }
        return gotToPoint;
    }
    public void DeleteZombie()
    {
        if (healthandstuff.isDead)
        {
            Destroy(Follower);
        }
    }
    public void DisableZombie()
    {
        if(healthandstuff.isDead)
        {
            boxcollider.enabled = false;
            capsulecollider.enabled = false;
        }
    }
    public void StopZombie()
    {
        if (healthandstuff.isDead)
        {
            speed = 0;
        }
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
            rb.velocity = speed * (new Vector3(targetPos.x, targetPos.y, targetPos.z) - new Vector3(FollowerPos.x, FollowerPos.y, FollowerPos.z)).normalized;
            gameObject.transform.LookAt(new Vector3(targetPos.x, gameObject.transform.position.y, targetPos.z));
            rb.angularVelocity = new Vector3(0, 0, 0);
        }
        else 
        {
            Rigidbody rb = gameObject.GetComponent<Rigidbody>();
            rb.velocity = speed * (PointPos-gameObject.transform.position).normalized;
            gameObject.transform.LookAt(PointPos);
            rb.angularVelocity = new Vector3(0, 0, 0);
        }
    }
}
