using UnityEngine;

//������ �迭: �迭�� ���̰� �����̴�
public class ArrayTwo3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 2���� �迭 ����: (�������� ���)ù��° ��Ҽ�(ũ��)�� ����
        int[][] intarray= new int[2][];

        //[2] 2���� �迭 (�ι�°)��Ҽ�(ũ��) ���� ���� �����Ѵ�, �ʱ�ȭ
        intarray[0] = new int[3] { 1, 2, 3 };
        intarray[1] = new int[2] { 4, 5 };

        //* ������ �迭�� ���̴� ù��° ��Ҽ��� ���̸�
        Debug.Log($"�迭�� ����: {intarray.Length}"); //2


        //[4] 2���� �迭 ����ϱ�
        for(int i=0; i< intarray.Length; i++)
        {
            for(int j=0; j< intarray[i].Length; j++)
            {
                Debug.Log(intarray[i][j]);
            }
            Debug.Log("========");
        }
    }

}
