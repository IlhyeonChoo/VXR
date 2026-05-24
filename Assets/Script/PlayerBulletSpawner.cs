using UnityEngine;

public class PlayerBulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab; // 우리가 생성할 총환 Prefab을 담는 변수
    public float playerSpawnRate = 1.25f; // 플레이어가 총알을 발사하는 간격

    Transform target; // Player의 위치
    float timeAfterSpawn; // 경과 타이머

    void Start()
    {
        timeAfterSpawn = 0f;
        target = FindFirstObjectByType<PlayerController>().transform; // PlayerController 스크립트가 붙어있는 오브젝트를 찾아서 그 위치를 타겟으로 설정
    }

    // Update is called once per frame
    void Update()
    {
        timeAfterSpawn += Time.deltaTime; // 매 프레임마다 타이머에 경과한 시간만큼 더해준다.
        if (timeAfterSpawn >= playerSpawnRate) // 타이머가 생성 간격보다 커지면
        {
            timeAfterSpawn = 0f; // 타이머 초기화

            for (int i = 0; i < 8; i++)
            {
                /*float angle = i * 45f; // 0, 45, 90, 135, 180, 225, 270, 315
                Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.forward; // 각도에 따른 방향 벡터 계산

                GameObject bullet = Instantiate(bulletPrefab,
                this.transform.position, this.transform.rotation); // bulletPrefab을 현재 오브젝트의 위치와 회전으로 생성한다.
                bullet.transform.LookAt(target.position + direction); // 생성된 총알이 타겟을 바라보도록 회전시킨다.
                */

                float angle = i * 45f; // 0, 45, 90, 135, 180, 225, 270, 315
                Vector3 direction = Quaternion.Euler(0, angle, 0) * Vector3.forward; // 각도에 따른 방향 벡터 계산

                GameObject bullet = Instantiate(bulletPrefab,target.position, Quaternion.identity); // bulletPrefab을 타겟의 위치에 회전 없이 생성한다.
                bullet.transform.LookAt(target.position + direction); // 생성된 총알이 타겟을 바라보도록 회전시킨다.
            }
        }
    }
}
