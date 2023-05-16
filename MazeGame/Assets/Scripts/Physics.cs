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
            GameObject child1 = collision.gameObject.transform.GetChild(0).gameObject;
            ParticleSystem part = child1.GetComponent<ParticleSystem>();
            part.Play();
            Destroy(collision.gameObject);
            gm.AddCollectedTargets();
        }
        if(collision.gameObject.tag == StringRepo.DoorTag){
            GameObject child1 = collision.gameObject.transform.GetChild(0).gameObject;
            ParticleSystem part = child1.GetComponent<ParticleSystem>();
            part.Play();
            Destroy(collision.gameObject,0.5f);

    }
    if(collision.gameObject.tag == StringRepo.PrincessDoorTag && gm.FlowerCheck()){
            GameObject child1 = collision.gameObject.transform.GetChild(0).gameObject;
            ParticleSystem part = child1.GetComponent<ParticleSystem>();
            part.Play();
            Destroy(collision.gameObject,0.5f);

    }
  }
}