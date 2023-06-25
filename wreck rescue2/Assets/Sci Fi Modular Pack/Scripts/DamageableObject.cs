using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageableObject : MonoBehaviour
{
    public GameObject particleEffect; // 자식 파티클 이펙트 게임 오브젝트
    public float effectDuration = 15f; // 이펙트 지속 시간

    private bool isDamaged = false; // 데미지를 받았는지 여부

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Damage")) // 데미지를 입히는 오브젝트와의 충돌을 감지
        {
            if (!isDamaged)
            {
                isDamaged = true;
                ActivateParticleEffect();
                Invoke("DeactivateParticleEffect", effectDuration); // 일정 시간이 지난 뒤 이펙트 비활성화
            }
        }
    }

    private void ActivateParticleEffect()
    {
        if (particleEffect != null)
        {
            particleEffect.SetActive(true); // 파티클 이펙트 활성화
        }
    }

    private void DeactivateParticleEffect()
    {
        if (particleEffect != null)
        {
            particleEffect.SetActive(false); // 파티클 이펙트 비활성화
        }
    }
}