using Unity.Mathematics;
using UnityEngine;

public class FunctionMaxMin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int result = Max(3, 5);
        Debug.Log(result);

    }

    
    int Max(int x, int y)
    {
        /*
        if (x < y)
        {
            return y;
        }
        else
        {
            return x;
        }
        */

        /*
        int max = (x > y) ? x : y;
        return max;
        */

        return (x > y) ? x : y;
    }


    //[2]�Ű������� �Է� ���� �ΰ��� ������ ���� ���� ��ȯ�ϴ� �Լ�
    int Getmin(int x, int y)
    {
        if (x < y)
        {
            return x;
        }
        else
        {
            return y;
        }
    }
}

/*
 
[Q]
1. �Ű������� �Է¹��� �ΰ��� ������ ū���� ��ȯ�ϴ� �Լ�
2. �Ű������� �Է¹��� �ΰ��� ������ �������� ��ȯ�ϴ� �Լ�
3. 3,5�� �Է¹޾� ū ���� ����ϱ�
4. -3,-5�� �Է¹޾� ���� ���� ����ϱ�

[output]
3�� 5�� ū ���� (��ȯ��)�̴�
-3�� -5�� ���� ���� (��ȯ��)�̴�

 */