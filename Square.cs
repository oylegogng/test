using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tets
{
    public static class Square
    {
        private const float PI = 3.14f;

        public static float CalculateSqureCircle(float radius)
        {
            return (PI*radius*radius);
        }

        public static float CalculateSqureTriangle(float a, float b, float c)
        {
            float p = (float)((a+b+c)/2);
            return (float)Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }

        public static float UniversalSquare(params float[] p)
        {
            if (p.Length == 1)
            {
                return CalculateSqureCircle(p[0]);
            }
            else if (p.Length == 3)
            {
                return CalculateSqureTriangle(p[0], p[1], p[2]);
            }
            else
            {
                throw new Exception("This number of parameters is not supported");
            }
        }

        public static bool IsRectangular(float a, float b, float c)
        {
            float max = Math.Max(Math.Max(a, b), c);
            float min = Math.Min(Math.Min(a, b), c);
            float mid = a + b + c - max - min;

            return (max * max == min * min + mid * mid);

        }


    }
}
