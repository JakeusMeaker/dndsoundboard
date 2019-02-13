using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {

    AudioSource track;

    bool playState = false;

	// Use this for initialization
	void Start () {
        track = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayStop()
    {
        if (!playState)
        {
            track.Play();
        }
        else
        {
            track.Stop();
        }

        playState = !playState;
    }
}
