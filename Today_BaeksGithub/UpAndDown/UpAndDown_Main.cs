using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Today_BaeksGithub.UpAndDown
{
    internal class UpAndDown_Main
    {
        public static void MainMenu()
        {
            Console.Write("업&다운! 게임을 시작하겠습니까? (Y/N) :");
            switch (Console.ReadLine().ToUpper())
            {
                case "Y": PlayerSetting(); break;
                case "N": return; break;
                default: break;
            }
        }
    }
}
