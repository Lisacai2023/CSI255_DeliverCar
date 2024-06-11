using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackageColor = new Color32(1,1,1,1);
    [SerializeField] Color32 noPackageColor = new Color32(1,1,1,1);

    [SerializeField] float destroyDelay = 0.5f;
    bool hasPackage;
    SpriteRenderer spriteRenderer;
    public AudioSource Crash;
    public AudioSource Finish;


    public void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();


        Crash = gameObject.GetComponent<AudioSource>();
        Finish = gameObject.GetComponent<AudioSource>();


    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Watch out!");
    
    }
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && hasPackage == false)
        {
            Debug.Log("Package picked up");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            //SoundManagerScript.PlaySound("Crash");
            Crash.Play();
            Destroy(other.gameObject, destroyDelay);
        }

        if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package Delivered");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
            SoundManagerScript.PlaySound("Finish");
            Finish.Play();
 
        }

    }
}
