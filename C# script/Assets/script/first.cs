using System.Collections;
using System.Collections.Generic;
using UnityEngine; //유니티 엔진에 있는 기능을 사용한다.

public class NewBehaviourScript : MonoBehaviour
    //MonoBehaviour이 연결되어있다.
    //MonoBehavior는 유니티에서 사용하는 기능들을 모아놓은 클래스
    //연결x = 유니티의 오브젝트에 연결 할 수 없다
{
    //일반 c#에서는 Main 함수를 통해 실행을 진행했다면
    //유니티의 스크립트는 라이프 사이클에 의해 정해진 위치에 코드를 설계하고
    //유니티 엔진을 실행하는 것으로 작업을 진행한다.

    public int count = 0;       //유니티 엔진에서 수정이 가능하고 보인다.
    private float value = 2.0f; //유니티 엔진에서 수정 불가, 보이지 않는다.

    // Start is called before the first frame update
    // 첫 프레임 시작 시 호출되는 함수
    void Start()
    {
        Debug.Log("첫 프레임에서 start를 시작 하겠습니다."); // c# Console.WriteLine 과 동일   
    }

    // Update is called once per frame
    // 프레임마다 실질적인 동작 등을 구현 해야 하는 위치
    // 핵심 로직 등이 작성 되는 위치 
    // 계속 반복한다
    void Update()
    {
        count++;
        Debug.Log(count);
    }
}
