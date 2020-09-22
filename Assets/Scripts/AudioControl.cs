using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioControl : MonoBehaviour
{
    public AudioClip intro;
    public AudioClip Ghost_Normal;
    void Start()
    {
        //GetComponent<AudioSource>().loop = true;
        StartCoroutine(PlayAudios());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator PlayAudios()
    {
        GetComponent<AudioSource>().clip = intro;
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(intro.length);
        GetComponent<AudioSource>().clip = Ghost_Normal;
        GetComponent<AudioSource>().Play();
        GetComponent<AudioSource>().loop = true;
    }
}
