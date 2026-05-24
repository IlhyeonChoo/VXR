using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float speed = 8f;
    Rigidbody playerRigidbody;
    public float health = 5f;
    public Slider healthSlider;
    void Start()    // 게임이 실행되면 딱 한번 (자동으로) 실행되는 함수
    {
        playerRigidbody = this.GetComponent<Rigidbody>();
        healthSlider = this.GetComponentInChildren<Slider>();
        healthSlider.maxValue = health;
        healthSlider.value = health;
    }

    void Update()   // 매 프레임 한번씩 (자동으로) 실행되는 함수
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0, zSpeed);
        playerRigidbody.linearVelocity = newVelocity;

    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        healthSlider.value = health;
        if (health <= 0)
        {
            Die();
        }
    }
    public void Die()
    {
        this.gameObject.SetActive(false);
        GameManager gameManager = FindAnyObjectByType<GameManager>();
        gameManager.EndGame();
    }
}
