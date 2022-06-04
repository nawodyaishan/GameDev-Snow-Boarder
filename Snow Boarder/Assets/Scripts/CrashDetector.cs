using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] private float crashDelay;

    [SerializeField] private ParticleSystem crashEffect;

    [SerializeField] private GameObject head;

    [SerializeField] private GameObject player;
    private AudioSource crashSound;

    private bool hasCrashed = false;

    //[SerializeField] private AudioClip crashSFX;

    // Start is called before the first frame update
    void Start()
    {
        crashSound = player.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && !hasCrashed)
        {
            hasCrashed = true;
            Debug.Log("Crashed");
            headRed();
            crashEffect.Play();
            Invoke(nameof(CrashReloadingScene), crashDelay);
            crashSound.Play();
            FindObjectOfType<PlayerController>().DisableControls();

            // GetComponent<AudioSource>().PlayOneShot(crashSFX);
        }
    }

    void CrashReloadingScene()
    {
        SceneManager.LoadScene("Level1");
    }

    void headRed()
    {
        SpriteRenderer sp = head.GetComponent<SpriteRenderer>();
        sp.color = Color.red;
    }



}