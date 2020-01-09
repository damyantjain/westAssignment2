using System;
using System.Collections.Generic;
using Demo.Models;

namespace Demo.ViewModels
{
    public class GroupIndexViewModel
    {
        public Group NewGroup { get; set; }
        public List<Group> Groups { get; set; }
    }
}
