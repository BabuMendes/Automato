using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CharMove : MonoBehaviour
{
    public Rigidbody2D Rb;
    //public Animator Anim;

    [SerializeField]
    private string Side = "Right";
   
    public int JumpQtd = 2;


    // Start is called before the first frame update
    void Start()
    {
        //Anim = GetComponent<Animator>();
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Jump();
    }

     void Move()
    {
        float velX = Input.GetAxis("Horizontal") * 4;
        float gravity = Rb.velocity.y;

        Rb.velocity = new Vector2(velX, gravity);

        if(velX == 0)
        {
            //Anim.SetBool("Walk", false);
        }
        else 
        {
            //Anim.SetBool("Walk", true);
            if(velX < 0) 
            {
                transform.localScale = new Vector3 (-1, 1, 1);
                Side = "Left";
            }
            else
            {
                transform.localScale = new Vector3 (1, 1, 1);
                Side = "Right";
            }
        }
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && JumpQtd > 0)
        {
            JumpQtd--;
            Rb.AddForce(Vector3.up * 330);
            //Anim.SetTrigger("Jump");
        }
    }
  
}
