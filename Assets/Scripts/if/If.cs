using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

//���� score�� 60�� �̻��̸� "�հ�"�� ����϶�,
//score 61������ �ʱ�ȭ
public class If : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int score = 61; //���� �ʱ�ȭ
        if (score >= 60) //���� score�� 60�� �̻��̸�
        {
            //���๮
            Debug.Log("�հ�"); //�հ� ���
        }
    }

}

/*
if�� - ���ǹ�
���ǽ��� ���� ���� ����Ǵ� ��ɹ�
���ǽ��� �����̸� ���๮�� �������� �ʽ��ϴ�

//���� ���ǽ��� ���̸� {} �ȿ� �ִ� ���๮�� �����϶�   
if(bool)
{
    //���๮1
    //���๮2
    //...
}
 */
