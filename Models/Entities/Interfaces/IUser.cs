using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Interfaces
{
    public interface IUser
    {
        int ID { get; set; }
        string Name { get; set; }
        string Email { get; set; }
    }
}
