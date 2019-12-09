using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ButtonControl : MonoBehaviour
{
    private Button thisButton;
    private Image buttonImage;
    private Text buttonText;
    private AudioClip buttonSound;
    private AudioSource mainAudioSource;

    private void Awake()
    {
        thisButton = GetComponentInChildren<Button>();
        buttonImage = thisButton.GetComponent<Image>();
        buttonText = thisButton.GetComponentInChildren<Text>();
    }

    public void SetupButton(SFX sfx, AudioSource mainSource)
    {
        buttonText.text = sfx.ButtonText;
        buttonImage.sprite = sfx.ButtonImg;
        buttonSound = sfx.Soundclip;
        mainAudioSource = mainSource;
    }

    public void ButtonPressed()
    {
        print(thisButton.name + " was pressed");
        mainAudioSource.clip = buttonSound;
        mainAudioSource.Play();
    }   
}
