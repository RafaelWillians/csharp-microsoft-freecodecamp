string permission = "Admin|Manager";
int level = 55;

Console.WriteLine($"{(permission.Contains("Admin") && level > 55 ? "Welcome, Super Admin user." : permission.Contains("Admin") && level <= 55 ? "Welcome, Admin user." : permission.Contains("Manager") && level >= 20 ? "Contact an Admin for access." : permission.Contains("Manager") && level < 20 ? "You do not have sufficient privileges." : "You do not have sufficient privileges." )}");
