using UnityEngine;

//�ȳ��ϼ��� 3�� ����ϴ� ���α׷�
public class DoWhile : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]�ʱ��
        int i = 4;

        do
        {
            //�ݺ����๮
            Debug.Log("�ȳ��ϼ���");
            //[2]������
            i++;
        }
        while (i < 3); //[3]���ǽ�

    }

}

/*
dowhile �� - �ݺ���
���� �ݺ� ���๮�� 1�� �����Ѵ�
���ǽ��� true�̸� �ݺ����� �����Ѵ�
���ǽ��� fase�̸� while���� �����Ѵ�

do
{
    //�ݺ� ���๮
} while (���ǽ�)

 */