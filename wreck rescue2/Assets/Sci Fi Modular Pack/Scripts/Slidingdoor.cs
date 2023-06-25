using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slidingdoor : MonoBehaviour
{
    // 도어를 제어하기 위해
    bool flag;

    public GameObject door;

    void Start()
    {
        // 닫혀있는 상태
        flag = false;
    }

    void Update()
    {

        // 문을 여는 처리
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