using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting; 
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{
    public Transform cam; 
    CharacterController controller;
    Vector2 movement; 
    public float moveSpeed;
    float turnSmoothTime = .1f; 
    float turnSmoothVelocity; 
    Animator anim; 


    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        anim = GetComponentInChildren<Animator>();


    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Vector3 direction = new Vector3(movement.x, 0, movement.y).normalized;
        if(Input.GetKey(KeyCode.Space)){
            anim.Play("Slash");
        }
        
        anim.SetFloat("Speed",0);
        if(direction.magnitude >= 0.1f){
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y; 
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            Vector3 moveDirection = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDirection.normalized * moveSpeed * Time.deltaTime);
            anim.SetFloat("Speed", 1);

        }
        direction = Vector3.zero;
        movement = Vector2.zero;
     
       
    }
}
