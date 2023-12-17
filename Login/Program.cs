/*
    dışarıdan kullanıcı adı ve şifre alınacak, kullanıcı login olana dek bu işlemi tekrarlayacak

    - verileri tupple'da tutunuz :) 
    - (string username, string password) user = ("admin", "123");
*/

(string username, string password) user = new("admin".ToLower(),"admin123".ToLower());

string username = string.Empty;
string password = string.Empty;

bool result = false;

do
{
    Console.Write("Username: ");
    username = Console.ReadLine();
    Console.Write("Password: ");
    password = Console.ReadLine();

    result = (user.username == username && user.password == password)? result = true : result = false;

    Console.WriteLine("Invalid username or password!");
    

} while (!result);

Console.WriteLine($"{user} is logged in");