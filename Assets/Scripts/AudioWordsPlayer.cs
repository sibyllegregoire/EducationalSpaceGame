using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.EventSystems;
public class AudioWordsPlayer : MonoBehaviour
{

    public Transform Image_Changer;

    public void PlayWord()
    {
        Debug.Log("hi julian");
        Debug.Log(Image_Changer.GetComponent<SpriteRenderer>().sprite.name);
        AudioClip clip = Resources.Load<AudioClip>("wordSounds/" + Image_Changer.GetComponent<SpriteRenderer>().sprite.name);
        GetComponent<AudioSource>().PlayOneShot(clip);
    }
}
