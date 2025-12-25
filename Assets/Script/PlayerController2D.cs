using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2D : MonoBehaviour
{

    public float speed = 5f; // 이동속도
    Rigidbody2D rb; // Rigidbody2D 컴포넌트 변수

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // 게임 시작 시 Rigidbody2D 컴포넌트 가져오기
    }

    void Update()
    {
        // 키보드 입력 
        float x = Input.GetAxis("Horizontal"); // 좌우 -1  ~ 1
        float y = Input.GetAxis("Vertical");  // 상하 -1  ~ 1

        // 이동 벡터 계산
        Vector2 dir = new Vector2(x, y);

        // 속도 적용
        rb.linearVelocity = dir * speed;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("충돌!");

        Destroy(gameObject);
    }
}
