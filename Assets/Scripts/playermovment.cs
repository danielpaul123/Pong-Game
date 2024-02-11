using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playermovement : MonoBehaviour
{
    float movex = 0;
    float movey = 0;
    [SerializeField]
    float movespeed = 2f;
    public Transform playertransform;
    public Rigidbody2D playerrb;
    [SerializeField]
    float jumpforce = 0;
    private bool m_FacingRight = true;
    [SerializeField]
    int jumpcounts = 2;
    public LayerMask grounddetection;
    public Transform rayPos;
    // Start is called before the first frame update
    void Start()
    {
        playerrb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       moveplayer();
        //if(Input.GetButtonDown("Jump"))
        //{
            
        //    //Debug.Log("jump is pressed");
        //}
        
    }
    private void moveplayer()
    {
        //movex = Input.GetAxisRaw("Horizontal");
        playertransform.position = playertransform.position + new Vector3(movex * movespeed, movey, 0) * Time.deltaTime;
        //Debug.Log(playertransform.position);
        //Debug.Log(movex);
        /* if (movex != 0)
         {
             playerrb.velocity = new Vector2(movex * movespeed, movey) * Time.deltaTime;
         }*/
    }
    public void Jumplayer()
    {
        if(jumpcounts>0)
        {
            jumpcounts = jumpcounts - 1;
            playerrb.AddForce(new Vector2(0, 2) * jumpforce);
        }
       
    }
    public void OnMove(InputValue readMove)
    {
        //Debug.Log(readMove.Get<Vector2>());
        movex = readMove.Get<Vector2>().x;
        if (movex > 0 && !m_FacingRight)
        {
            // ... flip the player.
            Flip();
        }
        // Otherwise if the input is moving the player left and the player is facing right...
        else if (movex < 0 && m_FacingRight)
        {
            // ... flip the player.
            Flip();
        }

    }
    public void OnJump(InputValue Value)
    {
        Jumplayer();
        //Debug.Log("jumpped");
    }
    private void Flip()
    {

        m_FacingRight = !m_FacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
    private void OnTriggerEnter2D(Collider2D otherObject)
    {
        if(otherObject.gameObject.layer==6)
        {
            jumpcounts = 2;
        }
    }
}
