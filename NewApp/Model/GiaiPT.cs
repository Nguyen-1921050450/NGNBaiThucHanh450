namespace NewApp.Model
{
    public class GiaiPT
    {
        
        public void GiaiPTBac1()
        {
            float a, b, x;
            System.Console.WriteLine("Nhap vao a: ");
            a = Convert.ToSingle(Console.ReadLine());
            System.Console.WriteLine("Nhap vao b: ");
            b = Convert.ToSingle(Console.ReadLine());
            if(a == 0)
            {
                if(b == 0)
                {
                    System.Console.WriteLine("PT vo so nghiem");
                }
                else 
                {
                    System.Console.WriteLine("PT vo nghiem");
                }
            }
            else
            {
                x = -b/a;
                string x1 = Convert.ToString(x);
                System.Console.WriteLine("PT co nghiem x = {0}",x1);
   
        
            }
        }
        public void GiaiPTBac2()
        {
            
            float a, b, c, x, delta, x1, x2;
            System.Console.WriteLine("Nhap vao a: ");
            a = Convert.ToSingle(Console.ReadLine());
            System.Console.WriteLine("Nhap vao b: ");
            b = Convert.ToSingle(Console.ReadLine());
            System.Console.WriteLine("Nhap vao c: ");
            c = Convert.ToSingle(Console.ReadLine());
            delta = (b * b) - ( 4 * a *c);
            if(delta < 0)
            {
                System.Console.WriteLine("PT vo nghiem!");
            }
            else if(delta == 0)
            {
                x1 = x2 = (-b / a * a);
                System.Console.WriteLine("PT co 2 nghiem kep x1 = x2 = {0}",+ x1);
            }
            else
            {
                x1 = (float)(-b + Math.Sqrt(delta) / (a * a));
                x2 = (float)(-b - Math.Sqrt(delta) / (a * a));
                System.Console.WriteLine("PT co 2 nghiem phan biet: x1 = {0} va {1}",x1,x2);

            }
        }    
    }
}