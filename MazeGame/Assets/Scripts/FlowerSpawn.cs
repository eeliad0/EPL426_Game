using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerSpawn : MonoBehaviour
{
    [Header("Prefabs")]
    [SerializeField] private GameObject flowerPrefab1, flowerPrefab2, flowerPrefab3, flowerPrefab4; 

    [Header("Spawn Point")]
    [SerializeField] private float yoffset; 
    [SerializeField] private Vector2 xSpawnPointRange; 
    [SerializeField] private bool mirrorXRange;  
    [SerializeField] private Vector2 zSpawnPointRange;
    [SerializeField] private bool mirrorZRange;

    [SerializeField] public int numOfFlowers;
    
    public int CollectedTargets { get; private set;}


    void Update(){
        if (Input.GetKeyDown(KeyCode.S))
            print(CollectedTargets);

       // if(CollectedTargets == numOfFlowers)
           
    }

    void Start(){
        setScene();
    }

    private void SpawnTarget(Vector2 spawnPoint){
        GameObject go = Instantiate(flowerPrefabPicker(), new Vector3(spawnPoint.x, yoffset, spawnPoint.y), Quaternion.identity);
        go.tag = StringRepo.TargetTag;
        BoxCollider collider = go.AddComponent<BoxCollider>();
        collider.size *= 0.04f;
    }
     private GameObject flowerPrefabPicker(){
        int random = Random.Range(0 , 4) + 1;
        switch(random){
            case 1:
                return flowerPrefab1;
            case 2:
                return flowerPrefab2;
            case 3:
                return flowerPrefab3;
            case 4:
                return flowerPrefab4;
            default:
              return flowerPrefab4;

        }
     }
    public int getCount()
    {
        return CollectedTargets;
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

    public void AddCollectedTargets(){
        CollectedTargets++;
    }

    public void setScene(){
        for(int i = 0; i<numOfFlowers;i++){
            SpawnTarget(PickRandomPoint());
        }
    }

  






























    }

