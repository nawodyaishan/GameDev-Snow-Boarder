using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject player;

    private Rigidbody2D _rigid2D;

    [SerializeField] private float torqueMagnitude;
    [SerializeField] private float highSpeed;

    private SurfaceEffector2D _sf2d;

    // Start is called before the first frame update
    void Start()
    {
        _rigid2D = GetComponent<Rigidbody2D>();
        _sf2d = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        AddTorqueInput();
        RespondToBoost();
    }

    private void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _sf2d.speed = highSpeed;
            
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            _sf2d.speed = 23f;
        }
    }

    void AddTorqueInput()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rigid2D.AddTorque(Time.deltaTime * torqueMagnitude);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            _rigid2D.AddTorque((-1) * Time.deltaTime * torqueMagnitude);
        }
    }
    
    
} // Class