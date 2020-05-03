using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{

	public CharacterController2D controller;
	public Animator animator;

	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;

    //public static bool playerIsActive = false;

    //public void isActive()
    //{
    //    playerIsActive = true;
    //}

    //public void isNotActive()
    //{
    //    playerIsActive = false;
    //}

   // public bool activityCheck()
    //{
    //    return playerIsActive;
    //}

    // Update is called once per frame
    void Update (){

		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

		animator.SetFloat("yPos", transform.position.y);

		if (Input.GetButtonDown("Jump")){
			jump = true;
			animator.SetBool("IsJumping", true);
            //isActive();
        }

		if (Input.GetButtonDown("Crouch")){
			crouch = true;
            //isActive();
        } else if (Input.GetButtonUp("Crouch")){
			crouch = false;
		}

		if(Input.GetKeyDown(KeyCode.Escape)){
			Application.LoadLevel("menu");
		}

	}

	public void OnLanding (){
		animator.SetBool("IsJumping", false);
	}

	public void OnCrouching (bool isCrouching){
		animator.SetBool("IsCrouching", isCrouching);
	}

	void FixedUpdate (){
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;
        //isActive();
    }
}