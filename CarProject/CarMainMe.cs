using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    internal class CarMainMe
    {
   public static void CarMenu()
        {
            string res;
            do
            {
                // make the BG color and text 
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.Yellow;

                // programe intro to show the user the menu and ask the user to choose accodring to the menu
                Console.WriteLine("***** Cars Menu *****" +
                    "\n 1- add Car TO Hyundai \n 2- add Car TO Toyota \n 3- add Car TO Ford \n 4- add Car TO BMW \n 5- add Car TO Audi" +
                    "\n 6- show Car From Hyundai \n 7- show Car From Toyota \n 8- show Car from Ford \n 9- show Car From BMW \n 10- show Car From Audi \n 11- search for Car ID ");
                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine(" Enter Number from the above Menu :-");
                int user_chosee = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;

                String carName = "carname", carColor = "carcolor";
                int carID = 0;
                double carPrice = 0.0;

                if (user_chosee == 1 || user_chosee == 2 || user_chosee == 3 || user_chosee == 4 || user_chosee == 5)
                {
                    try
                    {
                        Console.WriteLine("Enter Name OF Car ");
                        carName = Console.ReadLine();

                        Console.WriteLine("Enter ID OF Car ");
                        carID = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Color OF Car ");
                        carColor = Console.ReadLine();

                        Console.WriteLine("Enter Price OF Car ");
                        carPrice = Convert.ToDouble(Console.ReadLine());
                    }
                    catch (FormatException fe1)
                    {

                    }
                }
                Console.Clear();

                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                //here is the switch statement that would work to add the cars according to user choose
                switch (user_chosee)
                {
                    case 1:
                        try
                        {
                            Hyundai h = new Hyundai();
                            h.Name = carName;
                            h.Id = carID;
                            h.Price = carPrice;
                            h.Color = carColor;
                            h.Add_data();
                            Console.WriteLine("Done to Hyundai");
                        }
                        catch (FormatException fe1)
                        {
                            Console.WriteLine(" you have enter invailed option ");
                        }
                        break;

                    case 2:
                        try
                        {
                            Toyota t = new Toyota();
                            t.Name = carName;
                            t.Id = carID;
                            t.Price = carPrice;
                            t.Color = carColor;
                            t.Add_data();
                            Console.WriteLine("Done to Toyota");
                        }
                        catch (FormatException fe1)
                        {
                            Console.WriteLine(" you have enter invailed option ");
                        }
                        break;

                    case 3:
                        try
                        {
                            Ford f = new Ford();
                            f.Name = carName;
                            f.Id = carID;
                            f.Price = carPrice;
                            f.Color = carColor;
                            f.Add_data();
                            Console.WriteLine("Done to Ford");
                        }
                        catch (FormatException fe1)
                        {
                            Console.WriteLine(" you have enter invailed option ");
                        }
                        break;

                    case 4:
                        try
                        {
                            BMW bmw = new BMW();
                            bmw.Name = carName;
                            bmw.Id = carID;
                            bmw.Price = carPrice;
                            bmw.Color = carColor;
                            bmw.Add_data();
                            Console.WriteLine("Done to BMW");
                        }
                        catch (FormatException fe1)
                        {
                            Console.WriteLine(" you have enter invailed option ");
                        }
                        break;

                    case 5:
                        try
                        {
                            Audi a = new Audi();
                            a.Name = carName;
                            a.Id = carID;
                            a.Price = carPrice;
                            a.Color = carColor;
                            a.Add_data();
                            Console.WriteLine("Done to Audi");
                        }
                        catch (FormatException fe1)
                        {
                            Console.WriteLine(" you have enter invailed option ");
                        }
                        break;
                    case 6:
                        Hyundai hh = new Hyundai();
                        String[] arr = hh.Show_result();
                        for (int i = 0; i < arr.Length; i++)
                        {
                            try
                            {
                                String[] ss = arr[i].Split(' ');
                                Console.WriteLine("id is : " + ss[0] + " " +
                                    " Car name is : " + ss[1] + " " +
                                    "Color is : " + ss[2] + " " +
                                    "And Price is : " + ss[3]);
                            }
                            catch (FormatException fe1)
                            {
                                Console.WriteLine(" you have enter invailed option ");
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(" you have enter invailed option ");
                            }
                        }
                        break;

                    case 7:
                        Toyota tt = new Toyota();
                        String[] arr1 = tt.Show_result();
                        for (int i = 0; i < arr1.Length; i++)
                        {
                            try
                            {
                                String[] ss1 = arr1[i].Split(' ');
                                Console.WriteLine("id is : " + ss1[0] + " " +
                                    " Car name is : " + ss1[1] + " " +
                                    "Color is : " + ss1[2] + " " +
                                    "And Price is : " + ss1[3]);
                            }
                            catch (FormatException fe1)
                            {
                                Console.WriteLine(" you have enter invailed option ");
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(" you have enter invailed option ");
                            }
                            finally
                            {
                                Console.WriteLine(" erros");
                            }
                        }
                        break;

                    case 8:
                        Ford ff = new Ford();
                        String[] arr2 = ff.Show_result();
                        for (int i = 0; i < arr2.Length; i++)
                        {
                            try
                            {
                                String[] ss2 = arr2[i].Split(' ');
                                Console.WriteLine("id is : " + ss2[0] + " " +
                                    " Car name is : " + ss2[1] + " " +
                                    "Color is : " + ss2[2] + " " +
                                    "And Price is : " + ss2[3]);
                            }
                            catch (FormatException fe1)
                            {
                                Console.WriteLine(" you have enter invailed option ");
                            }
                            catch (Exception e)
                            {

                            }
                        }
                        break;

                    case 9:
                        BMW bm = new BMW();
                        String[] arr3 = bm.Show_result();
                        for (int i = 0; i < arr3.Length; i++)
                        {
                            try
                            {
                                String[] ss3 = arr3[i].Split(' ');
                                Console.WriteLine("id is : " + ss3[0] + " " +
                                      " Car name is : " + ss3[1] + " " +
                                      "Color is : " + ss3[2] + " " +
                                      "And Price is : " + ss3[3]);
                            }
                            catch (FormatException fe1)
                            {
                                Console.WriteLine(" you have enter invailed option ");
                            }
                            catch (Exception e)
                            {


                            }
                        }
                        break;

                    case 10:
                        Audi aa = new Audi();
                        String[] arr4 = aa.Show_result();
                        for (int i = 0; i < arr4.Length; i++)
                        {
                            try
                            {
                                String[] ss4 = arr4[i].Split(' ');
                                Console.WriteLine("id is : " + ss4[0] + " " +
                                    " Car name is : " + ss4[1] + " " +
                                    "Color is : " + ss4[2] + " " +
                                    "And Price is : " + ss4[3]);
                            }
                            catch (FormatException fe1)
                            {
                                Console.WriteLine(" you have enter invailed option ");
                            }
                            catch (Exception e)
                            {

                            }
                        }
                        break;
                    case 11:
                        try
                        {
                            Console.WriteLine("Enter Car ID");
                            int new_id = Convert.ToInt32(Console.ReadLine());
                            Hyundai se = new Hyundai();
                            Toyota se1 = new Toyota();
                            Ford se2 = new Ford();
                            BMW se3 = new BMW();
                            Audi se4 = new Audi();
                            String[] l1 = se.Show_result();
                            String[] l2 = se1.Show_result();
                            String[] l3 = se2.Show_result();
                            String[] l4 = se3.Show_result();
                            String[] l5 = se4.Show_result();
                            l1[0].Contains(new_id.ToString());
                            l2[0].Contains(new_id.ToString());
                            l3[0].Contains(new_id.ToString());
                            l4[0].Contains(new_id.ToString());
                            l5[0].Contains(new_id.ToString());
                            for (int i = 0; i < l1.Length; i++)
                            {
                                if (l1[i].Contains(new_id.ToString()))
                                    Console.WriteLine(l1[i]);
                                else
                                    Console.WriteLine(" sorry The Id you have enter is not in the system ");
                            }
                            for (int i = 0; i < l2.Length; i++)
                            {
                                if (l2[i].Contains(new_id.ToString()))
                                    Console.WriteLine(l2[i]);
                                else
                                    Console.WriteLine(" sorry The Id you have enter is not in the system ");
                            }
                            for (int i = 0; i < l3.Length; i++)
                            {
                                if (l3[i].Contains(new_id.ToString()))
                                    Console.WriteLine(l3[i]);
                                else
                                    Console.WriteLine(" sorry The Id you have enter is not in the system ");
                            }
                            for (int i = 0; i < l4.Length; i++)
                            {
                                if (l4[i].Contains(new_id.ToString()))
                                    Console.WriteLine(l4[i]);
                                else
                                    Console.WriteLine(" sorry The Id you have enter is not in the system ");
                            }
                            for (int i = 0; i < l5.Length; i++)
                            {
                                if (l5[i].Contains(new_id.ToString()))
                                    Console.WriteLine(l5[i]);
                                else
                                    Console.WriteLine(" sorry The Id you have enter is not in the system ");
                            }
                        }
                        catch (FormatException fe1)
                        {
                            Console.WriteLine(" you have enter invailed option ");
                        }
                        break;

                    default:
                        Console.WriteLine(" You have enter invalid option");
                        break;

                }
                Console.WriteLine(" if you want to back to the mean menu press 'y' or press 'n' to quit the app");
                res = Console.ReadLine().ToLower();
                Console.Clear();
            } while (res != "n" && res=="y");
        }
    }
}
