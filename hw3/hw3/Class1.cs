using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw3
{
    class CComplex
    {
        private Double im;
        private Double re;

        public CComplex()
        {
            im = 0;
            re = 0;
        }

        public CComplex(double _im, double _re)
        {
            im = _im;
            re = _re;
        }

        public double Im

        {
            get
            {
                return im;
            }
            set
            {
                im = value;
            }
        }

        public double Re

        {
            get
            {
                return re;
            }
            set
            {
                re = value;
            }

        }

        public void  Plus(CComplex x)
        {
            im = im + x.im;
            re = re + x.re;
        }

        public void  Multi(CComplex x)
        {  
            im = re * x.im + im * x.re;
            re = re * x.re - im * x.im;
         }

        public String ToString()
        {
            return re + " " + im + "i";
        }
    }
}
