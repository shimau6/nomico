using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nomico
{
    class FieldStatus
    {
        //おおきいほど男の発生率が高い
        public static double Rate_sexborn = 0.5;

        //0代~90代の成長するごとの死亡率
        public static double[] Rate_dead = new double[] {
            0.01,0.05,0.08,0.1,0.2,0.4,0.5,0.6,0.9,0.9};
         
        public static int fieldX = 100;
        public static int fieldY = 100;

        //1人で産める子供の数の限界値
        public static int boenChildCount = 3;
        public static double getDeadRate(int age)
        {
            int tmp = age % 10;
            if (tmp >= 10) tmp = 9;

            return Rate_dead[tmp];
        }

        private static Random ran = new Random();
        public static int getRanFieldX() { return ran.Next(fieldX); }
        public static int getRanFieldY() { return ran.Next(fieldY); }
        public static int getRanSex() { return (ran.NextDouble() <= FieldStatus.Rate_sexborn) ? 0 : 1; }
        public static int getRanMove() { return ran.Next(3) - 1; }//-1,0,1のどれか
        public static int getRanMoveX(int x) { if (x == 0) return ran.Next(2); else if (x == fieldX) return ran.Next(2) - 1; else return ran.Next(3) - 1;}
        public static int getRanMoveY(int y) { if (y == 0) return ran.Next(2); else if (y == fieldY) return ran.Next(2) - 1; else return ran.Next(3) - 1; }
    }
}
