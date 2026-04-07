using UnityEngine;

public class Rotator : MonoBehaviour
{    
    public float rotationSpeed = 60f; // 회전 속도
    void Start()
    {
        
    }

    void Update()
    {
        this.transform.Rotate(0f, rotationSpeed * Time.deltaTime, 0f); // 매 프레임마다 Y축을 기준으로 회전한다.
    }
}
