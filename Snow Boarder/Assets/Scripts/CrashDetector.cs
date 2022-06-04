using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    
    [SerializeField] private float crashDelay;
    
    [SerializeField] private ParticleSystem crashEffect;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Crashed");
            crashEffect.Play();
            Invoke(nameof(CrashReloadingScene), crashDelay);
        }
        
    }

    void CrashReloadingScene()
    {
        SceneManager.LoadScene("Level1");
    }
}