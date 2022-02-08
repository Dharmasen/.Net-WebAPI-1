using System;

/// <summary>
/// Summary description for Class1
/// </summary>
/// 

public class Contact
{
    public int id { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public bool IsDeleted { get; set; } = false;


}

