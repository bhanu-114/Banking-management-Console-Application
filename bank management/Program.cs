using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace bank_management
{
    internal class Program
    {
        public static int v1, v2, v3, v4, v5, v6,n=1;
        public static long acno1, acno2;
        public static double damount, wamount, scharge, eamount,ramount;
        public static String username, password;
        public static string fullname, father, mother, gender, street, village, state;
        public static string fullname1, father1, mother1, gender1, street1, village1, state1;
        public static int pin,pin1;
        public static long acno, mobile,mobile1;
        public static double amount;
        public static List<(string father, string mother, string gender, string street, string village, string state, int pin, long mobile, long acno, double amount)> users = new List<( string, string, string, string, string, string, int, long, long, double)>();
        public static List<string > name=  new List<string> ();
        public static List<string> fname = new List<string>();
        public static List<string> mname = new List<string>();
        public static List<string> gndr = new List<string>();
        public static List<string> strt = new List<string>();
        public static List<string> vlg = new List<string>();
        public static List<string> stat = new List<string>();
        public static List<int> pn = new List<int>();
        public static List<long> mob = new List<long>();
        public static List<long> ac = new List<long>();
        public static List<double> amt = new List<double>();
        static void Main(string[] args)
        {
            void add()
            {
                name.Add(fullname);
                fname.Add(father);
                mname.Add(mother);
                gndr.Add(gender);
                strt.Add(street);
                vlg.Add(village);
                stat.Add(state);
                pn.Add(pin);
                mob.Add(mobile); 
                ac.Add(acno);
                amt.Add(amount);
                users.Add(( father, mother, gender, street, village, state, pin, mobile, acno, amount));
            }
            void update()
            {
            Label10:
                if (acno1 == acno)
                {
                    users.Add(( father, mother, gender, street, village, state, pin, mobile, acno, amount));
                }
                else
                {
                    Console.WriteLine("WRONG ACCOUNT NO TRY AGAIN");
                    Console.Write("ENTER YOUR ACCOUNT NUMBER  :");
                    acno1 = Convert.ToInt32(Console.ReadLine());
                    goto Label10;
                }
            }
            void del()
            {
            Label11:
                if(acno1==acno)
                {
                    users.Remove((father, mother, gender, street, village, state, pin, mobile, acno, amount));

                }
                else
                {
                    Console.WriteLine("WRONG ACCOUNT NO TRY AGAIN");
                    Console.Write("ENTER YOUR ACCOUNT NUMBER  :");
                    acno1 = Convert.ToInt32(Console.ReadLine());
                    goto Label11;
                }
            }
            void login()
            {
                Console.Clear();
                for (int i = 0; i < 2; i++)
                {
                    Console.Clear();
                    Console.Write("PLEASE WAIT LOADING");
                    for (int j = 0; j < 4; j++)
                    {
                        Thread.Sleep(500);
                        Console.Write(".");
                    }
                }
                Console.Clear();
                Console.WriteLine("-------Customer Details-------");
                for(int i = 0; i < name.Count;i++)
                {
                    Console.WriteLine("Name          :" + name[i]);
                    Console.WriteLine();
                    Console.WriteLine("Account No    :" + ac[i]);
                    Console.WriteLine();
                    Console.WriteLine("Mobile        :" + mob[i]);
                    Console.WriteLine();
                    Console.WriteLine("Amount        :" + amt[i]);
                    Console.WriteLine("-----------------------------------------------------");
                }
            }
            void logout()
            {
                Console.Clear();
                for (int i = 0; i < 2; i++)
                {
                    Console.Clear();
                    Console.Write(" Logging Out");
                    for (int j = 0; j < 4; j++)
                    {
                        Thread.Sleep(500);
                        Console.Write(".");
                    }
                }
                Console.Clear();
            }
            void exist()
            {
            Label5:
                    if (acno1 == acno)
                    {
                        Console.WriteLine("Name           :" + fullname);
                        Console.WriteLine("Father Name    :" + father);
                        Console.WriteLine("Mother Name    :" + mother);
                        Console.WriteLine("Gender         :" + gender);
                        Console.WriteLine("Mobile         :" + mobile);
                        Console.WriteLine("Address :");
                        Console.WriteLine("Street         :" + street);
                        Console.WriteLine("Village        :" + village);
                        Console.WriteLine("Pin code       :" + pin);
                        Console.WriteLine("Account No     :" + acno);
                        Console.WriteLine("Balance    :" + amount);
                    }

                    else
                    {
                        Console.WriteLine("WRONG ACCOUNT NO TRY AGAIN");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("ENTER YOUR ACCOUNT NUMBER  :");
                        acno1 = Convert.ToInt32(Console.ReadLine());
                        goto Label5;
                    }
                
            }
            void deposit()
            {
                amount += damount;
                Console.WriteLine("DEPOSITED SUCCESSFULLY");
                Console.WriteLine("AVAILABLE BALANCE :" + amount);
            }
            void wdraw()
            {
                if (amount < 500)
                {
                    Console.WriteLine("MINIMUM BALANCE IS A RULE i.e.,(500)");
                    amount += wamount;
                }
                else
                {
                    Console.WriteLine("YOUR WITHDRAW IS SUCCESSFULL ");
                    Console.WriteLine("AVAILABLE BALANCE :" + amount);
                }
            }
            void charge()
            {
                amount -= scharge;
                Console.WriteLine("BALANCE AMOUNT :" + amount);
            }
            void usd()
            {
                if (amount < 500)
                {
                    Console.WriteLine("MINIMUM BALANCE IS A RULE i.e.,(500)");
                    amount += eamount;
                }
                else
                {
                    ramount = (eamount / 85);
                    Console.WriteLine("Your Bank Balance :" + amount);
                    Console.WriteLine("Your Exchanged currency " + ramount + " $");
                }
            }
            void euro()
            {
                if (amount < 500)
                {
                    Console.WriteLine("MINIMUM BALANCE IS A RULE i.e.,(500)");
                    amount += eamount;
                }
                else
                {
                    ramount = (eamount / 90.32);
                    Console.WriteLine("Your Bank Balance :" + amount);
                    Console.WriteLine("Your Exchanged currency " + ramount + " Euro's");
                }
            }
            void pound()
            {
                if (amount < 500)
                {
                    Console.WriteLine("MINIMUM BALANCE IS A RULE i.e.,(500)");
                    amount += eamount;
                }
                else
                {
                    ramount = (eamount / 105.4);
                    Console.WriteLine("Your Bank Balance :" + amount);
                    Console.WriteLine("Your Exchanged currency " + ramount + " Pounds");
                }
            }

        Label1:
            Console.WriteLine("                   WELCOME TO NATIONAL BANK OF INDIA ");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("          SELECT LOGIN TYPE");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1.ACCOUNTANT");
            Console.WriteLine();
            Console.WriteLine("2.CUSTOMER");
            Console.WriteLine();
            v1 = Convert.ToInt32(Console.ReadLine());
            if (v1 == 1)
            {
                Console.Clear();
            Label2:
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("USER ID  :");
                username = Console.ReadLine();
                Console.Write("PASSWORD :");
                password = Console.ReadLine();
                Console.Clear();
                if (username == "admin" && password == "admin")
                {
                    login();
                    Console.WriteLine();
                    Console.WriteLine();
                Label7:
                    Console.WriteLine("Logout :(YES-1/NO-2)");
                    v3 = Convert.ToInt32(Console.ReadLine());
                    if (v3 == 1)
                    {
                        logout();
                        goto Label1;
                    }
                    else if (v3 == 2)
                    {
                        Console.Clear();
                        login();
                        Console.WriteLine("Service Charges or SMS charges");
                        scharge = Convert.ToDouble(Console.ReadLine());
                        goto Label7;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Details :(   please try again");
                    goto Label2;
                }
            }
            else if (v1 == 2)
            {
                Console.Clear();
                Console.WriteLine("          Select any one option");
                Console.WriteLine();
                Console.WriteLine("1.NEW CUSTOMER");
                Console.WriteLine();
                Console.WriteLine("2.EXISTED");
                Console.WriteLine();
                v2 = Convert.ToInt32(Console.ReadLine());
                if (v2 == 1)
                {
                    n += n;
                    Console.Clear();
                    Console.WriteLine("               Fill Your Details For Creating Account");
                    Console.WriteLine();
                    Console.WriteLine("-----------------------------------------------------------------");
                    Console.WriteLine();
                    Console.Write("NAME          :");
                    fullname = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("FATHER NAME   :");
                    father = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("MOTHER NAME   :");
                    mother = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("GENDER        :");
                    gender = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("MOBILE NUMBER :");
                    mobile = Convert.ToInt64(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("ADDRESS :");
                    Console.WriteLine();
                    Console.Write("     STREET   :");
                    street = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("     VILLAGE  :");
                    village = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("     PIN CODE :");
                    pin = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("     STATE    :");
                    state = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("Please Wait... crerating Your Account Number");
                    Thread.Sleep(2000);
                    Console.Clear();
                    Random random = new Random();
                    acno = random.Next(100000000, 999999999);
                    Console.WriteLine("Your Account Number Is : " + acno);
                Label9:
                    Console.WriteLine();
                    Console.Write("PLEASE DEPOSITE AMOUNT FOR REGISTRATION(Minimum Balance-500)  :");
                    amount = Convert.ToDouble(Console.ReadLine());
                    if (amount >= 500)
                    {
                        Console.Clear();
                        Console.WriteLine("you have successfully registered.........");
                        Thread.Sleep(1500);
                        Console.Clear();
                        for (int i = 0; i < 2; i++)
                        {
                            Console.Clear();
                            Console.Write("Please Wait Redirecting to login page");
                            for (int j = 0; j < 4; j++)
                            {
                                Thread.Sleep(500);
                                Console.Write(".");
                            }
                        }
                        Console.Clear();
                        add();
                        goto Label1;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("MINIMUM DEPOSIT 500/-");
                        Console.WriteLine();
                        Console.WriteLine();
                        goto Label9;
                    }
                }


                else if (v2 == 2)
                {
                    Console.Clear();
                    Console.Write("ENTER YOUR ACCOUNT NUMBER :");
                    acno1 = Convert.ToInt64(Console.ReadLine());
                    Console.Clear();
                    exist();
                Label6:
                    Console.WriteLine("       SELECT ONE OF OUR SERVICES");
                    Console.WriteLine();
                    Console.WriteLine("1.DEPOSIT");
                    Console.WriteLine();
                    Console.WriteLine("2.WITHDRAW");
                    Console.WriteLine();
                    Console.WriteLine("3.FOREIGN EXCHANGE");
                    Console.WriteLine();
                    Console.WriteLine("4.UPDATE DETAILS");
                    Console.WriteLine();
                    Console.WriteLine("5.DELETE ACCOUNT");
                    Console.WriteLine();
                    v4 = Convert.ToInt32(Console.ReadLine());
                    if (v4 == 1)
                    {
                        Console.Clear();
                        Console.Write("ENTER AMOUNT TO DEPOSIT :");
                        damount = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                        deposit();
                        Console.WriteLine();
                        Console.WriteLine("CAN YOU USE ANY SERVICE :(YES-1)(NO-2)");
                        v5 = Convert.ToInt32(Console.ReadLine());
                        if (v5 == 1)
                        {
                            Console.Clear();
                            goto Label6;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Please Wait... Redirecting to login page ");
                            Thread.Sleep(3000);
                            Console.Clear();
                            goto Label1;
                        }

                    }
                    else if (v4 == 2)
                    {
                        Console.Clear();
                        Console.Write("ENTER AMOUNT TO WITHDRAW :");
                        wamount = Convert.ToDouble(Console.ReadLine());
                        if (wamount < amount)
                        {
                            amount -= wamount;
                            wdraw();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Insufficient Balance");
                            Console.WriteLine();
                        }
                        Console.WriteLine("CAN YOU USE ANY SERVICE :(YES-1)(NO-2)");
                        v5 = Convert.ToInt32(Console.ReadLine());
                        if (v5 == 1)
                        {
                            Console.Clear();
                            goto Label6;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Please Wait... Redirecting to login page ");
                            Thread.Sleep(3000);
                            Console.Clear();
                            goto Label1;

                        }

                    }
                    else if (v4 == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Select Currency Type");
                        Console.WriteLine("1.US Dollars");
                        Console.WriteLine("2.Euro");
                        Console.WriteLine("3.Pounds");
                        v6 = Convert.ToInt32(Console.ReadLine());
                        if (v6 == 1)
                        {
                            Console.Clear();
                            Console.Write("Enter Amount to Convert Into Dollars :");
                            eamount = Convert.ToDouble(Console.ReadLine());
                            if (eamount < amount)
                            {
                                amount -= eamount;
                                usd();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Insufficient Balance");
                            }
                            Console.WriteLine();
                            Console.WriteLine("CAN YOU USE ANY SERVICE :(YES-1)(NO-2)");
                            v5 = Convert.ToInt32(Console.ReadLine());
                            if (v5 == 1)
                            {
                                Console.Clear();
                                goto Label6;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Please Wait... Redirecting to login page ");
                                Thread.Sleep(3000);
                                Console.Clear();
                                goto Label1;
                            }

                        }
                        else if (v6 == 2)
                        {
                            Console.Clear();
                            Console.Write("Enter Amount to Convert Into Euro's :");
                            eamount = Convert.ToDouble(Console.ReadLine());
                            if (eamount < amount)
                            {
                                amount -= eamount;
                                euro();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Insufficient Balance");
                                Console.WriteLine();
                            }
                            Console.WriteLine("CAN YOU USE ANY SERVICE :(YES-1)(NO-2)");
                            v5 = Convert.ToInt32(Console.ReadLine());
                            if (v5 == 1)
                            {
                                Console.Clear();
                                goto Label6;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Please Wait... Redirecting to login page ");
                                Thread.Sleep(3000);
                                Console.Clear();
                                goto Label1;
                            }

                        }
                        else if (v6 == 3)
                        {
                            Console.Clear();
                            Console.Write("Enter Amount to Convert Into Euro's :");
                            eamount = Convert.ToDouble(Console.ReadLine());
                            if (eamount < amount)
                            {
                                amount -= eamount;
                                pound();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Insufficient Balance");
                                Console.WriteLine();
                            }
                            Console.WriteLine("CAN YOU USE ANY SERVICE :(YES-1)(NO-2)");
                            v5 = Convert.ToInt32(Console.ReadLine());
                            if (v5 == 1)
                            {
                                Console.Clear();
                                goto Label6;
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Please Wait... Redirecting to login page ");
                                Thread.Sleep(3000);
                                Console.Clear();
                                goto Label1;
                            }

                        }
                    }
                    else if (v4 == 4)
                    {
                        Console.Write("Enter Your Account Number :");
                        acno1 = Convert.ToInt64(Console.ReadLine());
                        Thread.Sleep(2000);
                        update();
                        Thread.Sleep(2000);
                        Console.Clear();
                        Console.WriteLine("DETAILS UPDATING");
                        Console.WriteLine();
                        Console.Write("NAME          :");
                        fullname = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("FATHER NAME   :");
                        father = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("MOTHER NAME   :");
                        mother = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("GENDER        :");
                        gender = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("MOBILE NUMBER :");
                        mobile = Convert.ToInt64(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("ADDRESS :");
                        Console.WriteLine();
                        Console.Write("     STREET   :");
                        street = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("     VILLAGE  :");
                        village = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("     PIN CODE :");
                        pin = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("     STATE    :");
                        state = Console.ReadLine();
                        Console.WriteLine();
                        Console.Clear();
                        Console.WriteLine("Updated Successfully");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("CAN YOU USE ANY SERVICE :(YES-1)(NO-2)");
                        v5 = Convert.ToInt32(Console.ReadLine());
                        if (v5 == 1)
                        {
                            Console.Clear();
                            goto Label6;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Please Wait... Redirecting to login page ");
                            Thread.Sleep(3000);
                            Console.Clear();
                            goto Label1;
                        }
                    }
                    else if (v4 == 5)
                    {
                        Console.Clear();
                        Console.Write("Enter Your Account Number :");
                        acno2 = Convert.ToInt64(Console.ReadLine());
                        del();
                        Console.WriteLine("Please Wait Deleting Your Account....");
                        Thread.Sleep(3000);
                        Console.Clear();
                        Console.WriteLine("Deleted Successfully :)");
                        Thread.Sleep(2000);
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Enter valid option");
                        goto Label6;
                    }
                }
            }
        }
    }
}
