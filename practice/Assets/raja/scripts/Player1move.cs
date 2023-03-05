
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1move : MonoBehaviour
{
    public Transform poz;
    public Player1move()
    {
         poz = GetComponent<Transform>();
    }
    
[SerializeField]
private float dirx;
private float speed = 10f;
private float jumpforce = 8f;
private bool onground = true;
private Rigidbody2D mybody;
private SpriteRenderer sr;
private Animator anim;


public void Awake() {

 mybody=GetComponent<Rigidbody2D>();
 anim = GetComponent<Animator>();
 sr = GetComponent<SpriteRenderer>();
 
}
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        PlayerMovement();
        PlayerAnimation();
         
    }
    void FixedUpdate()
    {
        PlayerJump();
    }
    void PlayerMovement()
    {
        dirx = Input.GetAxisRaw("Horizontal");
        if(dirx == -1)
        {
            sr.flipX=true;
        }
        else if(dirx == 1)
        {
            sr.flipX=false;
        }
        transform.position+= new Vector3(dirx,0,0)*speed* Time.deltaTime;
        
    }
    void PlayerAnimation()
    {
        if(dirx!=0)
        anim.SetBool("walk",true);
        else 
        anim.SetBool("walk",false);  
    }
    void PlayerJump()
    {
        
        if(Input.GetButtonDown("Jump")&&onground)
        {
            mybody.AddForce(new Vector2(0f,jumpforce),ForceMode2D.Impulse);
            onground = false;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
      if (collision.gameObject.CompareTag("ground"))
      onground = true;
    }
}
