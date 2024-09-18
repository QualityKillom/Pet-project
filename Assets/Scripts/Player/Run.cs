using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rigidbody2D;
    private Animator animator;
    private GameObject cursor;
  
    public void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        cursor = GameObject.FindWithTag("Cursor");
       
    }
    void Start()
    {
        
    }

       void Update()
    {
        Move();
        Animation();
        localScaleRotate(); 
    }

    void Move()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        if(speed != 0)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(hor, ver).normalized * speed;
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(hor, ver).normalized;
        }
       
    }
    void Animation()
    {
        if(GetComponent<Rigidbody2D>().velocity == Vector2.zero)
        {
            animator.SetBool(Animator.StringToHash("Run"),false);
        }
        else
        {
            animator.SetBool(Animator.StringToHash("Run"),true);
        }
    }
    void localScaleRotate()
    {
        if(cursor.transform.position.x > transform.position.x)
        {
            transform.localScale = new Vector3(1,1,1);
        }
        else 
        {
            transform.localScale = new Vector3(-1,1,1);
        }

    }
}
