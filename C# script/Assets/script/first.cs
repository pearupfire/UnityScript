using System.Collections;
using System.Collections.Generic;
using UnityEngine; //����Ƽ ������ �ִ� ����� ����Ѵ�.

public class NewBehaviourScript : MonoBehaviour
    //MonoBehaviour�� ����Ǿ��ִ�.
    //MonoBehavior�� ����Ƽ���� ����ϴ� ��ɵ��� ��Ƴ��� Ŭ����
    //����x = ����Ƽ�� ������Ʈ�� ���� �� �� ����
{
    //�Ϲ� c#������ Main �Լ��� ���� ������ �����ߴٸ�
    //����Ƽ�� ��ũ��Ʈ�� ������ ����Ŭ�� ���� ������ ��ġ�� �ڵ带 �����ϰ�
    //����Ƽ ������ �����ϴ� ������ �۾��� �����Ѵ�.

    public int count = 0;       //����Ƽ �������� ������ �����ϰ� ���δ�.
    private float value = 2.0f; //����Ƽ �������� ���� �Ұ�, ������ �ʴ´�.

    // Start is called before the first frame update
    // ù ������ ���� �� ȣ��Ǵ� �Լ�
    void Start()
    {
        Debug.Log("ù �����ӿ��� start�� ���� �ϰڽ��ϴ�."); // c# Console.WriteLine �� ����   
    }

    // Update is called once per frame
    // �����Ӹ��� �������� ���� ���� ���� �ؾ� �ϴ� ��ġ
    // �ٽ� ���� ���� �ۼ� �Ǵ� ��ġ 
    // ��� �ݺ��Ѵ�
    void Update()
    {
        count++;
        Debug.Log(count);
    }
}
