using System;

namespace org.khaccthienn.atmapplications
{
    class ATMApplicationV1
    {
        public static void Main(string[] args)
        {
            const string USERNAME = "khaccthienn";
            const string PASSWORD = "123456";
            
            long balance = default;
            bool isLogin = false;
            long amount = default;
            int choice = default;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n=====> MENU <=====");
                Console.WriteLine("1. Dang nhap vao TK");
                Console.WriteLine("2. Rut tien");
                Console.WriteLine("3. Nap tien vao TK");
                Console.WriteLine("4. Kiem tra so du");
                Console.WriteLine("0. Thoat chuong trinh");
                Console.WriteLine("Xin moi ban chon: ");
                Console.ResetColor();
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Thanks for using !");
                        Environment.Exit(0);
                        break;
                    case 1:
                        if (isLogin)
                        {
                            Console.WriteLine("Ban da dang nhap vao TK roi !");
                        }
                        Console.Write("Nhap ten dang nhap: ");
                        string userName = Console.ReadLine();
                        if (USERNAME.CompareTo(userName) == 0)
                        {
                            Console.Write("Nhap mat khau dang nhap: ");
                            string userPass = Console.ReadLine();
                            if (PASSWORD.CompareTo(userPass) == 0)
                            {
                                isLogin = true;
                                Console.WriteLine("Dang Nhap Thanh Cong !");
                            }
                            else
                            {
                                Console.WriteLine("Hay kiem tra lai thong tin tai khoan !");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Hay kiem tra lai thong tin tai khoan !");
                        }
                        break;
                    case 2:
                        if (isLogin)
                        {
                            int option;
                            bool isWithDrawable = true;
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.WriteLine("Chon so tien can rut: ");
                            Console.WriteLine("1. 10k");
                            Console.WriteLine("2. 20k");
                            Console.WriteLine("3. 50k");
                            Console.WriteLine("4. 100k");
                            Console.WriteLine("5. 200k");
                            Console.WriteLine("6. 500k");
                            Console.WriteLine("7. 1000k");
                            Console.WriteLine("8. 2000k");
                            Console.WriteLine("9. 5000k");
                            Console.WriteLine("0. Nhap mot so khac");
                            Console.ResetColor();
                            option = int.Parse(Console.ReadLine());

                            switch (option)
                            {
                                case 1:
                                    amount = 10000;
                                    break;
                                case 2:
                                    amount = 20000;
                                    break;
                                case 3:
                                    amount = 50000;
                                    break;
                                case 4:
                                    amount = 100000;
                                    break;
                                case 5:
                                    amount = 200000;
                                    break;
                                case 6:
                                    amount = 500000;
                                    break;
                                case 7:
                                    amount = 1000000;
                                    break;
                                case 8:
                                    amount = 2000000;
                                    break;
                                case 9:
                                    amount = 5000000;
                                    break;
                                case 0:
                                    Console.Write("Nhap so tien can rut (la boi so cua 10000) :");
                                    amount = int.Parse(Console.ReadLine());
                                    if (amount < 0 || amount % 10000 != 0)
                                    {
                                        Console.WriteLine("Vui long nhap so tien hop le !");
                                        amount = 0;
                                        isWithDrawable = false;
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Invalid Choice !");
                                    break;
                            }
                            if (isWithDrawable)
                            {
                                if (balance > amount)
                                {
                                    balance -= amount;
                                    Console.WriteLine("\tBan da rut thanh cong {0} !", amount);
                                    Console.WriteLine("\tSo tien hien tai trong tai khoan la: {0} !", balance);
                                }
                                else
                                {
                                    Console.WriteLine("\tSo du khong du !");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Vui long dang nhap de thuc hien giao dich nay");
                        }
                        break;
                    case 3:
                        if (isLogin)
                        {
                            Console.WriteLine();
                            Console.Write("Nhap so tien muon nap vao tai khoan: ");
                            amount = long.Parse(Console.ReadLine());
                            if (amount > 0 && amount % 10000 == 0)
                            {
                                balance += amount;
                                Console.WriteLine("\tNap thanh cong {0} vao tai khoan !", amount);
                                Console.WriteLine("\nSo du hien tai la: {0}", balance);
                                amount = 0;
                            }
                            else
                            {
                                Console.WriteLine("So tien nap vao khong hop le !");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Vui long dang nhap de thuc hien giao dich nay");
                        }
                        break;
                    case 4:
                        if (isLogin)
                        {
                            Console.WriteLine("\tSo du hien tai cua ban la: {0}", balance);
                        }
                        else
                        {
                            Console.WriteLine("Vui long dang nhap de thuc hien giao dich nay");
                        }
                        break;

                    default:
                        Console.WriteLine("Sai chuc nang, vui long chon lai !");
                        break;
                }
            }
        }
    }
}