using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nomico
{
    class Field
    {
        //ノミの異動するとことかちゃんと作ったしそれをゲットしてグラフに反映したりする作業が
        public List<Nomi>[,] nomis = new List<Nomi>[FieldStatus.fieldX, FieldStatus.fieldY];

        public void bornNomis(int num)
        {
            for (int i = 0; i < num; i++)
            {
                int x = FieldStatus.getRanFieldX();
                int y = FieldStatus.getRanFieldY();
                nomis[x, y].Add(new Nomi(x, y, this));
            }
        }

        public void grow()
        {
            foreach (var n in nomis)for (int i = 0; i < n.Count; i++) n[i].moved = false;
            for (int i = 0; i < FieldStatus.fieldX; i++)
            {
                for (int j = 0; j < FieldStatus.fieldY; j++)
                {
                    List<Nomi> nom = nomis[i, j];
                    for (int n = 0; i < nom.Count; n++) nom[i].growth();
                }
            }
        }

        public void deadNomi(Nomi n)
        {
            nomis[n.x, n.y].Remove(n);
        }

        public void moveNomi(Nomi n)
        {
            int newX = FieldStatus.getRanMoveX(n.x);
            int newY = FieldStatus.getRanMoveY(n.y);
            nomis[newX, newY].Add(n);   
            nomis[n.x, n.y].Remove(n);
            n.x = newX;
            n.y = newY;
        }
    }
}
