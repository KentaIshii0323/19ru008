using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class herocontoroller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject ballPrefab;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey (KeyCode.W)){
            transform.Translate(0,0.05f,0);
        }
        
        if(Input.GetKey (KeyCode.A)){
            transform.Translate(-0.05f,0,0);
        }
        
        if(Input.GetKey (KeyCode.S)){
            transform.Translate(0,-0.05f,0);
        }
        
        if(Input.GetKey (KeyCode.D)){
            transform.Translate(0.05f,0,0);
        }
        if (Input.GetKeyDown (KeyCode.Space)) {
			Instantiate (ballPrefab, transform.position, Quaternion.identity);
		}
    }
}
