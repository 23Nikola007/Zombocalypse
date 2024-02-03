using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MOv : MonoBehaviour
{
    public GameObject Target;
    public GameObject Follower;
    public float speed;
    // Update is called once per frame
    void Update()
    {
        Vector3 targetPos = Target.transform.position;
        Vector3 FollowerPos = Follower.transform.position;
        Follower.transform.position = Vector3.MoveTowards(FollowerPos, targetPos, Time.deltaTime * speed);
    }
}
