using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouse : MonoBehaviour
{

    bool IsSwitchOn = false;

    // Update is called once per frame
    void Update()
    {
        // ���콺 Ŭ���ϸ�
        if (Input.GetMouseButtonDown(0)) {

            // ����׿� ���� �߽�
            Debug.DrawRay(this.transform.position, this.transform.forward, Color.red);
            // �÷��̾� ������ 3f ���� ���� �߽�
            Ray ray = new Ray(this.transform.position, this.transform.forward);
            if (Physics.Raycast(ray, 3f))
            {
                // ������ �浹ü ����
                RaycastHit hit;
                Physics.Raycast(ray, out hit);
                // �浹ü �̸��� '' �̰�, �ڵ� �ߺ� ���� ������ ���� IsSwitchOn 
                if ( hit.collider.gameObject.name == "Shield Metall" && !IsSwitchOn) {
                    IsSwitchOn = true;
                    print("DO IT");
                    // �浹ü �ڽ��߿� Animator ������Ʈ�� ������ �ִ¾��� �ִϸ��̼��� ����
                    hit.collider.gameObject.GetComponentInChildren<Animator>().Play("Down");

                    // ���������� �̵�
                    StartCoroutine(NextSceneCRT());
                }
            }
        }
    }

    IEnumerator NextSceneCRT()
    {
        // 2f �� �ڿ�
        yield return new WaitForSeconds(2f);

        // NextScene���� �� �̵�
        UnityEngine.SceneManagement.SceneManager.LoadScene("NextScene");
    }

}
