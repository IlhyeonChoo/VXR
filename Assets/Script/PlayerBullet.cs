using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
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
        if (other.gameObject.tag == "Bullet")
        {
            Destroy(this.gameObject);
        }

        if (other.gameObject.tag == "BulletSpawner")
        {
                BulletSpawner bulletSpawner = other.gameObject.GetComponent<BulletSpawner>();
                if (bulletSpawner != null)
                {
                    bulletSpawner.TakeDamage(1f); // 총알 스포너에게 1의 피해를 입힌다.
                }
                Destroy(this.gameObject);
        }

        if (other.gameObject.tag == "Wall")
        {
            Destroy(this.gameObject);
        }
    }
}
