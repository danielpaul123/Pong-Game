using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balls : MonoBehaviour
   
{
    public GameObject ball;
    public Transform Ballinstanceposition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("space is pressed");
            geneateballfunc();
        }
        
    }
    public void geneateballfunc()
    {
         var obj=Instantiate(ball, Ballinstanceposition);
    }
}
