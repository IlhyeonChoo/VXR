using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public Rigidbody rb;
    public ForceData forceData;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()    // 게임이 실행되면 딱 한번 (자동으로) 실행되는 함수
    {
        rb.AddForce(0, forceData.forceAmount, 0);
        forceData.GetDistance();
    }

}
