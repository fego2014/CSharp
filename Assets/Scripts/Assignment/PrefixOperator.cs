using UnityEngine;

//Prefix Operator (���� ����������): ���� ���ο��� �����ϴ� ������ ���� ����(���� ���� ����)
public class PrefixOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 3;
        int j = ++i; //i�� 1������Ų �� j�� ����
        Debug.Log("j: "+j);
    }

}
