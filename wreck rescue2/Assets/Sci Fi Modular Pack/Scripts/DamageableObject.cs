using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageableObject : MonoBehaviour
{
    public GameObject particleEffect; // �ڽ� ��ƼŬ ����Ʈ ���� ������Ʈ
    public float effectDuration = 15f; // ����Ʈ ���� �ð�

    private bool isDamaged = false; // �������� �޾Ҵ��� ����

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Damage")) // �������� ������ ������Ʈ���� �浹�� ����
        {
            if (!isDamaged)
            {
                isDamaged = true;
                ActivateParticleEffect();
                Invoke("DeactivateParticleEffect", effectDuration); // ���� �ð��� ���� �� ����Ʈ ��Ȱ��ȭ
            }
        }
    }

    private void ActivateParticleEffect()
    {
        if (particleEffect != null)
        {
            particleEffect.SetActive(true); // ��ƼŬ ����Ʈ Ȱ��ȭ
        }
    }

    private void DeactivateParticleEffect()
    {
        if (particleEffect != null)
        {
            particleEffect.SetActive(false); // ��ƼŬ ����Ʈ ��Ȱ��ȭ
        }
    }
}