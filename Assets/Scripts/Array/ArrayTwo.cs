using UnityEngine;

//2���� �迭: ��� ���� �̷���� �迭
public class ArrayTwo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]�迭 ����
        int[,] intarray;

        //[2]�迭 ��Ҽ�(ũ��) ����
        intarray = new int[2, 3];

        //[3]�迭 �ʱ�ȭ
        //0����
        intarray[0,0] = 1;
        intarray[0,1] = 2;
        intarray[0,2] = 3;
        //1����
        intarray[1,0] = 4;
        intarray[1,1] = 5;
        intarray[1, 2] = 6;


        //[4]�迭 ���
        for (int i=0; i<2; i++)
        {
            for(int j=0; j<3; j++)
            {
                Debug.Log(intarray[i,j]);
            }
            Debug.Log("");
        }

    }

}
