using UnityEngine;

public class StringPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 3;
        string s = "Ȧ��";

        Debug.Log($"{3}��(��) {s}�Դϴ�");
    }

}

/*
[Q]
3, Ȧ���� ���� �����ϰ� �����Ѵ�
���ڿ� �������� �̿��ؼ� ����� ������ ����ϱ�
[output]
3��(��) Ȧ���Դϴ�
 */