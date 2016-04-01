using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour{

    GameManagerScript gms;
    public float moveSpeed = 10f;
    private Rigidbody rb;

    void Awake()
    {
        gms = GameObject.Find("GameManager").GetComponent<GameManagerScript>();
    }

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update(){
	
	}

	void FixedUpdate () {

		float moveX = Input.GetAxis ("Horizontal");
		float moveZ = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveX, 0f, moveZ);

        rb.AddForce(movement * moveSpeed);

	}

    void OnCollisionEnter(Collision col) {

        if (col.gameObject.name == "Pits")
        {
            gms.Lose();
            Destroy(gameObject);
        }
    }
}
