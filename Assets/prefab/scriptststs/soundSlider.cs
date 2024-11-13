using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;


public class soundSlider : MonoBehaviour
{
  
   [SerializeField] private AudioMixer _masterMixer;
   [SerializeField] private SoundGroup _groupName;
   [SerializeField] private Slider _volumeSlider;
     private float _volume;

    private void Start()
    {
        _volume = PlayerPrefs.GetFloat(_groupName.ToString());
        _masterMixer.SetFloat(_groupName.ToString(), _volume);
        _volumeSlider.value = _volume;
    }


    private void OnDisable()
    {
        PlayerPrefs.GetFloat(_groupName.ToString(), _volume);
    }


    public void ChangeVolume(float volume)

    {
        _masterMixer.SetFloat(_groupName.ToString(), volume);
    }

}
