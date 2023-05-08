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