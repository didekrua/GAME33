using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 10f; // 회전 속도
    public float radius = 5f; // 원통의 반지름
    public float height = 10f; // 원통의 높이

    public Vector3 centerPosition; // 원통의 중심 위치

    private float angle = 0f; // 현재 각도

    private void Start()
    {
        transform.position = centerPosition; // 초기 위치를 원통의 중심으로 설정
    }

    private void Update()
    {
        angle += rotationSpeed * Time.deltaTime; // 회전 각도를 업데이트

        // 원통형 회전을 위한 위치 계산
        float x = centerPosition.x + Mathf.Cos(angle) * radius;
        float y = centerPosition.y + Mathf.Sin(angle) * height;
        float z = centerPosition.z + Mathf.Sin(angle) * radius;

        transform.position = new Vector3(x, y, z); // 위치 업데이트
    }
}