using UnityEngine;

//Relational Operator (������ ������) : �� ���� ���� ���ϴ� ������
//(==(����), !=(�ٸ�), >(ŭ), <(����), >=(ũ�ų� ����), <=(�۰ų� ����)) 
//���: true(��), false(����)  
public class RelationalOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;
        int y = 5;

        Debug.Log(x < y);  //x�� y���� �۳�? //true
        Debug.Log(x > y);  //x�� y���� ũ��? //false
        Debug.Log(x == y); //x�� y�� ����? //false
        Debug.Log(x != y); //x�� y�� �ٸ���? //true
        Debug.Log(x >= y); //x�� y���� ũ�ų� ����? //false
        Debug.Log(x <= y); //x�� y���� �۰ų� ����? //true

        Debug.Log("AAA" == "aaa"); //���ڿ��� ��ҹ��ڸ� �����ϱ� ������ false
    }

}
