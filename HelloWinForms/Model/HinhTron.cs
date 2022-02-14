using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloDotNET.Model
{
    class HinhTron
    {
        private float banKinh;

        public float getBanKinh()
        {
            return this.banKinh;
        }

        public void setBanKinh(float value)
        {
            if (value < 0)
                value = 0;
            this.banKinh = value;
        }

        public HinhTron(float bk)
        {
            this.setBanKinh(bk);
        }

        public HinhTron(string stBanKinh)
        {
            try
            {
                float value = float.Parse(stBanKinh);
                this.setBanKinh(value);
            }
            catch
            {
                this.setBanKinh(0);
            }
        }

        public HinhTron()
        {
            this.setBanKinh(0);
        }

        //public static void Main()
        //{
        //    System.Console.WriteLine("I am also a program");
        //}
    }
}