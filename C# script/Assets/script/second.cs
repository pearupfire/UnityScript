using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class second : MonoBehaviour
{
    //�ؽ�Ʈ ������Ʈ�� ID, lv, exp�� ���� ������ ��ũ��Ʈ �۾��� ���� �־��ְ� �;��.
    public Text id_text;
    public Text lv_text;
    public Text exp_text;

    //����Ƽ �ν����Ϳ��� 1���� 99 ������ ������ ���� �� �� �ִ�. (�� ��)
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
