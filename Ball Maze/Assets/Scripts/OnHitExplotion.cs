using UnityEngine;
using System.Collections;

public class OnHitExplotion : MonoBehaviour {

    public AudioSource source;
    public AudioClip clip;
    MusicScript ms;

    void Awake()
    {
        source = GetComponent<AudioSource>();
        ms = GameObject.Find("MusicManager").GetComponent<MusicScript>();
        source.volume = 0.3f;

    }

	// Update is called once per frame
	void OnCollisionEnter (Collision col) {

        ms.gamePlay.Stop();
        ms.gameLose.Play();
        source.Play();
	}
}