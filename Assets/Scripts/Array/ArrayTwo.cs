using UnityEngine;

//2차원 배열: 행과 열로 이루어진 배열
public class ArrayTwo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //[1]배열 선언
        int[,] intarray;

        //[2]배열 요소수(크기) 생성
        intarray = new int[2, 3];

        //[3]배열 초기화
        //0번행
        intarray[0,0] = 1;
        intarray[0,1] = 2;
        intarray[0,2] = 3;
        //1번행
        intarray[1,0] = 4;
        intarray[1,1] = 5;
        intarray[1, 2] = 6;


        //[4]배열 사용
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
