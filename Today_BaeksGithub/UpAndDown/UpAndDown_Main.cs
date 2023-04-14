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

        public static void PlayerSetting()
        {
            Console.Clear();
            Console.WriteLine("당신의 이름은 무엇인가요?");
            Console.Write("이름 : ");
            UpAndDown_GamePlayer gp = new UpAndDown_GamePlayer(Console.ReadLine().ToUpper());

            GameRoof(gp);

        }
    }
}
