using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject Zombie;
    public int Seconds;
    double time = 0;
    void Update()
    {
        Spawner();
        time += Time.deltaTime;
    }
    // Update is called once per frame
    void Spawner()
    {
        if(time >= Seconds)
        {
            Vector3 spawnVector = new Vector3(Random.Range(26, 46), 1, -56);
            Instantiate(Zombie, spawnVector, Quaternion.identity);
            time = 0;
        }
    }
}
