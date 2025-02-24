using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppMAUIGallery.Models;
using AppMAUIGallery.Repositories;
using Bumptech.Glide.Load.Model;


namespace AppMAUIGallery.Repositories
{
    public partial class GroupComponentRepository : IGroupComponentRepository1
    {
        private List<Component> _components;
        private List<GroupComponent> _groupcomponents;
        public GroupComponentRepository()
        {
            LoadData();
        }

        public List<Component> GetComponents()
        {
            return _components;
        }

        public List<GroupComponent> GetGroupsComponents()
        {
            return _groupcomponents;
        }
    }

}
