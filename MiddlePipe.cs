using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MiddlePipe : MonoBehaviour
{
    public LogicScript logic;
    AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>(); // Get the logic script
    }

    // Update is called once per frame
    void Update()
    {
    }

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 3)
        {
            logic.AddScore(1);
            source.Play();
        }
    }
}
