using System;
using UnityEngine;

public class test001 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] numbers = new int[] { 5, 3, 6, 8, 9 }; // �ּҰ��� ���� ���ڵ��� �迭�� �ʱ�ȭ
        int minValue = numbers[0]; // �迭�� ù ��° ���� �ּҰ����� �����ϰ� ����

        // ��� ���ڸ� ��ȸ�ϸ� �ּҰ��� ã�� �ݺ���
        for (int i = 1; i < numbers.Length; i++) // �迭�� �� ��° ��Һ��� ������ ��ұ��� Ȯ��
        {
            if (numbers[i] < minValue) // ���� �ε����� ���� ��������� �ּҰ����� �۴ٸ�
            {
                minValue = numbers[i]; // �ּҰ��� ���� �ε����� ������ ����
            }
        }

        // ��� ���
        Debug.Log("�ּҰ�: " + minValue + "�Դϴ�"); // ã�� �ּҰ��� ���
    }

    
}
