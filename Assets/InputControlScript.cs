using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControlScript : MonoBehaviour
{
    public GameObject upCube;
    public GameObject downCube;
    public GameObject leftCube;
    public GameObject rightCube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            upCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            upCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }
        
        if (Input.GetKeyDown(KeyCode.S))
        {
            downCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            downCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }
      
        if (Input.GetKeyDown(KeyCode.A))
        {
            leftCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            leftCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }
      
        if (Input.GetKeyDown(KeyCode.D))
        {
            rightCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            rightCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }
    }
}
