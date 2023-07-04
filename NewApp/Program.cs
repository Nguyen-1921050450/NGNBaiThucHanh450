System.Console.WriteLine("Nhap ten sinh vien :");
    string ten = Console.ReadLine();
System.Console.WriteLine("Nhap ma sinh vien :");
    string msv = Console.ReadLine();
System.Console.WriteLine("Nhap lop sinh vien :");
    string lop = Console.ReadLine();
float mon1,mon2,mon3,mon4,mon5;

Console.Write("Nhap diem mon thu nhat: ");
mon1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Nhap diem mon thu hai: ");
mon2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Nhap diem mon thu ba: ");
mon3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Nhap diem mon thu tu: ");
mon4 = Convert.ToInt32(Console.ReadLine());

Console.Write("Nhap diem mon thu nam: ");
mon5 = Convert.ToInt32(Console.ReadLine());


float Average = (mon1+mon2+mon3+mon4+mon5) / 5;

System.Console.WriteLine("Trung binh cong cua cac mon la : {0} cua sinh vien {1} - {2} - {3}",Average,ten,msv,lop);





    
