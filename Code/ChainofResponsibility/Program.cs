using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainofResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            //责任链模式的创建
            Higher managerHigher = new ManagerHigher("张三经理");
            Higher directorHigher = new DirectorHigher("李四总监");
            Higher vpHigher = new VPHigher("王五副总裁");
            Higher ceoHigher = new CEOHigher("林一总裁");
            managerHigher.SetHigher(directorHigher);
            directorHigher.SetHigher(vpHigher);
            vpHigher.SetHigher(ceoHigher);

            //创建申请人
            Apply liuying = new Apply() { ApplyName = "刘颖", ApplyDay = 5 };
            Apply chenming = new Apply() { ApplyName = "陈明", ApplyDay = 1 };
            Apply zengli = new Apply() { ApplyName = "曾利", ApplyDay = 15 };

            //申请人都将申请提交给经理
            managerHigher.ExeApply(liuying);
            managerHigher.ExeApply(chenming);
            managerHigher.ExeApply(zengli);

            Console.ReadLine();
        }
    }
}
