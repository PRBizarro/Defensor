using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour {

	public Sound[] sounds;


	// Use this for initialization
	void Awake () {
		foreach (Sound s in sounds)
		{
			s.source = gameObject.AddComponent<AudioSource>();
			s.source.clip = s.clip;
			s.source.volume = s.volume;
			s.source.pitch = s.pitch;
			s.source.loop = s.loop;
		}
	}

	void Start()
	{
		FindObjectOfType<AudioManager>().Play("Tema");
	}
	
	public void Play (string name) 
	{
		Sound s = Array.Find(sounds, sounds => sounds.name == name);
		s.source.Play();
	}
}
