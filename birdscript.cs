using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength; // how much force to apply to the bird when it flaps
    public LogicScript logic;
    public bool birdIsAlive = true;
    private AudioSource backgroundMusic;


    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        backgroundMusic = GetComponent<AudioSource>(); // Get the AudioSource component attached to the bird

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        birdIsAlive = false;

        if (backgroundMusic != null && backgroundMusic.isPlaying)
            {
                backgroundMusic.Stop(); // Stop the background music when the bird dies
            }
    }
}
