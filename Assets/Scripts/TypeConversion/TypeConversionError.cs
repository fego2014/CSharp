using UnityEngine;


//TypeConversion (���ĺ�ȯ)
public class TypeConversionError : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]long�� ���� ���� �����ϰ� long�� ������ ������ �ִ� ���� ū���� �����Ѵ�
        long l=long.MaxValue;

        Debug.Log("l�� ��:"+l); //�ܼ�â�� ����϶�

        //[2]int�� ���� i�� �����ϰ� long�� ���� l�� ���� int������ ��ȯ�Ͽ� �����Ѵ�
        //int i = l; //������ �߻��Ѵ�. long�� ������ ���� int�� ������ ������ �� ����. type conversion error.
        int i = (int)l; //����� ����ȯ�� ����Ͽ� long�� ������ ���� int�� ������ �����Ѵ�.

        Debug.Log("i�� ��:" + i); 


    }

}
