using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectmove : MonoBehaviour
{
    private Camera cam;
    public Vector3 mouseposition;
    Transform boxtransform;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        boxtransform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Camera.main.ScreenToWorldPoint(Input.mousePosition));
    }
    private void OnMouseEnter()
    {
        Debug.Log("entered");
    }
    private void OnMouseDrag()
    {
        Debug.Log("dragged");
        mouseposition = cam.ScreenToWorldPoint(Input.mousePosition);
        boxtransform.position = new Vector3(mouseposition.x, mouseposition.y, 0);
    }
    private void OnMouseExit()
    {
        Debug.Log("exited");
    }
}

