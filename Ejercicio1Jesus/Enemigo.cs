using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Jesus
{
    class Enemigo
    {
        private int _posX;
        public int posX
        {
            get
            {
                return _posX;
            }
            set
            {
                if(posX > 1280)
                {
                    posX = posX * -1; 
                }
                else
                {
                    posX = posX * 1;
                }
            }
        }
        private int _posY;
        public  int posY
        {
            get
            {
                return _posY;
            }
            set
            {
                if (posY > 720)
                {
                    posY = posY * -1;
                }
                else
                {
                    posY = posY * 1;
                }
            }
        }
        public int Score { get; set; }
        private int _life;
        public int Life
        {
            get { return _life; }
            set
            {
                Life = 100;
            }
        }

        public void Move()
        {

        }
        public void Shoot()
        {

        }
        public void Explote()
        {

        }

    }
}
