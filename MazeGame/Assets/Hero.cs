using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    private Rigidbody body;
    //serialized field allazei i timi tis metavlitis xoris na anoigo to script
    [SerializeField] private double speedX;
    [SerializeField] private double speedY;
    [SerializeField] private double speedZ;
    [SerializeField] private double speedA;
    Animator animator;
    Vector3 lastPosition;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
        body = GetComponent<Rigidbody>();
        lastPosition = body.position;
    }

    // Update is called once per frame

    private void FixedUpdate()
    {
        Vector3 vc = Vector3.zero;
        body.velocity = vc;
        animator.SetBool("IsWalking", false);
        

      //  body.velocity = vc;
        if (Input.GetKey(KeyCode.RightArrow))//Move Right when right arrow
        {
            animator.SetBool("IsWalking", true);
            if (Input.GetKey(KeyCode.LeftShift))
                vc.x=(float)speedA;
            else
                vc.x = (float)speedX;
                
            body.velocity = vc;
            //body.velocity = new Vector2(speedX, body.velocity.y);
        }
        if (Input.GetKey(KeyCode.LeftArrow))//Move Right when right arrow
        {
            /*if (Input.GetKey(KeyCode.LeftShift))
                Accelerate();
            */
            vc.x = (float)(-speedX);
         
            animator.SetBool("IsWalking", true);
            
            body.velocity = vc;
            //body.velocity = new Vector2(speedX, body.velocity.y);
        }
        if (Input.GetKey(KeyCode.Space))//Move Right when right arrow
        {
            /*if (Input.GetKey(KeyCode.LeftShift))
                Accelerate();
            */
            vc.y = (float)(speedY);
            body.velocity = vc;
            //body.velocity = new Vector2(speedX, body.velocity.y);
        }
        if (Input.GetKey(KeyCode.UpArrow))//Move Right when right arrow
        {
            /*if (Input.GetKey(KeyCode.LeftShift))
                Accelerate();
            */
            vc.z = (float)(speedZ);
           
            animator.SetBool("IsWalking", true);
            body.velocity = vc;
            //body.velocity = new Vector2(speedX, body.velocity.y);
        }
        if (Input.GetKey(KeyCode.DownArrow))//Move Right when right arrow
        {
            /*if (Input.GetKey(KeyCode.LeftShift))
                Accelerate();
            */
            vc.z = (float)(-speedZ);
            
            animator.SetBool("IsWalking", true);
            body.velocity = vc;
            //body.velocity = new Vector2(speedX, body.velocity.y);
        }
       
    }

    void Accelerate()
    {
        
    }
}
