using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine; 

public class Physics : MonoBehaviour
{
    public FlowerSpawn gm; 

    [SerializeField] private bool useOnCollision;
    private Rigidbody rigidbody;
    public GameObject Image;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    async void OnCollisionEnter(Collision collision){
        if(!useOnCollision){
            return;
        }
        collision.gameObject.GetComponent<Physics>();

        if(collision.gameObject.tag == StringRepo.TargetTag){
            FindObjectOfType<AudioManager>().Play("flower");
            Destroy(collision.gameObject);
            gm.AddCollectedTargets();
        }
        if(collision.gameObject.tag == StringRepo.DoorTag){
            FindObjectOfType<AudioManager>().Play("doorbreak");
            GameObject child1 = collision.gameObject.transform.GetChild(0).gameObject;
            ParticleSystem part = child1.GetComponent<ParticleSystem>();
            part.Play();
            Destroy(collision.gameObject,0.5f);
            
        }
    if(collision.gameObject.tag == StringRepo.PrincessDoorTag && gm.FlowerCheck()){
            FindObjectOfType<AudioManager>().Play("doorbreak");
            GameObject child1 = collision.gameObject.transform.GetChild(0).gameObject;
            ParticleSystem part = child1.GetComponent<ParticleSystem>();
            part.Play();
            Destroy(collision.gameObject,0.5f);
            StartCoroutine(EnableGameoverPanel());

    }
  }
  IEnumerator EnableGameoverPanel()
    {
        yield return new WaitForSeconds(5);
 
        Image.SetActive(true);
    }
}