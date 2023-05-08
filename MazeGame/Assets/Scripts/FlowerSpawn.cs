using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerSpawn : MonoBehaviour
{
    [Header("Prefabs")]
    [SerializeField] private GameObject flowerPrefab; 

    [Header("Spawn Point")]
    [SerializeField] private float yoffset; 
    [SerializeField] private Vector2 xSpawnPointRange; 
    [SerializeField] private bool mirrorXRange;  
    [SerializeField] private Vector2 zSpawnPointRange;
    [SerializeField] private bool mirrorZRange;

    [SerializeField] private int numOfFlowers;
    
    public float CollectedTargets { get; private set;}


    void Update(){
        if (Input.GetKeyDown(KeyCode.S))
            print(CollectedTargets);
    }

    void Start(){
        setScene();
    }

    private void SpawnTarget(Vector2 spawnPoint){
        GameObject go = Instantiate(flowerPrefab, new Vector3(spawnPoint.x, yoffset, spawnPoint.y), Quaternion.identity);
        go.tag = StringRepo.TargetTag;
        BoxCollider collider = go.AddComponent<BoxCollider>();
        collider.size *= 0.05f;
        
     
    }

    private Vector2 PickRandomPoint(){
        float x = Random.Range(xSpawnPointRange.x, xSpawnPointRange.y);
        float z = Random.Range(zSpawnPointRange.x, zSpawnPointRange.y);

        if(mirrorXRange)
        {
            int mirror = Random.Range(0,2);
            if(mirror == 1){
                x*=-1;
            }

        }

        if(mirrorZRange)
        {
            int mirror = Random.Range(0,2);
            if(mirror == 1){
                z*=-1;            
            }

        }

        return new Vector2(x,z);

    }

    public void AddCollectedTargets(int value = 1){
        CollectedTargets+=value;
    }

    public void setScene(){
        for(int i = 0; i<numOfFlowers;i++){
            SpawnTarget(PickRandomPoint());
        }
    }

































    }

