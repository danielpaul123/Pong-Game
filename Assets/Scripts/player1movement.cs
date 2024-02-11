using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1movement : MonoBehaviour
{
    // Start is called before the first frame update
    Transform Player1Transform;

    Vector2 plyerMove;
    public float playerspeed = 7;

    public bool IsPlayerOne;
    void Start()
    {
        Player1Transform = GetComponent<Transform>();
        plyerMove = new Vector2(1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (IsPlayerOne)
        {
            if (Input.GetKey(KeyCode.W))
            {
                MoveUp();
            }
            if (Input.GetKey(KeyCode.S))
            {
                MoveDown();
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                MoveUp();
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                MoveDown();
            }

        }
    }
    public void MoveUp()
    {
        if (Player1Transform.position.y <= 5f)
        {
            Player1Transform.position = Player1Transform.position + new Vector3(0, playerspeed, 0) * Time.deltaTime;
          
        }
        else
        {
            Player1Transform.position = new Vector3(Player1Transform.position.x, 5f, 0);
        }

    }
    public void MoveDown()
    {
        if (Player1Transform.position.y > -5f)

        {
            Player1Transform.position = Player1Transform.position - new Vector3(0, playerspeed, 0) * Time.deltaTime;
           
        }
    }
}