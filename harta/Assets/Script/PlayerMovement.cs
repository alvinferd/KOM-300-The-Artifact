using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float speed;
	private Rigidbody2D rb;
	private Vector3 change;
	private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
    	animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    	change = Vector3.zero;
    	change.x = Input.GetAxisRaw("Horizontal");
        change.y = Input.GetAxisRaw("Vertical");
        animationmovement();
    }

    void animationmovement(){
    	if(change != Vector3.zero){
        	MoveCharacter();
        	animator.SetFloat("MoveX", change.x);
        	animator.SetFloat("MoveY", change.y);
        	animator.SetBool("walking", true);
        } else {
        	animator.SetBool("walking", false);
        }
    }

    //move character
    void MoveCharacter(){
    	rb.MovePosition(
    		transform.position + change * speed * Time.deltaTime
    		);
    }
}
