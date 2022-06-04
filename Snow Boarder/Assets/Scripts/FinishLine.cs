using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] private float delay;

    [SerializeField] private ParticleSystem finishEffect;

    private AudioSource finishSound;

    // Start is called before the first frame update
    void Start()
    {
        finishSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            Debug.Log("You Finished");
            finishEffect.Play();
            Invoke(nameof(ReloadingScene), delay);
            finishSound.Play();
        }
    }

    void ReloadingScene()
    {
        SceneManager.LoadScene("Level1");
    }
} // Class 