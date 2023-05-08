using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyUponCollision : MonoBehaviour
{
    public FlowerSpawn gm; 
    
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collide");
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            Debug.Log("Collide");
        }
    }

    private void OnDestroy(){
        if (tag == StringRepo.TargetTag){
            if(gm!= null){
                gm.AddCollectedTargets();
            }
        }
    }
}
