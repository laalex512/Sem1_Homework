/*1. В переменной string есть секретное сообщение, во второй есть пароль. 
Пользователю программы даётся 3 попытки ввести пароль и увидеть секретное сообщение.*/

string message = "This is secret message";
string password = "123456";
int attempt = 0;
string attemptPassword;
int leftTries; 

while (attempt<3) 
{
    leftTries = 3-attempt; 
    Console.WriteLine("Insert password ( "+leftTries+" tries left)");
    attemptPassword= Console.ReadLine();
    if (attemptPassword==password) 
    {
        Console.WriteLine("Right password. Message: " + message);
        break;
    }
    else Console.Write("Fail. ");
    attempt++;
}
if (attempt==3) Console.WriteLine("Sorry. You're loose");