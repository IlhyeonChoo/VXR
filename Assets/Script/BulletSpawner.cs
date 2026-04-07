using UnityEngine;
using Random = UnityEngine.Random;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab; // 우리가 생성할 탄환 Prefab에 대한 참조
    public float spawnRateMin = 0.5f;
    public float spawnRateMax = 3f;

    Transform target; // Player의 위치
    float spawnRate;
    float timeAfterSpawn; // 스폰 타이머

    void Start()
    {
        timeAfterSpawn = 0f;
        spawnRate = Random.Range(spawnRateMin, spawnRateMax); // 스폰 간격을 랜덤으로 설정
        target = FindFirstObjectByType<PlayerController>().transform; // PlayerController 스크립트가 붙어있는 오브젝트를 찾아서 그 위치를 타겟으로 설정
    }

    // Update is called once per frame
    void Update()
    {
        timeAfterSpawn += Time.deltaTime; // 매 프레임마다 타이머에 경과한 시간만큼 더해준다.
        if(timeAfterSpawn >= spawnRate) // 타이머가 스폰 간격보다 커지면
        {
            timeAfterSpawn = 0f; // 타이머 초기화

            GameObject bullet = Instantiate(bulletPrefab,
            this.transform.position, this.transform.rotation); // bulletPrefab을 현재 오브젝트의 위치와 회전으로 생성한다.
            bullet.transform.LookAt(target); // 생성된 총알이 타겟을 바라보도록 회전시킨다.

            spawnRate = Random.Range(spawnRateMin, spawnRateMax); // 다음 스폰 간격을 랜덤으로 설정한다.
        }
    }
}
