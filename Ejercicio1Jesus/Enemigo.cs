using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Jesus
{
    class Enemigo
    {
        public int posX { get; set; }
        public  int posY { get; set; }
        public int FinalScore { get; set; }
        private int _score;
        public int Score
        {
            get
            { return _score; }
            set
            {
                if (value <= 100)
                {
                    throw new Exception("El valor tiene que ser mayor a 100");
                }
                else
                {
                    _score = value;
                }
            }
        }
        /*
        private int _life;
        public int Life
        {
            get { return _life; }
            set
            {
                Life = 100;
            }
        }*/

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
