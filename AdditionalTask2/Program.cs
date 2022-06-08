/*2. Есть программа с бесконечным циклом.
 Когда пользователь вводит exit программа заканчивается*/

 string stopWord = "exit";
 string insertMessage;
 while(true)
 {
     Console.WriteLine("Insert anything you want, except '"+stopWord+"':");
     insertMessage = Console.ReadLine();
     if (insertMessage==stopWord) 
     {
         Console.WriteLine("Bye!");
         break;
     }
 }