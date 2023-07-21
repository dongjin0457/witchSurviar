using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy;

    // points : 만들었던 소환 포인트들을 저장할 Transform 배열 변수    
    private Transform[] points = null;

    private void Awake()
    {
        points = GetComponentsInChildren<Transform>();
    }

    private void Start()
    {
        InvokeRepeating("Spawn", 2f, 1f);
    }

    private void Spawn()
    {
        // Random.seed를 사용해서 완벽하게 난수를 만들 수 있다 : 현재 시간을 넣으면
        // 랜덤한 위치에 소환
        GameObject newEnemy = Instantiate(enemy, points[Random.Range(1, points.Length)]);
        newEnemy.transform.SetParent(null);
    }
}
