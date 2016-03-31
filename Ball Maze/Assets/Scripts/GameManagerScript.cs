using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour {

    public int flowerCount;

	// Use this for initialization
	void Start () {
        flowerCount = 4;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.R))
			SceneManager.LoadScene(0); //or whatever number your scene is
	}
}
