using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecenario : MonoBehaviour {


    private Material materialatual;
    public float velocidadeX, VelocidadeY;
    private float escalademovimento;
	public int orderInLayer;
    
	// Use this for initialization
	void Start () {
		Renderer r = GetComponent<Renderer> ();
        materialatual = r.material;
		r.sortingOrder = orderInLayer;
	}
	
	// Update is called once per frame
	void Update () {
        escalademovimento = escalademovimento + 0.01f;
        materialatual.SetTextureOffset("_MainTex", new Vector2(escalademovimento * velocidadeX, escalademovimento * VelocidadeY));

	}
}
