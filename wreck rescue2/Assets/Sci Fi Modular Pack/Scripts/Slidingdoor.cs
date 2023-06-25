using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slidingdoor : MonoBehaviour
{
    // ��� �����ϱ� ����
    bool flag;

    public GameObject door;

    void Start()
    {
        // �����ִ� ����
        flag = false;
    }

    void Update()
    {

        // ���� ���� ó��
        if (flag == true)
        {
            if (door.transform.position.x >= 0.626f)
            {
                door.transform.Translate(0, 0.01f, 0);
            }
        }

        if (flag == false)
        {
            if (door.transform.position.x < 1.122f)
            {
                door.transform.Translate(0, -0.01f, 0);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        flag = true;
    }
    private void OnTriggerExit(Collider other)
    {
        flag = false;
    }
}