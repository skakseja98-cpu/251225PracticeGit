using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float SpawnRate = 0.5f;
    float timer = 0f;

    void Start()
    {
        
    }

    void Update()
    {
        // 시간더하기
        timer += Time.deltaTime;

        // 시간이 다됐는지 확인
        if (timer >= SpawnRate)
        {
            timer = 0f;
            Fire();
        }

        transform.Rotate(0, 0, 0.3f);
    }

    void Fire()
    {
        GameObject newBullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
    }
}
