﻿using System.ComponentModel;

namespace List
{
    //    사용자에게 숫자를 입력 받아서
    //0부터 숫자까지 가지는 리스트 만들기
    //0 요소를 제거
    //리스트가 가지는 모든 요소들을 출력해주는 반복문 작성

    //사용자의 입력을 받아서 없는 데이터면 추가, 있던 데이터면 삭제하는 리스트
    //ex) 1, 6, 7, 8, 3 들고 있던 상황이면
    //2 입력하면 없던 경우니까 1, 6, 7, 8, 3, 2
    //7 입력하면 있던 경우니까 1, 6, 8, 3
    public class My
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            for (int i = 0; i < 11; i++)
            {
                list.Add(i);
                Console.WriteLine($"{i}를 추가합니다.");
            }
            list.Remove(0);

            int a = 5;

            if (true == list.Contains(a))
            {
                list.Remove(a);
                Console.WriteLine($"{a}를 제거합니다.");
            }
            else
            {
                list.Add(a);
                Console.WriteLine($"{a}를 추가합니다.");
            }

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }



}
