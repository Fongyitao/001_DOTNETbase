using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  练习1:声明两个变量n1=10,n2=20;要求将两个变量交换,最后输出n1=20,n2=10;扩展:不用第三方变量如何实现?
            //int n1 = 10, n2 = 20;

            //1.第三方变量
            //int temp = n1;
            //n1 = n2;
            //n2 = temp;

            //2.不用第三方变量
            //n1 = n1 + n2;
            //n2 = n1 - n2;
            //n1 = n1 - n2;

            //3.异或,一个数异或两次同一个数等于原数(加密,解密)
            //n1 = n1 ^ n2;
            //n2 = n1 ^ n2;
            //n1 = n1 ^ n2;

            //Console.WriteLine("n1={0},n2={1}",n1,n2);
            #endregion

            #region 练习2:用方法来实现练习1的要求,使用ref
            //int num1 = 10;
            //int num2 = 20;
            //Swap(ref num1, ref num2);
            //Console.WriteLine("num1={0},num2={1}", num1, num2);
            #endregion

            #region 练习3:用户输入一个字符串,计算该字符串中字符个数,并输出
            //Console.WriteLine("请输入一个字符串:");
            //string line = Console.ReadLine();
            //Console.WriteLine("字符串\"{0}\"中字符个数为:{1}",line,line.Length);
            #endregion

            #region 练习4:用方法实现:求两个数中的最大值;扩展:求多个数中的最大值,使用可变参数params
            //Console.WriteLine("请输入第一个数:");
            //int n41 = int.Parse(Console.ReadLine());
            //Console.WriteLine("请输入第二个数:");
            //int n42 = int.Parse(Console.ReadLine());
            //int max = GetMax(n41, n42);
            //Console.WriteLine("最大值是:{0}",max);

            //可变参数
            //int max1 = GetMax1(3, 5, 1, 9, 6);
            //Console.WriteLine("最大值是:{0}",max1);
            #endregion

            #region 练习5:计算1-100之间整数的和
            //int num51 = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    num51 += i;
            //}
            //Console.WriteLine("1-100之间整数和:{0}",num51);
            #endregion

            #region 练习6:用方法来实现:判定一个数是否为质数
            //do
            //{
            //    int num;
            //    Console.WriteLine("请输入要判定的正整数(q退出):");
            //    string line = Console.ReadLine().ToLower();
            //    if (line != "q")
            //    {
            //        if (int.TryParse(line, out num))
            //        {
            //            Console.WriteLine(PrimeNum(num));
            //        }
            //    }
            //    else
            //    {
            //        break;
            //    }
            //} while (true);

            #endregion

            #region 练习7:求1-100之间质数的和
            //int sum71 = 0;
            //for (int i = 2; i <= 100; i++)//1不是质数,从2开始
            //{
            //    if (PrimeNum(i))
            //    {
            //        sum71 += i;
            //    }
            //}
            //Console.WriteLine("1-100之间质数和为:{0}",sum71);
            #endregion
            #region 练习8:用方法实现:计算一个数组的均值{1,2,3,5,7,90,4,6,8,10,1},如果计算结果有小数保留两位小数(四舍五入),Math.Round()
            //int[] arr81 = { 1, 2, 3, 5, 7, 90, 4, 6, 8, 10,1 };
            //double avg81 = GetAvg(arr81);
            //Console.WriteLine("均值是:{0}",avg81);
            #endregion

            #region 练习9:通过冒泡排序法对数组{1,2,3,5,7,90,4,6,8,10}进行升序排序
            //int[] arr91 = { 1, 2, 3, 5, 7, 90, 4, 6, 8, 10 };
            //for (int i = 0; i < arr91.Length -1; i++)
            //{
            //    for (int j = arr91.Length - 1; j > i; j--)
            //    {
            //        if (arr91[j] < arr91[j-1])
            //        {
            //            int temp = arr91[j];
            //            arr91[j] = arr91[j-1];
            //            arr91[j - 1] = temp;
            //        }
            //    }
            //}
            //foreach (var item in arr91)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 练习10:有如下字符串:"患者:"大夫,我咳嗽得很重." 大夫:"你多大年纪?"  患者:"七十五岁." 大夫:"二十岁咳嗽吗?"  患者:"不咳嗽."  大夫:"四十岁咳嗽吗?"  患者:"也不咳嗽".  大夫:"那现在不咳嗽,还要等到什么时候咳嗽?""  需求:统计出该字符串中"咳嗽"出现的次数,以及每次出现的索引.扩展:统计出每个字符出现的次数.
            //string str101 = "患者:\"大夫,我咳嗽得很重.\" 大夫:\"你多大年纪 ? \"  患者:\"七十五岁.\" 大夫:\"二十岁咳嗽吗 ? \"  患者:\"不咳嗽.\"  大夫:\"四十岁咳嗽吗 ? \"  患者:\"也不咳嗽\".  大夫:\"那现在不咳嗽,还要等到什么时候咳嗽 ? \"";

            //int count = 0;//记录"咳嗽出现次数"
            //int index = 0;//记录索引
            //while ((index = str101.IndexOf("咳嗽",index)) != -1)
            //{
            //    count++;
            //    Console.WriteLine("第{0}次出现咳嗽的位置为:{1}",count,index);
            //    index += "咳嗽".Length;
            //}
            //Console.WriteLine("咳嗽总共出现了:{0}",count+"次");

            ////统计每个字符出现的次数
            //Dictionary<char, int> dic = new Dictionary<char, int>();
            //for (int i = 0; i < str101.Length; i++)
            //{
            //    if (!dic.ContainsKey(str101[i]))
            //    {
            //        dic.Add(str101[i], 1);
            //    }
            //    else
            //    {
            //        dic[str101[i]]++;
            //    }
            //}
            //foreach (KeyValuePair<char,int> item in dic)
            //{
            //    Console.WriteLine("\'{0}\'出现了{1}次",item.Key,item.Value);
            //}

            #endregion
            #region 练习11:将字符串"   Hello  Wrold,你   好    世界   !"两端空格去掉,并将其中的空格替换成一个空格,最后输出结果:Hello World,你 好 世界 !

            //string str111 = "   Hello  Wrold,你   好    世界   !";
            //str111 = str111.Trim();//去掉两端空格
            //string[] arr111 = str111.Split(new char[] { ' '},StringSplitOptions.RemoveEmptyEntries);//按char[]{' '}数组进行分割,去除空串
            //foreach (var item in arr111)
            //{
            //    Console.WriteLine(item);
            //}
            //str111 = String.Join(" ", arr111);//将数组按" "进行拼接
            //Console.WriteLine(str111);

            #endregion
            #region 练习12:编写控制台程序:用户可以录入学生的姓名,当输入quit(不区分大小写)时程序停止接受输入并且显示学生个数以及学生的姓名.
            //List<string> list = new List<string>();
            //string name = string.Empty;
            //int count = 0;//记录姓王的人的个数
            //do
            //{
            //    Console.WriteLine("请录入学生姓名(quit退出):");
            //    name = Console.ReadLine();
            //    list.Add(name);
            //    if (name.IndexOf('王')==0)
            //    {
            //        count++;
            //    }
            //} while (name.ToLower() != "quit");
            //list.RemoveAt(list.Count - 1);//移除集合中最后一个元素
            //Console.WriteLine("学生个数为:{0}",list.Count);
            //Console.WriteLine("姓王的学生个数为:{0}",count);
            //foreach (string item in list)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 练习13:将普通时间格式2001年6月6日转换成"二零零一年六月六日"暂时不考虑带十的问题.
            //string str131 = "2001年6月6日";
            //str131 = ConvertToDate(str131);
            //Console.WriteLine(str131);
            #endregion

            #region 练习14:创建一个Person类,属性:姓名,年龄,性别;方法SayHi();再创建一个Employee类继承Person类,扩展属性Salay,重写SayHi()方法.
            //Person p = new Person("李四", -15, "female");
            //Person p1 = new Employee("张三", -18, "male", 5000m);
            //p.SayHi();
            //p1.SayHi();
            #endregion
            #region 练习15:编写一个类ItcastClass该类中有一个字段_name,数据类型为字符串数组,长度为5并且有5个默认的值;要求:为ItcastClass类编写一个索引器,要求该索引器要能通过下标来访问_name中的内容.
            //ItcastClass ic = new ItcastClass();
            //for (int i = 0; i < ic.Count; i++)
            //{
            //    Console.WriteLine(ic[i]);
            //}
            #endregion

            #region 练习16:编写计算器(见项目002_计算器

            #endregion

            #region 练习17:方法重载,方法名称相同,参数列表或者返回类型不同

            #endregion

            #region 练习18:将字符串数组{"中国","American","Tokyo","Paris","韩国","土耳其"}中的内容反转,然后输出反转后的数组.不能用数组的Reverse()方法.
            string[] msg181 = { "中国", "American", "Tokyo", "Paris", "韩国", "土耳其" };
            MyReverse(msg181);//反转数组
            //所有的数组都是引用类型
            foreach (string item in msg181)
            {
                Console.WriteLine(item);
            }
            #endregion
            Console.ReadKey();
        }

        private static void MyReverse(string[] msg)
        {
            for (int i = 0; i < msg.Length / 2; i++)//交换次数就是数组长度length/2
            {
                string temp = msg[i];
                msg[i] = msg[msg.Length - i - 1];
                msg[msg.Length - i - 1] = temp;
            }
        }

        private static string ConvertToDate(string msg)
        {
            //字符串有不可变性,不能这么做
            //msg[0] = '二';

            char[] arr = msg.ToCharArray();
            #region 循环修改字符
            for (int i = 0; i < arr.Length; i++)
            {
                switch (arr[i])
                {
                    case '0':
                        arr[i] = '零';
                        break;
                    case '1':
                        arr[i] = '一';
                        break;
                    case '2':
                        arr[i] = '二';
                        break;
                    case '3':
                        arr[i] = '三';
                        break;
                    case '4':
                        arr[i] = '四';
                        break;
                    case '5':
                        arr[i] = '五';
                        break;
                    case '6':
                        arr[i] = '六';
                        break;
                    case '7':
                        arr[i] = '七';
                        break;
                    case '8':
                        arr[i] = '八';
                        break;
                    case '9':
                        arr[i] = '九';
                        break;
                    default:
                        break;
                }
            }
            #endregion
            return new string(arr);
        }

        private static double GetAvg(int[] arr)
        {
            double sum = 0;
            foreach (int item in arr)
            {
                sum += item;
            }
            return Math.Round(sum / arr.Length, 2);
        }

        private static bool PrimeNum(int num)
        {
            if (num == 1)
            {
                return false;
            }

            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }

        private static int GetMax1(params int[] pms)
        {
            int max = pms[0];
            for (int i = 1; i < pms.Length; i++)
            {
                if (pms[i] > max)
                {
                    max = pms[i];
                }
            }
            return max;
        }

        private static int GetMax(int n1, int n2)
        {
            return n1 > n2 ? n1 : n2;
        }

        /// <summary>
        /// 交换两个变量的值
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        private static void Swap(ref int n1, ref int n2)
        {
            n1 = n1 ^ n2;
            n2 = n1 ^ n2;
            n1 = n1 ^ n2;
        }
    }
}
