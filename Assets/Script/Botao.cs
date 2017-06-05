using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Botao : MonoBehaviour {

	public void Play() 
	{
		SceneManager.LoadScene("scene1");
	}

	public void Menu() 
	{
		SceneManager.LoadScene("menu");
	}

}
