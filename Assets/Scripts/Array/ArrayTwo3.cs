using UnityEngine;

//가변형 배열: 배열의 길이가 가변이다
public class ArrayTwo3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1] 2차원 배열 선언: (가변형일 경우)첫번째 요소수(크기)만 생성
        int[][] intarray= new int[2][];

        //[2] 2차원 배열 (두번째)요소수(크기) 각각 따로 생성한다, 초기화
        intarray[0] = new int[3] { 1, 2, 3 };
        intarray[1] = new int[2] { 4, 5 };

        //* 가변형 배열의 길이는 첫번째 요소수의 길이만
        Debug.Log($"배열의 길이: {intarray.Length}"); //2


        //[4] 2차원 배열 사용하기
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
