using UnityEngine;

//var: �Ͻ������� ����ȭ�� ���� ����, ������ Ÿ���� �ڵ����� ����
//var ����� ������ �ʱ�ȭ�� �ݵ�� �Ѵ�.
public class Var : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //var name; //������ Ÿ���� �� �� ���� ������ ���� �߻�
        var name = "ȫ�浿"; //������ �ԷµǴ� ��("ȫ�浿")�� ���� string �������� ����

        //var version; //������ Ÿ���� �� �� ���� ������ ���� �߻�
        var version = 8.0;  //������ �ԷµǴ� ��(8.0)�� ���� double �������� ����

        //var car; //������ Ÿ���� �� �� ���� ������ ���� �߻�
        var car = 1;        //������ �ԷµǴ� ��(1)�� ���� int �������� ����

        Debug.Log(name);
        Debug.Log(name.GetType()); //System.String
        Debug.Log(version);
        Debug.Log(version.GetType()); //System.Double
        Debug.Log(car);
        Debug.Log(car.GetType()); //System.Int32
    }
}
