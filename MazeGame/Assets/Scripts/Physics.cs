using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class Physics : MonoBehaviour
{
    public FlowerSpawn gm; 

    [SerializeField] private bool useOnCollision;
    private Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision collision){
        if(!useOnCollision){
            return;
        }
        collision.gameObject.GetComponent<Physics>();
        if(collision.gameObject.tag == StringRepo.TargetTag){
            Destroy(collision.gameObject,0.5f);
            gm.AddCollectedTargets();
        }
        if(collision.gameObject.tag == StringRepo.DoorTag){
            Destroy(collision.gameObject,0.5f);

    }
    
}
}