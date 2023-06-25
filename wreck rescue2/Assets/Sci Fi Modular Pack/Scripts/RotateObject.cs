using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    public float rotationSpeed = 10f; // ȸ�� �ӵ�
    public float radius = 5f; // ������ ������
    public float height = 10f; // ������ ����

    public Vector3 centerPosition; // ������ �߽� ��ġ

    private float angle = 0f; // ���� ����

    private void Start()
    {
        transform.position = centerPosition; // �ʱ� ��ġ�� ������ �߽����� ����
    }

    private void Update()
    {
        angle += rotationSpeed * Time.deltaTime; // ȸ�� ������ ������Ʈ

        // ������ ȸ���� ���� ��ġ ���
        float x = centerPosition.x + Mathf.Cos(angle) * radius;
        float y = centerPosition.y + Mathf.Sin(angle) * height;
        float z = centerPosition.z + Mathf.Sin(angle) * radius;

        transform.position = new Vector3(x, y, z); // ��ġ ������Ʈ
    }
}