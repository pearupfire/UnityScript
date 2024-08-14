using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class second : MonoBehaviour
{
    //텍스트 컴포넌트에 ID, lv, exp에 대한 내용을 스크립트 작업을 통해 넣어주고 싶어요.
    public Text id_text;
    public Text lv_text;
    public Text exp_text;

    //유니티 인스팩터에서 1에서 99 사이의 범위를 선택 할 수 있다. (휠 바)
    public string id; 
    [Range(1,99)] public int level;
    [Range(0.0f, 100.0f)] public float exp;

    private void Update()
    {
        id_text.text = id;
        lv_text.text = level.ToString();
        exp_text.text = exp.ToString();
    }


}
