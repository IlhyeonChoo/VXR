using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 8f;

    Rigidbody rb;
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();

        rb.linearVelocity = transform.forward * speed;

        Destroy(this.gameObject, 3f); // 3초 뒤에 이 총알 오브젝트를 제거하겠다.
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            PlayerController playerController = other.gameObject.GetComponent<PlayerController>();
            if (playerController != null)
            {
                playerController.Die();
            }
        }
    }
}
