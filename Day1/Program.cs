using System.Text.Json;
using Day1;

#region Indexers
//var intIndexerExample = new IntIndexerExample();
////intIndexerExample.Number;

//var page = new Page();
//for (int i = 0; i < 10; i++)
//{
//	page.Names[i] = $"Islam{i}";
//}
#endregion

#region Enum
//var orderStatus = OrderStatus.Pending;
//Console.WriteLine(orderStatus);
//Console.WriteLine((int)orderStatus);

//Enum.TryParse<OrderStatus>("Delivered", out var orderStatus3);

//Console.WriteLine($"Delivered Order Status Value Is {orderStatus3}");
//Console.WriteLine((OrderStatus)8);
//Console.WriteLine(Enum.IsDefined((OrderStatus)8));

//Console.WriteLine(JsonSerializer.Serialize(Enum.GetNames<OrderStatus>()));
//Console.WriteLine(JsonSerializer.Serialize(Enum.GetValues<OrderStatus>())); 
#endregion

var userManager = new UserPermissionsManager();
Console.WriteLine($"Intial Value For UserPermissionsManager is {userManager.GetPermission()}");

userManager.AddPermission(Permisions.Read);
userManager.AddPermission(Permisions.Write);

Console.WriteLine(userManager.GetPermission());

Console.WriteLine(userManager.HasPermission(Permisions.Read));

userManager.RemovePermission(Permisions.Read);
Console.WriteLine(userManager.GetPermission());

userManager.RemovePermission(Permisions.Write);
userManager.AddPermission(Permisions.Admin);
Console.WriteLine(userManager.GetPermission());


