namespace PhanSo
{
    public class PhanSo
    {
        public int Tu;
        public int Mau;

        public PhanSo()
        {
            this.Tu = 0;
            this.Mau = 1;
        }

        public PhanSo(int Tu, int Mau)
        {
            this.Tu = Tu;
            this.Mau = Mau;
        }

        public static PhanSo shorten(PhanSo ps)
        {
            PhanSo _kq = new PhanSo();
            _kq = ps;
            int a, b;
            a = Math.Abs(_kq.Tu);
            b = Math.Abs(_kq.Mau);
            while (a != b)
            {
                if (a > b) a = a - b;
                else b = b - a; 
            }
            _kq.Tu /= a;
            _kq.Mau /= a;
            return _kq;
        }
        public static PhanSo add(PhanSo ps1, PhanSo ps2)
        {
            PhanSo _kq = new PhanSo();
            _kq.Tu = ps1.Tu * ps2.Mau + ps1.Mau * ps2.Tu;
            _kq.Mau = ps1.Mau * ps2.Mau;
            return shorten(_kq);
        }
        public static PhanSo sub(PhanSo ps1, PhanSo ps2)
        {
            PhanSo _kq = new PhanSo();
            _kq.Tu = ps1.Tu * ps2.Mau - ps1.Mau * ps2.Tu;
            _kq.Mau = ps1.Mau * ps2.Mau;
            return shorten(_kq);
        }

        public static PhanSo multiply(PhanSo ps1, PhanSo ps2)
        {
            PhanSo _kq = new PhanSo();
            _kq.Tu = ps1.Tu * ps2.Tu;
            _kq.Mau = ps1.Mau * ps2.Mau;
            return shorten(_kq);
        }

        public static PhanSo divide(PhanSo ps1, PhanSo ps2)
        {
            PhanSo _kq = new PhanSo();
            _kq.Tu = ps1.Tu * ps2.Mau;
            _kq.Mau = ps1.Mau * ps2.Tu;
            return shorten(_kq);
        }
    }

    internal class Program
    {
        public static void solve(string[] args)
        {
            if (args.Length == 3)
            {
                PhanSo ps1 = new PhanSo();
                PhanSo ps2 = new PhanSo();

                String[] list_ps1 = args[1].Split('/');
                ps1.Tu = Convert.ToInt32(list_ps1[0]);
                ps1.Mau = Convert.ToInt32(list_ps1[1]);

                String[] list_ps2 = args[2].Split('/');
                ps2.Tu = Convert.ToInt32(list_ps2[0]);
                ps2.Mau = Convert.ToInt32(list_ps2[1]);

                PhanSo _kq = new PhanSo();

                switch (args[0])
                {
                    case "add":
                        _kq = PhanSo.add(ps1, ps2);

                        break;
                    case "sub":
                        _kq = PhanSo.sub(ps1, ps2);

                        break;
                    case "multiply":
                        _kq = PhanSo.multiply(ps1, ps2);

                        break;
                    case "divide":
                        _kq = PhanSo.divide(ps1, ps2);

                        break;
                }
                if (_kq.Mau == 1)
                {
                    Console.WriteLine("{0} ", _kq.Tu);
                }
                else
                {
                    Console.WriteLine("{0}/{1} ", _kq.Tu, _kq.Mau);
                }
            }
            else Console.WriteLine("Wrong insert concept!");
        }
        static void Main(string[] args)
        {
            Program.solve(args);
        }
    }
}

