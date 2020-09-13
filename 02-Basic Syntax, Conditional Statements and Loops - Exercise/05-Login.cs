using System;

namespace IntroUI {
    public class Login {
        public static void Main () {
            string username = Console.ReadLine ();
            string eventuallyPass = Console.ReadLine ();
            int timesLogin = 0;

            string password = "";
            for (int i = 0; i < username.Length; i++) {
                password += username[username.Length - 1 - i];
            }

            if (password == eventuallyPass)
            {
                Console.WriteLine($"User {username} logged in.");
                return;
            }



            while (eventuallyPass[0] != password[0]) {
                timesLogin++;
                if (timesLogin == 4) 
                {
                   Console.WriteLine($"User {username} blocked!");
                    break;
                }
                
                Console.WriteLine ("Incorrect password. Try again.");
                eventuallyPass = Console.ReadLine ();
                
               if (eventuallyPass == password) 
                {
                    Console.WriteLine ($"User {username} logged in.");
                    break;
                }
            }
        }
    }
}