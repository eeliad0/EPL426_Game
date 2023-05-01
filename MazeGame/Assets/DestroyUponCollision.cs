using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyUponCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collide");
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            Debug.Log("Collide");
        }
    }
}
