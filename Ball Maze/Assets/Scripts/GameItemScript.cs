using UnityEngine;
using System.Collections;

public class GameItemScript : MonoBehaviour {

    GameManagerScript gms;
    private RaycastHit hit;
    public GameObject character;

    public bool Move = true;    ///gives you control in inspector to trigger it or not
    public Vector3 MoveVector = Vector3.up; //unity already supplies us with a readonly vector representing up and we are just chaching that into MoveVector
    public float MoveRange = 1.0f; //change this to increase/decrease the distance between the highest and lowest points of the bounce
    public float MoveSpeed = 1.0f; //change this to make it faster or slower

    private GameItemScript itemScript; //for caching this transform

    Vector3 startPosition; //used to cache the start position of the transform

    // Use this for initialization
    void Start () {

        itemScript = this;
        startPosition = itemScript.transform.position;
        gms = GameObject.Find("GameManager").GetComponent<GameManagerScript>();
    }

    // Update is called once per frame
    void Update () {

        transform.Rotate(0, 100 * Time.deltaTime, 0); //rotates 50 degrees per second around z axis
        if (Move) //bool is checked. See if you can work out whats going on here, for your own enjoyment
            itemScript.transform.position = startPosition + MoveVector * (MoveRange * Mathf.Sin(Time.timeSinceLevelLoad * MoveSpeed) / 4f);

        Vector3 myTransform = character.transform.forward;

        if(Physics.Raycast(transform.position, myTransform, out hit, 20))
        {
            if(hit.collider)
        }

    }
    
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            gms.flowerCount--;
        }
    }
}
