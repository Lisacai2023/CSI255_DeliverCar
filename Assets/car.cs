using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    [SerializeField]float steerSpeed = 1f;
    [SerializeField]float moveSpeed = 20f;
    [SerializeField]float slowSpeed = 15f;   
    [SerializeField]float boostSpeed = 30f;

    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmout = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0,moveAmout,0);
        
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        moveSpeed = slowSpeed;    
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Boost")
        {
            Debug.Log(" You are boosting!");
            moveSpeed = boostSpeed;
        }
    }






}
