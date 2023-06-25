using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldEventCounter : MonoBehaviour
{
    public int eventCount = 0; // �̺�Ʈ ī��Ʈ ����

    private void Start()
    {
        // ���� ���� �� �̺�Ʈ ī��Ʈ �ʱ�ȭ
        eventCount = 0;
    }

    public void IncrementEventCount()
    {
        // �̺�Ʈ ī��Ʈ ����
        eventCount++;
    }

    public void ResetEventCount()
    {
        // �̺�Ʈ ī��Ʈ �ʱ�ȭ
        eventCount = 0;
    }
}