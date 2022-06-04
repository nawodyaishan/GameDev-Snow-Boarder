using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

    [SerializeField] private float delay; 
    
    // Start is called before the first frame update
    void Start()
    {
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
            Invoke(nameof(ReloadingScene), delay);
        }
        
    }

    void ReloadingScene()
    {
        SceneManager.LoadScene("Level1");
    }
    
    
} // Class 