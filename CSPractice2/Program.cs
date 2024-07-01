﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPractice2
{
    internal class Program
    {
        class Parent
        {
            public int variable = 273;
            public void Method()
            {
                Console.WriteLine("부모 메서드");
            }
        }
        class Child : Parent
        {
            public new string variable = "하이딩";
            public new void Method() //하이딩을 구분하기 위해 명시적으로 new 작성
            {
                Console.WriteLine("자식 메서드");
            }
        }

        public static int number = 10;
        static void Main(string[] args)
        {
            // #6 27-7 섀도잉
            int number = 20;
            Console.WriteLine(number);

            // #6 27-7 하이딩
            Child child = new Child();
            Console.WriteLine(child.variable); // 출력: 하이딩
            Console.WriteLine(((Parent)child).variable); // 출력: 273
            Parent p = new Parent();
            Console.WriteLine(p.variable); // 출력: 273

            Console.WriteLine("----------------------");

            child.Method(); //출력: 자식 메서드
            p.Method(); // 출력: 부모 메서드
            ((Child)p).Method(); // 출력: 자식 메서드
        }
    }
}
