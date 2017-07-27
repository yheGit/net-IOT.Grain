using Net66.Comm;
using Net66.Comm.SysApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //var reStr= WareHouseTest.AddWareHouse();

            //var reStr = WareHouseTest.UpdateWareHouse();

            //var reStr = WareHouseTest.DeleteWareHouse();

            //var reStr = WareHouseTest.AddFloor();

            //var reStr = WareHouseTest.AddGranary();

            //var reStr = WareHouseTest.AddHeap();
            //Console.WriteLine(reStr);

            //Comm.test(28);

            //string reStr= Utils.StrSequenConcat("a" ,"z", "y", "x", "b", "d", "c", "z", "y", "x");

            // Console.WriteLine(reStr);

            //var str = "1910FD18-2A03-4E75-9049-02A876CB56BE";
            //Console.WriteLine(str);
            //str = str.Replace("-", "");
            //Console.WriteLine(str);
            ////str = str.Trim('-');
            ////str = str.Trim(new char[]{'-'});
            //Console.WriteLine(str.Length / 2);
            //decimal reDe = 0;
            //for (int i = 0; i < str.Length / 2;i++ )
            //    reDe += Tools.GetTempTest(str, i);
            //Console.WriteLine(reDe);

            //var datett=Utils.GetServerDateTime();
            //Console.WriteLine(datett);
            //Console.WriteLine(datett.ToString());


            //DateTime dt = DateTime.Now;
            //Console.WriteLine(dt.AddDays(-30));
            //Console.WriteLine(dt.AddMonths(-1));

            //float re = (float)10 / 4;
            //var rr = Math.Round(re,4);
            //Console.WriteLine(rr);

            var msg = "\r\n";
            msg += "注册恢复测试";
            NetSendMsg.DirectSend("18124635564;", msg + DateTime.Now, 1);

            //var strSSS = new List<string>();
            //if (strSSS == null)
            //    Console.WriteLine("空对象");

            //decimal reint = 24;
            //while (true)
            //{
            //    Console.WriteLine("请输入...");
            //    reint =Convert.ToDecimal(Console.ReadLine());
            //    if (reint == -100)
            //        break;
            //    reint = reint + (int)1E-30;
            //    Console.WriteLine("结果是：");
            //    Console.WriteLine(reint);
            //}           
            //var datenow = Utils.GetServerDateTime();
            //var datenowStr = datenow.ToString();

            //DateTime lastdaytime = Utils.GetWeekLastDaySun(datenow);
            //Console.WriteLine(lastdaytime);
            //var number = "L1-10-A-11";
            //var g_number = number.Substring(0, number.LastIndexOf('-'));
            //Console.WriteLine(g_number);

            Console.ReadKey();

        }
    }
}
