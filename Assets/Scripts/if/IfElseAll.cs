using UnityEngine;

public class IfElseAll : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //�ϳ��� ������ �Է� �޾Ƽ� ¦���Ǻ�

        int number = 4;

        //¦�� �Ǻ���
        if (number % 2 ==0)
        {
            Debug.Log($"{number}�� ¦���Դϴ�");
        }

        //Ȧ�� �Ǻ���
        if (number %2 !=0)
        {
            Debug.Log($"{number}�� Ȧ���Դϴ�");
        }
        else
        {
            Debug.Log($"{number}�� ¦���Դϴ�");
        }

        //3�� ���, 5�� ���, 7�� ��� �Ǻ���
        if (number %3 ==0)
        {
            Debug.Log($"{number}�� 3�� ����Դϴ�.");
        }
        else if (number % 5==0)
        {
            Debug.Log($"{number}�� 5�� ����Դϴ�.");
        }
        else if (number % 7==0)
        {
            Debug.Log($"{number}�� 7�� ����Դϴ�.");
        }
        else
        {
            Debug.Log($"{number}�� 3,5,7�� ����� �ƴմϴ�.");
        }
    }

}
