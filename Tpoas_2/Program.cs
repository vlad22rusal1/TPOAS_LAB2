using System;
namespace Tpoas_2
{
    public class Area
    {
        public static int Rad(int r0)
        {
            int plo = (int)(Math.PI * r0 * r0);
            return plo;
        }
    }
    public class Programm
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Введи радиус основания прямого конуса");
            int r0 = Convert.ToInt16(Console.ReadLine());
            if (r0 <= 0)
            {
                return;
            }
            Area area = new Area();
            double s = Area.Rad(r0);
            Console.WriteLine("Площадь основания прямого конуса = " + s);
        }
    }
}
