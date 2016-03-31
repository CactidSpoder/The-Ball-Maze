using UnityEngine;
using System.Collections;

public class CameraFollowScript : MonoBehaviour {

    private Transform player;
	// Use this for initialization
	void Awake () {

        player = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {

        try {
            transform.position = new Vector3(player.position.x, player.position.y + 15, player.position.z - 5);
        }
        catch(MissingReferenceException e)
        {

        }
	}
}
