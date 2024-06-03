using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    public static AudioClip CrashSound, FinishSound;
    static AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        CrashSound = Resources.Load<AudioClip>("Crash");
        FinishSound = Resources.Load<AudioClip>("Finish");
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public static void PlaySound( string clip)
    {
        switch (clip){
        case "Crash" :
            audioSource.PlayOneShot(CrashSound);
            break;
        case "Finish" :
            audioSource.PlayOneShot(FinishSound);
            break;
        }
    }




}
