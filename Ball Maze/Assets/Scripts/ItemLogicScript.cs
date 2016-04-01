using UnityEngine;
using System.Collections;

public class ItemLogicScript : MonoBehaviour
{
    GameManagerScript gms;
    public string objectName;
    MusicScript ms;

    void Awake()
    {
        gms = GameObject.Find("GameManager").GetComponent<GameManagerScript>();
        ms = GameObject.Find("MusicManager").GetComponent<MusicScript>();
    }

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(GameObject.Find(objectName));
            gms.flowerCount--;
            gms.UpdateUI();
            Destroy(gameObject);

            if(gms.flowerCount == 0)
            {
                ms.gamePlay.Stop();
                ms.gameWin.Play();
                gms.Win();
                PlayerMovement pm = GameObject.Find("Sphere").GetComponent<PlayerMovement>();

                pm.moveSpeed = 0;
                pm.Freeze();
            }
        }
    }
}
