using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ChangeMusicVolumn : MonoBehaviour {


    public Slider Volume;
    public AudioSource myMusic;

	// Update is called once per frame
	void Update () {
        myMusic.volume = Volume.value;

	}
}
