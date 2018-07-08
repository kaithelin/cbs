using System;
using Concepts;
using Dolittle.Commands;

namespace Domain.StaffUser.Changing
{
    public class ChangeUserLocation : ICommand
    {
        public Guid StaffUserId { get; set; }
        public Location Location { get; set; }

        public Role Role { get; set; }
    }
}