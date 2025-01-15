namespace Day1;
[Flags]
public enum Permisions
{
    None = 0,//0000
    Read = 1,//0001
    Write = 2,//0010
    Execute = 4,//0100
    Delete = 8,//1000
    Admin = Read | Write | Execute | Delete//1111
}
