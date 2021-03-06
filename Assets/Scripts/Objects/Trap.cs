﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

/// <summary>
/// Makes the object kill the player, reloading the level upon collision.
/// </summary>
public class Trap : Object
{
    public AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        if(name == null)
        {
            name = "Trap";
        }
        else
        {
            name += "Trap";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Player")) //Upon colliding with a trap, reset the level
        {
            source.Play();
            Scene currScene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(currScene.buildIndex);
        }
    }
}
