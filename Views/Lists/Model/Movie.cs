using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMAUIGallery.Views.Lists.Model
{
    public class Movie
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public TimeSpan Duration { get; set; }
        public short LaunchYear { get; set; }

        public ImageSource Image { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Name} - {LaunchYear}";
        }
    }

    public class GroupMovie : List<Movie>
    {
        public string CompanyName { get; set; }
    }

    public class MovieList
    {
        public static List<GroupMovie> GetGroupList()
        {
            var disneyGroup = new GroupMovie() { CompanyName = "Disney" };

            disneyGroup.Add(new Movie()
            {
                Id = 1,
                Name = "Estação Espacial Internacional",
                Description = "Em um futuro próximo, a tensão aumenta a bordo da Estação Espacial Internacional quando um conflito mundial eclode na Terra. Abalados, os astronautas norte-americanos e russos recebem ordens da base: assumir o controle da estação a qualquer custo.",
                LaunchYear = 2024,
                Duration = new TimeSpan(2, 22, 00),
                

            });

            disneyGroup.Add(new Movie()
            {
                Id = 2,
                Name = "Deadpool & Wolverine",
                Description = "Wolverine está se recuperando quando cruza seu caminho com Deadpool. Juntos, eles formam uma equipe e enfrentam um inimigo em comum.",
                LaunchYear = 2024,
                Duration = new TimeSpan(2, 39, 00),
                Image = ImageSource.FromFile("https://faarq.ufpa.br/wp-content/uploads/2020/11/nathalia_nascimento-50x50.png"),        

            });

            disneyGroup.Add(new Movie()
            {
                Id = 3,
                Name = "Coringa: Delírio a Dois",
                Description = "Arthur Fleck está internado em Arkham, aguardando julgamento por seus crimes como o Coringa. Enquanto lida com sua dupla identidade, ele não só se depara com o amor verdadeiro, mas encontra a música que sempre esteve dentro de si..",
                LaunchYear = 2024,
                Duration = new TimeSpan(2, 51, 00),

            });

            var paramountGroup = new GroupMovie() { CompanyName = "Paramount" };
            paramountGroup.Add(new Movie()
            {
                Id = 4,
                Name = "Transformers: O Início",
                Description = "A história que nunca antes havia sido contada. A origem de Optimus Prime e Megatron, duas figuras lendárias que em sua juventude foram irmãos de armas, lutando juntos pelo futuro de seu planeta natal, Cybertron.",
                LaunchYear = 2024,
                Duration = new TimeSpan(1, 44, 00),

            });

            paramountGroup.Add(new Movie()
            {
                Id = 5,
                Name = "Planeta dos Macacos: A Origem",
                Description = "Um chimpanzé de laboratório desenvolve inteligência e emoções humanas e uma batalha épica surge para determinar qual espécie será dominante no planeta Terra",
                LaunchYear = 2011,
                Duration = new TimeSpan(1, 45, 00),

            });

            paramountGroup.Add(new Movie()
            {
                Id = 6,
                Name = "Querido Papai Noel",
                Description = "Um garoto comete um erro de ortografia ao enviar sua lista de presentes para o Papai Noel e acaba enviando a carta para o diabo.",
                LaunchYear = 2024,
                Duration = new TimeSpan(1, 43, 00),

            });

            paramountGroup.Add(new Movie()
            {
                Id = 7,
                Name = "The Kitchen",
                Description = "Izi está prestes a sair do The Kitchen, um dos últimos conjuntos habitacionais de Londres. Mas precisa tomar decisões difíceis quando o jovem Benji entra em sua vida.",
                LaunchYear = 2024,
                Duration = new TimeSpan(1, 47, 00),

            });

            var universalGroup = new GroupMovie() { CompanyName = "Universal" };
            universalGroup.Add(new Movie()
            {
                Id = 8,
                Name = "A Forja: O Poder da Transformação",
                Description = "Um ano depois de terminar o ensino médio e sem planos para o futuro, Isaiah é desafiado por sua mãe solteira e um empresário de sucesso a começar um relacionamento com Deus para traçar um rumo melhor para sua vida.",
                LaunchYear = 2024,
                Duration = new TimeSpan(2, 3, 00),

            });

            universalGroup.Add(new Movie()
            {
                Id = 9,
                Name = "Hellboy: The Crooked Man",
                Description = "Hellboy se une à Bobbie Jo Song, uma novata agente, para uma nova investigação nas Montanhas Apalaches. Lá, descobrem uma remota e assombrada comunidade dominada por bruxas, liderada pelo sinistro demônio local, conhecido como O Homem Torto.",
                LaunchYear = 2024,
                Duration = new TimeSpan(1, 40, 00),

            });

            universalGroup.Add(new Movie()
            {
                Id = 10,
                Name = "Dunkirk",
                Description = "Durante a Segunda Guerra Mundial, a Alemanha avança rumo à França e cerca as tropas aliadas nas praias de Dunkirk. Sob cobertura aérea e terrestre das forças britânicas e francesas, as tropas são lentamente evacuadas da praia.",
                LaunchYear = 2017,
                Duration = new TimeSpan(1, 46, 00),

            });



            List<GroupMovie> list = new List<GroupMovie>()
            {
                disneyGroup,
                paramountGroup,
                universalGroup
                
            };

            return list;
            
        }
        public static List<Movie> GetList()
        {
            List<Movie> list = new List<Movie>();   
            list.Add(new Movie() 
            { 
                Id = 1, 
                Name = "Estação Espacial Internacional", 
                Description = "Em um futuro próximo, a tensão aumenta a bordo da Estação Espacial Internacional quando um conflito mundial eclode na Terra. Abalados, os astronautas norte-americanos e russos recebem ordens da base: assumir o controle da estação a qualquer custo.",
                LaunchYear = 2024,
                Duration = new TimeSpan(2,22,00),
                Image = ImageSource.FromFile("https://cinema10.com.br/upload/filmes/filmes_17317_mv5bmwvlytvmyjutzdm0nc00yzi5ltg2zdktn2e2ytq5otdlmtu3xkeyxkfqcgdeqxvymtkxnjuynq._V1_.jpg"),

            });

            list.Add(new Movie()
            {
                Id = 2,
                Name = "Deadpool & Wolverine",
                Description = "Wolverine está se recuperando quando cruza seu caminho com Deadpool. Juntos, eles formam uma equipe e enfrentam um inimigo em comum.",
                LaunchYear = 2024,
                Duration = new TimeSpan(2, 39, 00),
                Image = ImageSource.FromFile("https://upload.wikimedia.org/wikipedia/pt/2/2a/Deadpool_%26_Wolverine_cartaz.jpg"),

            });

            list.Add(new Movie()
            {
                Id = 3,
                Name = "Coringa: Delírio a Dois",
                Description = "Arthur Fleck está internado em Arkham, aguardando julgamento por seus crimes como o Coringa. Enquanto lida com sua dupla identidade, ele não só se depara com o amor verdadeiro, mas encontra a música que sempre esteve dentro de si..",
                LaunchYear = 2024,
                Duration = new TimeSpan(2, 51, 00),

            });

            list.Add(new Movie()
            {
                Id = 4,
                Name = "Transformers: O Início",
                Description = "A história que nunca antes havia sido contada. A origem de Optimus Prime e Megatron, duas figuras lendárias que em sua juventude foram irmãos de armas, lutando juntos pelo futuro de seu planeta natal, Cybertron.",
                LaunchYear = 2024,
                Duration = new TimeSpan(1, 44, 00),

            });

            list.Add(new Movie()
            {
                Id = 5,
                Name = "Planeta dos Macacos: A Origem",
                Description = "Um chimpanzé de laboratório desenvolve inteligência e emoções humanas e uma batalha épica surge para determinar qual espécie será dominante no planeta Terra",
                LaunchYear = 2011,
                Duration = new TimeSpan(1, 45, 00),

            });

            list.Add(new Movie()
            {
                Id = 6,
                Name = "Querido Papai Noel",
                Description = "Um garoto comete um erro de ortografia ao enviar sua lista de presentes para o Papai Noel e acaba enviando a carta para o diabo.",
                LaunchYear = 2024,
                Duration = new TimeSpan(1, 43, 00),

            });

            list.Add(new Movie()
            {
                Id = 7,
                Name = "The Kitchen",
                Description = "Izi está prestes a sair do The Kitchen, um dos últimos conjuntos habitacionais de Londres. Mas precisa tomar decisões difíceis quando o jovem Benji entra em sua vida.",
                LaunchYear = 2024,
                Duration = new TimeSpan(1, 47, 00),

            });

            list.Add(new Movie()
            {
                Id = 8,
                Name = "A Forja: O Poder da Transformação",
                Description = "Um ano depois de terminar o ensino médio e sem planos para o futuro, Isaiah é desafiado por sua mãe solteira e um empresário de sucesso a começar um relacionamento com Deus para traçar um rumo melhor para sua vida.",
                LaunchYear = 2024,
                Duration = new TimeSpan(2, 3, 00),

            });

            list.Add(new Movie()
            {
                Id = 9,
                Name = "Hellboy: The Crooked Man",
                Description = "Hellboy se une à Bobbie Jo Song, uma novata agente, para uma nova investigação nas Montanhas Apalaches. Lá, descobrem uma remota e assombrada comunidade dominada por bruxas, liderada pelo sinistro demônio local, conhecido como O Homem Torto.",
                LaunchYear = 2024,
                Duration = new TimeSpan(1, 40, 00),

            });

            list.Add(new Movie()
            {
                Id = 10,
                Name = "Dunkirk",
                Description = "Durante a Segunda Guerra Mundial, a Alemanha avança rumo à França e cerca as tropas aliadas nas praias de Dunkirk. Sob cobertura aérea e terrestre das forças britânicas e francesas, as tropas são lentamente evacuadas da praia.",
                LaunchYear = 2017,
                Duration = new TimeSpan(1, 46, 00),

            });
            return list;    
        }

    }
}
