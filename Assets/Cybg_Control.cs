using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class Cybg_Control : MonoBehaviour
{
    private Animator mAnimator;
    public float speed = 2f;
    public float ini;
    public float rotationSpeed = 75f;
    public float R_speed = 4f;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
        ini = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.position.y!=ini)
           rb.AddForce(0, -200000f, 0);
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = R_speed;
            float translation = Input.GetAxis("Vertical") * speed;
            float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
            translation *= Time.deltaTime;
            rotation *= Time.deltaTime;

            transform.Translate(rotation, 0, translation);
            if (translation != 0)
                mAnimator.SetBool("running", true);
            
            if (Input.GetKey(KeyCode.Space))
                mAnimator.SetBool("jumping", true);
            else
            {
                mAnimator.SetBool("jumping", false);
            }

            if (translation != 0 && Input.GetKey(KeyCode.Space))
            {
                mAnimator.SetBool("running", true);
                mAnimator.SetBool("jumping", true);
            }

            if (Input.GetKey(KeyCode.D))
            {
                mAnimator.SetBool("run_right", true);
            }

            if (Input.GetKey(KeyCode.A))
            {
                mAnimator.SetBool("run_left", true);
            }

            if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
                mAnimator.SetBool("run_right45", true);

            if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
                mAnimator.SetBool("run_left45", true);
        }
        else
        {
            mAnimator.SetBool("running", false);
            mAnimator.SetBool("run_right", false);
            mAnimator.SetBool("run_left45", false);
            mAnimator.SetBool("run_right45", false);
            mAnimator.SetBool("run_left", false);
            float translation = Input.GetAxis("Vertical") * speed;
            float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
            translation *= Time.deltaTime;
            rotation *= Time.deltaTime;

            transform.Translate(rotation, 0, translation);
            if (translation != 0)
                mAnimator.SetBool("walking", true);
            else
            {
                mAnimator.SetBool("walking", false);
            }

            if (Input.GetKey(KeyCode.Space))
                mAnimator.SetBool("jumping", true);
            else
            {
                mAnimator.SetBool("jumping", false);
            }

            if (translation != 0 && Input.GetKey(KeyCode.Space))
            {
                mAnimator.SetBool("walking", true);
                mAnimator.SetBool("jumping", true);
            }

            if (Input.GetKey(KeyCode.D))
            {
                mAnimator.SetBool("right", true);
            }
            else
            {
                mAnimator.SetBool("right", false);
            }

            if (Input.GetKey(KeyCode.A))
            {
                mAnimator.SetBool("left", true);
            }
            else
            {
                mAnimator.SetBool("left", false);
            }

            if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.W))
                mAnimator.SetBool("right45", true);
            else
            {
                mAnimator.SetBool("right45", false);
            }

            if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
                mAnimator.SetBool("left45", true);
            else
            {
                mAnimator.SetBool("left45", false);
            }
        }
    }
}
