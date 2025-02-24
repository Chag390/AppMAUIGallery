using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using AppMAUIGallery.Models;
using AppMAUIGallery.Repositories;
using AppMAUIGallery.Views.Components.Forms;
using AppMAUIGallery.Views.Components.Mains;
using AppMAUIGallery.Views.Components.Visuals;
using AppMAUIGallery.Views.Layouts;
using Microsoft.Office.Interop.Outlook;


namespace AppMAUIGallery.Repositories
{
    public partial class GroupComponentRepository : IGroupComponentRepository1
    {
        private void LoadData()
        {
            _components = new List<Component>();
            _groupcomponents = new List<GroupComponent>();

            LoadLayouts();
            LoadControls();
            LoadVisuals();
            LoadForms();    
        }

        private void LoadLayouts()
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

        private void LoadControls()
        {
            var components = new List<Component>
            {

                new Component
                {
                    Title = "BoxView",
                    Description = "Um componente que cria uma caixa para ser apresentada",
                    Page = typeof(BoxViewPage)
                },
                new Component
                {
                    Title = "Label",
                    Description = "Apresenta um texto na tela",
                    Page = typeof(LabelPage)
                },
                new Component
                {
                    Title = "Button",
                    Description = "Apresenta um botão na tela",
                    Page = typeof(ButtonPage)
                },
                new Component
                {
                    Title = "Image",
                    Description = "Apresenta uma imagem na tela",
                    Page = typeof(ImagePage)
                },
                new Component
                {
                    Title = "ImageButton",
                    Description = "Apresenta uma imagem com comportamento de botão",
                    Page = typeof(ImageButtonPage)
                }
            };

            var group = new GroupComponent() { Name = "Controles (Views)" }; // Criando um grupo de componentes
            group.AddRange(components);

            _components.AddRange(components); // Adicionando os componentes na lista de componentes
            _groupcomponents.Add(group); // Adicionando o grupo de componentes na lista de grupos de componentes

        }

        private void LoadVisuals()
        {
            var components = new List<Component>
            {
                new Component
                {
                    Title = "Frame",
                    Description = "Caixa que envolve outros elementos",
                    Page = typeof(FramePage)
                },
                new Component
                {
                    Title = "Border",
                    Description = "Caixa que envolve outros elementos",
                    Page = typeof(BorderPage)
                },
                new Component
                {
                    Title = "Shadow",
                    Description = "Caixa que envolve outros elementos",
                    Page = typeof(ShadowPage)
                }

            };

            var group = new GroupComponent() { Name = "Visuais" }; // Criando um grupo de componentes
            group.AddRange(components);

            _components.AddRange(components); // Adicionando os componentes na lista de componentes
            _groupcomponents.Add(group); // Adicionando o grupo de componentes na lista de grupos de componentes

        }

        private void LoadForms()
        {
            var components = new List<Component>
            {
                new Component
                {
                    Title = "Entry",
                    Description = "Caixa de entrada de texto. ",
                    Page = typeof(EntryPage)
                },
                new Component
                {
                    Title = "Editor",
                    Description = "Caixa de entrada de texto de multiplas linhas. ",
                    Page = typeof(EditorPage)
                },
                new Component
                {
                    Title = "CheckBox",
                    Description = "Cria uma caixa de marcação. ",
                    Page = typeof(CheckBoxPage)
                },
                new Component
                {
                    Title = "RadioButton",
                    Description = "Cria uma caixa de marcação de escolha única. ",
                    Page = typeof(RadioButtonPage)
                },
                new Component
                {
                    Title = "Switch",
                    Description = "Caixa de marcação Booleana",
                    Page = typeof(SwitchPage)
                },
                new Component
                {
                    Title = "StepperPage",
                    Description = "Cria opções de  incrementrar ou encrementar um numero",
                    Page = typeof(StepperPage)
                },
                new Component
                {
                    Title = "Slider",
                    Description = "Cria barra que incrementrar ou encrementar um numero",
                    Page = typeof(SliderPage)
                },
                new Component
                {
                    Title = "TimePicker",
                    Description = "Seleciona hora e minuto",
                    Page = typeof(TimePicherPage)
                },
                new Component
                {
                    Title = "DatePicker",
                    Description = "Seleciona data",
                    Page = typeof(DatePickerPage)
                },

                new Component
                {
                    Title = "SearchBar",
                    Description = "Campo de entrada de texto para pesquisa",
                    Page = typeof(SearchBarPage)
                },

                new Component
                {
                    Title = "Picker",
                    Description = "Selecionar em item da lista",
                    Page = typeof(PickerPage1)
                },

            };
            
            var group = new GroupComponent() { Name = "Formulários" }; // Criando um grupo de componentes
            group.AddRange(components);

            _components.AddRange(components); // Adicionando os componentes na lista de componentes
            _groupcomponents.Add(group); // Adicionando o grupo de componentes na lista de grupos de componentes

        }
    }
}