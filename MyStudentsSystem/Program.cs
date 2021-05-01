using System;

namespace MyStudentsSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎进入学生管理系统");
            while (true)
            {
                Console.WriteLine("\n\n请选择你要操作的菜单：");
                Console.WriteLine("\t1、学生信息管理；");
                Console.WriteLine("\t2、学生成绩管理；");
                Console.WriteLine("输入相应的序号进入功能界面，按ESC键退出程序！");
                Console.Write("[~MyStudentsSystem]# ");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Escape:
                        Console.WriteLine("\n程序应用退出...");
                        return;
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        //进入学生信息管理界面
                        Console.WriteLine("\n欢迎进入学生信息管理界面");
                        StudentInfo();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        //进入学生成绩管理界面
                        Console.WriteLine("\n欢迎进入学生成绩管理界面");
                        StudentGrades();
                        break;
                    default:
                        //当用输入其他按键的时候
                        Console.WriteLine("\n输入的命令不存在！");
                        break;
                }
            }
        }
        //学生信息管理
        static void StudentInfo()
        {
            while (true)
            {
                Console.WriteLine("\n请选择你要操作的菜单：");
                Console.WriteLine("\t1、新增学生信息；");
                Console.WriteLine("\t2、删除学生信息；");
                Console.WriteLine("\t3、修改学生信息；");
                Console.WriteLine("\t4、查询学生信息；");
                Console.WriteLine("输入相应的序号进入功能界面，按ESC键返回上一级菜单！");
                Console.Write("[~MyStudentsSystem\\StudentInfo]# ");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Escape:
                        return;
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        //新增学生信息
                        Console.WriteLine("\n新增界面");
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        //删除学生信息
                        Console.WriteLine("\n删除界面");
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        //修改学生信息
                        Console.WriteLine("\n修改界面");
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        //查询学生信息
                        Console.WriteLine("\n查询界面");
                        break;
                    default:
                        //当用输入其他按键的时候
                        Console.WriteLine("\n输入的命令不存在！");
                        break;
                }
            }
        }
        //学生成绩管理
        static void StudentGrades()
        {
            while (true)
            {
                Console.WriteLine("\n请选择你要操作的菜单：");
                Console.WriteLine("\t1、新增学生成绩信息；");
                Console.WriteLine("\t2、删除学生成绩信息；");
                Console.WriteLine("\t3、修改学生成绩信息；");
                Console.WriteLine("\t4、查询学生成绩信息；");
                Console.WriteLine("输入相应的序号进入功能界面，按ESC键返回上一级菜单！");
                Console.Write("[~MyStudentsSystem\\StudentGrades]# ");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Escape:
                        return;
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        //新增学生成绩信息
                        Console.WriteLine("\n新增成绩界面");
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        //删除学生成绩信息
                        Console.WriteLine("\n删除成绩界面");
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        //修改学生成绩信息
                        Console.WriteLine("\n修改成绩界面");
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        //查询学生成绩信息
                        Console.WriteLine("\n查询成绩界面");
                        break;
                    default:
                        //当用输入其他按键的时候
                        Console.WriteLine("\n输入的命令不存在！");
                        break;
                }
            }
        }
    }
}
