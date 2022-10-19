using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballcontoroller : MonoBehaviour
{
    //AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0.03f, 0);

        if(transform.position.y > 5){
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D coll) {
        //audioSource.Play();
		Destroy (coll.gameObject);
		Destroy (gameObject);
	}
}
