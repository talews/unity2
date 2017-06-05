using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour {
    public GameObject barreiraPrefab; //objeto a ser spawnado
    public float ratespwan; //Intervalo de Spwan
    public float currentTime;
    private int posicao;
    private float y; 
	public List<Sprite> list;


    // Use this for initialization
    void Start () {
        currentTime = 0;
	}
	
	// Update is called once per frame
	void Update () {
        currentTime += Time.deltaTime;
        if (currentTime >= ratespwan)
        {
            currentTime = 0;
            posicao = Random.Range(1,100);


            if (posicao > 50)
            {
                y = -0.743f;

            }
            else
            {
                y = -0.04f;
            }
            Debug.Log(posicao);
            GameObject tempPrefab = Instantiate(barreiraPrefab) as GameObject;
            tempPrefab.transform.position = new Vector3(transform.position.x,y,tempPrefab.transform.position.z);

			if(tempPrefab.CompareTag("presente"))
				tempPrefab.GetComponent<SpriteRenderer> ().sprite = list [Random.Range (0, list.Count - 1)];
        }
	}
}
