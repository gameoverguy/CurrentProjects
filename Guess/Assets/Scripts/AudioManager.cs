using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
	public AudioSource UIAudioSource;
	public GameObject manager;
	public AudioClip GenericButtonClick;
	public AudioClip CorrectButtonClick;
	public AudioClip WrongButtonClick;
	
	private Parameters parameter;
	
	void Awake()
	{
		parameter = manager.GetComponent<Parameters>();
	}
	
	public void PlayGenericButtonClick()
	{
		UIAudioSource.clip = GenericButtonClick;
		UIAudioSource.Play();
	}
	
	public void PlayCorrectButtonClick()
	{
		//UIAudioSource.clip = CorrectButtonClick;
		
		if( UIAudioSource.isPlaying == true)
		{
			return;
		}
		else 
		{
			//UIAudioSource.Play();
			UIAudioSource.PlayOneShot(CorrectButtonClick);
		}

	}
	
	public void PlayWrongButtonClick()
	{
		//UIAudioSource.clip = WrongButtonClick;
		
		if( UIAudioSource.isPlaying == true)
		{
			return;
		}
		else 
		{
			//UIAudioSource.Play();
			UIAudioSource.PlayOneShot(WrongButtonClick);
		}
	}
	
	public void ToggleSound()
	{
		if(UIAudioSource.mute)
		{
			UIAudioSource.mute = false;
			parameter.MuteIcon.SetActive(false);
		}
		else
		{
			UIAudioSource.mute = true;
			parameter.MuteIcon.SetActive(true);
		}
	}
	
}
