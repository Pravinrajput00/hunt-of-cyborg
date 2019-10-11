using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class Cybg_Control : MonoBehaviour
{
    private Animator mAnimator;
    public float speed = 2f;
    public float rotationSpeed = 75f;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        mAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;
        
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);
        if(translation!=0)
            mAnimator.SetBool("walking", true);
        else
        {
            mAnimator.SetBool("walking", false);
        }
        if(Input.GetKey(KeyCode.Space))
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
    }
}
