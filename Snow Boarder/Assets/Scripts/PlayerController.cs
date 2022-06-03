using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject player;

    private Rigidbody2D rigid2D;

    [SerializeField] private float torqueMagnitude;

    // Start is called before the first frame update
    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        AddTorqueInput();
    }

    void AddTorqueInput()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigid2D.AddTorque(Time.deltaTime * torqueMagnitude);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rigid2D.AddTorque((-1) * Time.deltaTime * torqueMagnitude);
        }
    }
} // Class