using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    private float nextSpawnTime; //when next wall will spawn

    [SerializeField] private GameObject Wall1;
    [SerializeField] private GameObject Wall2;
    [SerializeField] private GameObject Wall3;
    [SerializeField] private GameObject Wall4;
    [SerializeField] private GameObject Wall5;
    [SerializeField] private float spawnDelay;
    private int spawnCount = 1;
    
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ShouldSpawn())
            if(spawnCount == 1)
            {
                Spawn1();
            } else if(spawnCount == 2){
                Spawn2();
            }
            else if(spawnCount == 3){
                Spawn3();
            }
            else if(spawnCount == 4){
                Spawn4();
            }
            else if (spawnCount == 5){
                Spawn5();
            }

    }

    private void Spawn1()
    {
        nextSpawnTime = Time.time + spawnDelay;
        Instantiate(Wall1, transform.position, transform.rotation);
        spawnCount++;
    }
    private void Spawn2()
    {
        nextSpawnTime = Time.time + spawnDelay;
        Instantiate(Wall2, transform.position, transform.rotation);
        spawnCount++;
    }
    private void Spawn3()
    {
        nextSpawnTime = Time.time + spawnDelay;
        Instantiate(Wall3, transform.position, transform.rotation);
        spawnCount++;
    }
    private void Spawn4()
    {
        nextSpawnTime = Time.time + spawnDelay;
        Instantiate(Wall4, transform.position, transform.rotation);
        spawnCount++;
    }
    private void Spawn5()
    {
        nextSpawnTime = Time.time + spawnDelay;
        Instantiate(Wall5, transform.position, transform.rotation);
        spawnCount=1;

        if (spawnDelay > 1)
        {
            spawnDelay--;
        }
    }

    private bool ShouldSpawn()
    {
        return Time.time >= nextSpawnTime;

    }
}
