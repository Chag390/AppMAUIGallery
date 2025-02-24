using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppMAUIGallery.Models;
using AppMAUIGallery.Repositories;
using AppMAUIGallery.Views.Layouts;


namespace AppMAUIGallery.Repositories
{
    public partial class GroupComponentRepository : IGroupComponentRepository1
    {
        private void LoadData()
        {
            _components = new List<Component>();
            _groupcomponents = new List<GroupComponent>();

            LoadLayout();
        }

        private void LoadLayout()
        {
            var components = new List<Component>
            {
                new Component
                {
                Title = "StackLayout",
                Description = "Organização sequencial dos elementos.",
                Page = typeof(StackLayoutPage)
                },
                new Component
                {
                    Title = "Grid",
                    Description = "Organiza os elementos dentro de uma tabela.",
                    Page = typeof(GridLayoutPage)
                },
                new Component
                {
                    Title = "AbsoluteLayout",
                    Description = "Liberdade Total para posicionar e dimensionar os elementos na tela",
                    Page = typeof(AbsoluteLayoutPage)
                },
                new Component
                {
                    Title = "FlexLayout",
                    Description = "Organiza os elementos de forma sequencial com muitas opções de personalização.",
                    Page = typeof(FlexLayoutPage)
                }

        }; //Criando uma lista de componentes

            var group = new GroupComponent() { Name = "Layout" }; // Criando um grupo de componentes
            group.AddRange(components);

            _components.AddRange(components); // Adicionando os componentes na lista de componentes
            _groupcomponents.Add(group); // Adicionando o grupo de componentes na lista de grupos de componentes


        }

    }
}