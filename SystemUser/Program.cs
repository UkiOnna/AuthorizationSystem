using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;
using Enternace;
namespace SystemUser
{
    class Program
    {
        static void Main(string[] args)
        {
            int choose,chooseRegistration,chooseAutohrization;
            bool isRegistrationMenu = true, isAutohorizationOk=true;
            string nameUser, firstNameUser, emailUser, numberUser, passwordUser,checkName,checkPassword; 
            bool isNameOk=true,isFirstNameOk=true,isEmailOk=false,isNumberOk=true,isPasswordOk=true;
            bool isCheckingPasswordOk=false, isCheckingNameOk = false;
            User user=new User();
            //цикл с меню
            //3 кейса 
            //1 кейс выводит менюшку где надо выйти назад (все в цикле)
            //2 кейс выведет менюшку с циклом так же где нужно выйти
            while (true)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("1 - Регистрация");
                Console.WriteLine("2 - Войти");
                Console.WriteLine("3 - Выход");
                int.TryParse(Console.ReadLine(), out choose);
                switch (choose)
                {
                    case 1:
                        isRegistrationMenu = true;
                        while (isRegistrationMenu)
                        {
                            Console.Clear();
                            Console.SetCursorPosition(0, 0);
                            Console.WriteLine("1 - Имя");
                            Console.WriteLine("2 - Фамилия");
                            Console.WriteLine("3 - Email");
                            Console.WriteLine("4 - Номер телефона");
                            Console.WriteLine("5 - Пароль");
                            Console.WriteLine("6 - Назад");
                            int.TryParse(Console.ReadLine(), out chooseRegistration);
                            switch (chooseRegistration)
                            {
                                case 1:
                                    isNameOk = true;
                                    Console.WriteLine("Введите ваше имя ");
                                    nameUser = Console.ReadLine();
                                    for (int i = 0; i < nameUser.Length; i++)
                                    {
                                        if (nameUser[i] >= '0' && nameUser[i] <= '9')
                                        {
                                            isNameOk = false;
                                            break;
                                        }
                                    }
                                    if (isNameOk)
                                    {
                                        user.SetName(nameUser);
                                        Console.WriteLine("Ваше имя зарегистрированно");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Вы ввели неверное имя,попробуйте еще раз");
                                    }
                                    Console.ReadLine();
                                    Console.Clear();
                                    
                                    break;

                                case 2:
                                    isFirstNameOk = true;
                                    Console.WriteLine("Введите вашу фамилию ");
                                    firstNameUser = Console.ReadLine();
                                    for (int i = 0; i < firstNameUser.Length; i++)
                                    {
                                        if (firstNameUser[i] >= '0' && firstNameUser[i] <= '9')
                                        {
                                            
                                            isFirstNameOk = false;
                                            break;
                                        }
                                    }
                                    if (isFirstNameOk)
                                    {
                                        user.SetFirstNAme(firstNameUser);
                                        Console.WriteLine("Ваша фамилия зарегистрированно");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Вы ввели неверную фамилию,попробуйте еще раз");
                                    }
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;

                                case 3:
                                    isEmailOk = false;
                                    Console.WriteLine("Введите ваш Эмайл ");
                                    emailUser = Console.ReadLine();
                                    for (int i = 0; i < emailUser.Length; i++)
                                    {
                                        if (emailUser[i] =='@')
                                        {

                                            isEmailOk = true;
                                            break;
                                        }
                                    }
                                    if (isEmailOk)
                                    {
                                        user.SetEmail(emailUser);
                                        Console.WriteLine("Ваш Email зарегистрирован");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Вы ввели неверный Email,попробуйте еще раз");
                                    }
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;

                                case 4:
                                    Console.WriteLine("Введите ваш Телефон ");
                                    numberUser = Console.ReadLine();
                                    for (int i = 0; i < numberUser.Length; i++)
                                    {
                                        if (numberUser[i] >= '0' && numberUser[i] <= '9')
                                        {

                                            isNumberOk = true;
                                           
                                        }
                                        else
                                        {
                                            isNumberOk = false;
                                            break;
                                        }
                                    }
                                    if (isNumberOk)
                                    {
                                        user.SetNumber(numberUser);
                                        Console.WriteLine("Ваш Телефон зарегистрирован");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Вы ввели неверный Телефон,попробуйте еще раз");
                                    }
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;

                                case 5:
                                    Console.WriteLine("Введите ваш пароль ");
                                   passwordUser = Console.ReadLine();
                                    if (passwordUser.Length == 0)
                                    {
                                        isPasswordOk = false;
                                    }
                                    for (int i = 0; i < passwordUser.Length; i++)
                                    {
                                      if(passwordUser[i]==' ')
                                        {
                                            isPasswordOk = false;
                                            break;
                                        }
                                    }
                                    if (isPasswordOk)
                                    {
                                        user.SetPassword(passwordUser);
                                        Console.WriteLine("Ваш пароль зарегистрирован");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Вы ввели неправильный пароль");
                                    }
                                    Console.ReadLine();
                                    Console.Clear();
                                    break;

                                case 6:
                                    isRegistrationMenu = false;
                                    
                                    break;
                            }
                        }
                        Console.Clear();
                        break;

                    case 2:
                        if (isEmailOk && isFirstNameOk && isNameOk && isNumberOk&&isPasswordOk)
                        {
                            isAutohorizationOk = true;
                            while (isAutohorizationOk)
                            {
                                Console.Clear();
                                Console.SetCursorPosition(0, 0);
                                Console.WriteLine("1 - Авторизация");
                                Console.WriteLine("2 - Вспомнить пароль");
                                Console.WriteLine("3 - Назад");
                                int.TryParse(Console.ReadLine(), out chooseAutohrization);
                                switch (chooseAutohrization)
                                {
                                    case 1:
                                        Console.WriteLine("Введите Email или номер телефона");
                                        checkName = Console.ReadLine();
                                        if ((checkName == user.GetName()) || (checkName == user.GetNumber()))
                                        {
                                            isCheckingNameOk = true;
                                        }
                                        Console.WriteLine("Введите пароль");
                                        checkPassword = Console.ReadLine();
                                        if (checkPassword == user.GetPassword())
                                        {
                                            isCheckingPasswordOk = true;
                                        }
                                        if (isCheckingNameOk && isCheckingPasswordOk)
                                        {
                                            Console.WriteLine("Вы вошли");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Вы ввели неправильный логин или пароль");
                                        }
                                        Console.ReadLine();
                                        Console.Clear();
                                        break;


                                    case 2:
                                        Console.WriteLine("Введите ваш Email");
                                        checkName = Console.ReadLine();
                                        
                                        const string accountSid = "ACa3a0aa93822680c0df0f954abfaa5010";
                                        const string authToken = "660eefc858c608383d38fac4633279d3";
                                        TwilioClient.Init(accountSid, authToken);
                                        var mediaUrl = new List<System.Uri>()
        {
            new Uri( "https://climacons.herokuapp.com/clear.png" )
        };
                                        var to = new PhoneNumber("+77779561787");
                                        var message = MessageResource.Create(
                                          to,
                                          from: new PhoneNumber("+18317049551"),
                                          body: user.GetPassword(),
                                          mediaUrl: mediaUrl);
                                        Console.WriteLine(message.Sid);
                                        break;


                                    case 3:
                                        isAutohorizationOk = false;
                                        break;
                                }
                                
                                }
                        }
                        else
                        {
                            Console.WriteLine("Вы не прошли регистрацию до конца");
                        }
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case 3:
                        Environment.Exit(0);
                        break;

                }
            }
        }
    }
}
