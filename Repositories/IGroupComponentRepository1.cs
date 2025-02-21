using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppMAUIGallery.Models;

namespace AppMAUIGallery.Repositories
{
    public interface IGroupComponentRepository1
    {
        List<GroupComponent> GetGroupsComponents();

        List<Component> GetComponents();

    }
}