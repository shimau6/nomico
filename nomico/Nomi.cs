using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nomico
{
    class Nomi
    {
        public enum SEX {osu,mesu}
        public int sex;
        public int age;
        
        public int x;
        public int y;

        public bool moved = false;

        private Field parent;

        Random ran = new Random();
        public Nomi(Field parent)
        {
            age = 0;
            sex = FieldStatus.getRanSex();
            this.x = ran.Next(FieldStatus.fieldX);
            this.y = ran.Next(FieldStatus.fieldY);
            this.parent = parent;
        }

        public Nomi(int x,int y, Field parent)
        {
            age = 0;
            sex = FieldStatus.getRanSex();
            this.x = x;
            this.y = y;
            this.parent = parent;
        }

        public void growth()
        {
            if (moved == false)
            {
                age++;
                dead();
                move();
                moved = true;
            }
        }

        public void move()
        {
            parent.moveNomi(this);
        }

        public void dead()
        {
            if(ran.NextDouble() <= FieldStatus.getDeadRate(age))
            {
                parent.deadNomi(this);
            }
        }
    }
}
