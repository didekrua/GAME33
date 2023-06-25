using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldEventCounter : MonoBehaviour
{
    public int eventCount = 0; // 이벤트 카운트 변수

    private void Start()
    {
        // 게임 시작 시 이벤트 카운트 초기화
        eventCount = 0;
    }

    public void IncrementEventCount()
    {
        // 이벤트 카운트 증가
        eventCount++;
    }

    public void ResetEventCount()
    {
        // 이벤트 카운트 초기화
        eventCount = 0;
    }
}