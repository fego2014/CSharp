using UnityEngine;

public class SwichNote : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]����
        int x = 1;

        //switch(����) : Data �� �Ǻ�
        switch (x)
        {
            case 1:
                Debug.Log("x�� 1�Դϴ�"); //[2] ���๮1
                break;

            case 2:
                Debug.Log("x�� 2�Դϴ�"); //[3] ���๮2
                break;
        }
        //[4]���๮3
        Debug.Log("���α׷� ����");
    }

}

/*
switch�� : ���ǹ� - ���ù�

switch(����) : Data �� �Ǻ�
{
    case 1��:
        //���๮1
        break;

    case 2��:
        //���๮2
        break;

    case 3��:
        //���๮3
        break;

    default: //��� case�� �ƴϸ�
        //���๮4
        break;
}



if(���ǽ�) : ���ǽ��� ��, ���� �Ǻ�
{
    ���๮1
}
else
{
    ���๮2
}


 */