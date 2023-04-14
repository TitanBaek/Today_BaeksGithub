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

        public static void GameRoof(UpAndDown_GamePlayer gp)
        {
            // 초기세팅

            Console.Clear();
            Console.WriteLine($"환영합니다! {gp.PLAYERNAME}님!");
            Console.WriteLine("그럼 업&다운 게임을 시작합니다!");
            Console.WriteLine("아무키나 누르세요.");
            Console.ReadKey();

            // 게임 클래스 생성

            // 게임루프
            while (true)
            {

            }
        }

    }
}
