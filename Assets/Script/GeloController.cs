using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeloController : MonoBehaviour {
	public Rigidbody2D rb;
	public float velocity;
    private float x;
	// Use this for initialization
	void Start () {
		//rb = GetComponent<Rigidbody2D>();  //movimentação com Rigbody
		//Destroy (this, 4);

	}
	
	// Update is called once per frame
	void Update () {
        //movimentation ();
        x = transform.position.x;
        x += velocity * Time.deltaTime;
        transform.position = new Vector3(x, transform.position.y,transform.position.z);
        
        if (x <= -7)
        {
            Destroy(transform.gameObject);
          
        }
	}

	//void movimentation ()
	//{
	//	rb.position -= new Vector2 (velocity, 0);

	//}
}
