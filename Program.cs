Permissions normalUserPermissions = Permissions.Read | Permissions.Write;
Permissions adminUserPermissions = Permissions.Read | Permissions.Write | Permissions.Delete | Permissions.Publish | Permissions.Admin;

Console.WriteLine("Checking Permission...");
Console.WriteLine();

Console.WriteLine("Normal User Permissions: " + normalUserPermissions + "\n");
Console.WriteLine("Admin User Permissions: " + adminUserPermissions + "\n");

void CheckPermission(string userName, Permissions userPermission, Permissions requiredPermission)
{
    
    if ((userPermission & requiredPermission) == requiredPermission)
    {
        Console.WriteLine($"{userName} trying to {requiredPermission}: Access Granted");
    }
    else
    {
        Console.WriteLine($"{userName} trying to {requiredPermission}: Access Denied");
    }
}

CheckPermission ("Normal User", normalUserPermissions, Permissions.Delete);
CheckPermission("Admin User", adminUserPermissions, Permissions.Publish);
CheckPermission("Normal User", normalUserPermissions, Permissions.Read);