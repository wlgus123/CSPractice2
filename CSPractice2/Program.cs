using System;

namespace CSPractice2
{
    internal static class Program
    {
        class Parent
        {
            public int variable = 273;
            public virtual void Method()    // virtual을 붙여줌으로써 오버라이드가 가능해짐
            {
                Console.WriteLine("부모 메서드");
            }
        }

        class Child : Parent
        {
            public new string variable = "하이딩";
            public new  void Method()
            {
                Console.WriteLine("자식 메서드");
            }
        }

        class Child2 : Parent
        {
            public override void Method()   // C# 에서는 override를 접근제한자 뒤에 씀
            {
                Console.WriteLine("오버라이드 된 자식 메서드");
            }
        }

        static int number = 10;

        static void Main(string[] args)
        {
            // #6 23-7. 새도잉
            int number = 20;
            Console.WriteLine(number);  // 20

            // #6 23-7. 하이딩
            Child child = new Child();
            Console.WriteLine(child.variable);  // 출력: 하이딩
            child.Method();     // 출력: 자식 메서드
            Console.WriteLine(((Parent)child).variable);    // 출력: 273
            ((Parent)child).Method();   // 출력: 부모 메서드
            Parent p = child;
            Console.WriteLine(p.variable);  // 출력: 273
            p.Method();     // 출력: 부모 메서드
            ((Child)p).Method();    // 출력: 자식 메서드

            // #6 23-8. 오버라이딩
            Child2 child2 = new Child2();
            child2.Method();    // 출력: 오버라이드 된 자식 메서드
            ((Parent)child2).Method();  // 출력: 오버라이드 된 자식 메서드
            Parent p2 = child2;
            p2.Method();    // 출력: 오버라이드 된 자식 메서드
            ((Child)p2).Method();    // 출력: 오버라이드 된 자식 메서드
        }
    }
}
