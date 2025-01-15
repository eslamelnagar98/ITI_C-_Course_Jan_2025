namespace Day1;
public class UserPermissionsManager
{
    private Permisions _permission;
    public UserPermissionsManager(Permisions initialPermission = Permisions.None)
    {
        _permission = initialPermission;
    }

    public void AddPermission(Permisions permission)
    {
        //0001 Read
        //0010 Write
        //0011 Read And Write 
        _permission |= permission;
    }

    public void RemovePermission(Permisions permission)
    {
        //0011 Read And Write
        //0010 Write
        //1101 ^Write

        //0011 Read And Write
        //&
        //1101 ^Write
        //----------------
        //0001 Read
        _permission &= ~permission;
    }

    public bool HasPermission(Permisions permission)
    {
        return _permission.HasFlag(permission);
    }

    public string GetPermission()
    {
        return _permission.ToString();
    }
}
