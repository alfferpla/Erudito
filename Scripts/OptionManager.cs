using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionManager : MonoBehaviour
{
    [SerializeField] AudioSource source;
    [SerializeField] AudioClip[] musicClips;
    [SerializeField] Slider slider;
    [SerializeField] Dropdown dropdown;
    [SerializeField] GameObject optionPanel;
    [SerializeField] bool isActive;
   public void ChangeVolume()
    {
        source.volume = slider.value; /*iguala el volumen con el sonido*/
    }

  
    public void ChangeMusic()
    {
        /*if(dropdown.value == 0) 
        {
            source.clip = musicClips[0];
        }
        else if(dropdown.value == 1) 
        {
            source.clip = musicClips[1];
        }
        else if (dropdown.value == 2) 
        {
            source.clip = musicClips[2];
        }*/

        for(int i=0; i<musicClips.Length; i++) 
        {
            if(dropdown.value == i) 
            {
                source.clip = musicClips[i];
                source.Play();
            }
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if(optionPanel.activeInHierarchy == false) 
            {
                optionPanel.SetActive(true);
                Time.timeScale = 0;
            }
            else 
            {
                optionPanel.SetActive(false);
                Time.timeScale = 1;
            }
            /*isActive = ¡isActive;
            optionPanel.SetActive(isActive);   estas dos líneas hacen lo mísmo que los if q están en private void, pero sin timescale*/   
        }
    }
}
