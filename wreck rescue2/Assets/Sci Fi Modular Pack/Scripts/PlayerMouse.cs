using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouse : MonoBehaviour
{

    bool IsSwitchOn = false;

    // Update is called once per frame
    void Update()
    {
        // 마우스 클릭하면
        if (Input.GetMouseButtonDown(0)) {

            // 디버그용 광선 발싸
            Debug.DrawRay(this.transform.position, this.transform.forward, Color.red);
            // 플레이어 앞으로 3f 길이 광선 발싸
            Ray ray = new Ray(this.transform.position, this.transform.forward);
            if (Physics.Raycast(ray, 3f))
            {
                // 광선에 충돌체 감지
                RaycastHit hit;
                Physics.Raycast(ray, out hit);
                // 충돌체 이름이 '' 이고, 코드 중복 실행 방지를 위한 IsSwitchOn 
                if ( hit.collider.gameObject.name == "Shield Metall" && !IsSwitchOn) {
                    IsSwitchOn = true;
                    print("DO IT");
                    // 충돌체 자식중에 Animator 컴포넌트를 가지고 있는애의 애니메이션을 실행
                    hit.collider.gameObject.GetComponentInChildren<Animator>().Play("Down");

                    // 다음씬으로 이동
                    StartCoroutine(NextSceneCRT());
                }
            }
        }
    }

    IEnumerator NextSceneCRT()
    {
        // 2f 초 뒤에
        yield return new WaitForSeconds(2f);

        // NextScene으로 씬 이동
        UnityEngine.SceneManagement.SceneManager.LoadScene("NextScene");
    }

}
