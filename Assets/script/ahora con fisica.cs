using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ahoraconfisica : MonoBehaviour
{
    public float xySpeed;
    public int xDirection;
    public int yDirection;
    private Rigidbody2D _ComponentRigidBody2D;
    private SpriteRenderer _ComponentSpriteRenderer2D;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Awake()
    {
        _ComponentSpriteRenderer2D = GetComponent<SpriteRenderer>();
        _ComponentRigidBody2D = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {
        _ComponentRigidBody2D.velocity = new Vector2(xySpeed*xDirection*Time.deltaTime,
            xySpeed*yDirection*Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="HorizontalWall2")
        {
            xDirection = -1;
            _ComponentSpriteRenderer2D.flipX = true;
        }
        if (collision.gameObject.tag == "HorizontalWall")
        {
            xDirection = 1;
            _ComponentSpriteRenderer2D.flipX = false;
        }
        if (collision.gameObject.tag == "ceiling")
        {
            yDirection = -1;
            _ComponentSpriteRenderer2D.flipY = true;
        }
        if (collision.gameObject.tag == "floor")
        {
            yDirection = 1;
            _ComponentSpriteRenderer2D.flipY = false;
        }
    }
}

