using UnityEngine;
using System.Collections;

public class OnHitExplotion : MonoBehaviour {

    public AudioSource source;
    public AudioClip clip;

    void Awake()
    {
        source = GetComponent<AudioSource>();
        source.volume = 0.3f;

    }

	// Update is called once per frame
	void OnCollisionEnter (Collision col) {

        source.Play();
	}
}