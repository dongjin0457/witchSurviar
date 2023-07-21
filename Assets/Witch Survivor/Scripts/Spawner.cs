using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemy;

    // points : ������� ��ȯ ����Ʈ���� ������ Transform �迭 ����    
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
        // Random.seed�� ����ؼ� �Ϻ��ϰ� ������ ���� �� �ִ� : ���� �ð��� ������
        // ������ ��ġ�� ��ȯ
        GameObject newEnemy = Instantiate(enemy, points[Random.Range(1, points.Length)]);
        newEnemy.transform.SetParent(null);
    }
}
