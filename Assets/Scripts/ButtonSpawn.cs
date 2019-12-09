using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSpawn : MonoBehaviour
{
    public AudioSource MainAudioSource;
    public GameObject ButtonPrefab;
    public SFX[] SFXprefab;

    private void Start()
    {
        StartCoroutine(SpawnButtons());
    }

    IEnumerator SpawnButtons()
    {
        if (SFXprefab == null)
        {
            print("No SFX found");
            yield break;
        }

        for (int i = 0; i < SFXprefab.Length; i++)
        {
            GameObject button  = Instantiate(ButtonPrefab, this.gameObject.transform);
            button.name = "Button_No" + i;
            button.GetComponentInChildren<ButtonControl>().SetupButton(SFXprefab[i], MainAudioSource);
        }

        yield return null;
    }
}
