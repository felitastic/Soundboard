using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Scriptable SFX Object containing prefab and other info
/// </summary>//

[CreateAssetMenu(fileName = "SFX", menuName = "ScriptableObjects/SFX")]
public class SFX : ScriptableObject
{
    public Sprite ButtonImg;
    public string ButtonText;
    public AudioClip Soundclip;
}
