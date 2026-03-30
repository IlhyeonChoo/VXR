using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour
{
    public float speed = 8f;
    Rigidbody playerRigidbody;
    void Start()    // 게임이 실행되면 딱 한번 (자동으로) 실행되는 함수
    {
        playerRigidbody = this.GetComponent<Rigidbody>();
    }

    void Update()   // 매 프레임 한번씩 (자동으로) 실행되는 함수
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0, zSpeed);
        playerRigidbody.linearVelocity = newVelocity;

        /*if (Input.GetKey(KeyCode.W))
        {
            playerRigidbody.linearVelocity  = new Vector3(0, 0, speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerRigidbody.linearVelocity = new Vector3(0, 0, -speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerRigidbody.linearVelocity = new Vector3(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerRigidbody.linearVelocity = new Vector3(speed, 0, 0);
        }*/
    }
}
