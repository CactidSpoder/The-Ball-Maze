using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour {

    public Text flowersLeft;
    public Text winOrLose;
    public int flowerCount;

	// Use this for initialization
	void Start ()
    {
        flowerCount = 4;
        UpdateUI();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.R))
			SceneManager.LoadScene(0); //or whatever number your scene is
	}

    public void UpdateUI()
    {
        flowersLeft.text = "Flowers to Collect: " + flowerCount.ToString();
        winOrLose.text = "";
    }

    public void Win()
    {
        flowersLeft.text = "";
        winOrLose.text = "U WIN";
    }

    public void Lose()
    {
        flowersLeft.text = "";
        winOrLose.text = "U LOSE";
    }
}
