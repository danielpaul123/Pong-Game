using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ballmovement : MonoBehaviour
{
    public Transform ballstartposition;
    private int[] direction = new int[] { 1, -1 };
    // Start is called before the first frame update
    public Rigidbody2D ballrb;
    public float force = 5;
    public float timer;
    private float temptimer;
    private bool isforceapplied=false;
    public uimanager uimanager;
    void Start()
    {
        ballstartposition = GetComponent<Transform>();
        ballstartposition.position=Vector3.zero;
        ballrb = GetComponent<Rigidbody2D>();
       

    }
    private void Update()
    {
        temptimer += Time.deltaTime;
        if(temptimer > timer&& !isforceapplied)
        {
            Addforceball();
            isforceapplied=true;
        }
    }

    public void Addforceball()
    {
        int x = direction[(Random.Range(0, direction.Length))];
        int y = direction[(Random.Range(0, direction.Length))];
        ballrb.AddForce(new Vector2(x,y) *force, ForceMode2D.Impulse);
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name=="p1goal")
        {
            ballstartposition.position = Vector3.zero;
            temptimer = 0.0f;
            isforceapplied = false;
            ballrb.velocity = Vector2.zero;
            uimanager.updatep1score(1);


            Debug.Log("Player 1 gets a Point");
        }
        else if(collision.gameObject.name=="p2goal")
        {
            ballstartposition.position = Vector3.zero;
            temptimer = 0.0f;
            isforceapplied = false;
            ballrb.velocity = Vector2.zero;
            uimanager.updatep2score(1);

            Debug.Log("Player 2 gets a Point");
        }
      //  collision.gameObject.GetComponent<SpriteRenderer>().color=Random.ColorHSV(0f,1f,1f,1f,0.5f,1f);
    }



}