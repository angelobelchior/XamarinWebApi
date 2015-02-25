using System.Collections.Generic;
namespace XamarinWebApi.Entidades
{
    public class Palestra
    {
        public string Tema { get; set; }
        public string Titulo { get; set; }
        public string Dia { get; set; }
        public string Hora { get; set; }
        public string Palestrante { get; set; }
        public string Descricao { get; set; }

        private static List<Palestra> ITEMS = new List<Palestra>();
        public static List<Palestra> Listar()
        {
            if (ITEMS != null)
            {
                Segunda();
                Terca();
                Quarta();
                Quinta();
                Sexta();
            }

            return ITEMS;
        }

        private static void Segunda()
        {
            var sqlServer = new Palestra
            {
                Tema = "SQL Server",
                Titulo = "Benefícios de conhecer Business Intelligence com SQL Server 2014",
                Dia = "Segunda-Feira",
                Hora = "19:00",
                Palestrante = "Diego Nogare",
                Descricao = "Acompanhe o MVP em SQL Server Diego Nogare nesta apresentação sobre BI com SQL Server 2014, e entenda como tirar melhor proveito da transformação de dados em informação e o potencial de uma aplicação de apoio à tomada de decisão. Veja onde e como utilizar o SQL Server Integration Services - SSIS, SQL Server Analysis Services - SSAS e SQL Server Reporting Services - SSRS."
            };

            var protegendoSql = new Palestra
            {
                Tema = "SQL Server",
                Titulo = "Protegendo o SQL Server de Hackers [Melhores Práticas]",
                Dia = "Segunda-Feira",
                Hora = "20:00",
                Palestrante = "Luan Moreno",
                Descricao = "Nessa sessão iremos aprender a nos proteger dos tipos de ataques que são realizadas contra SQL Server, não so entenderemos como seremos capazes de aplicar as melhores práticas de segurança, além de megulharmos no pensamento de um Hacker e como ele pode acessar o SQL Server, claro que após a sessão nós evitaremos tal conquista Pronto para aprender como um Hacker pode invadir seu SQL Server ? junte-se comigo nessa sessão de SQL Server + Kali Linux."
            };

            var dba = new Palestra
            {
                Tema = "SQL Server",
                Titulo = "Virei dba, e agora?",
                Dia = "Segunda-Feira",
                Hora = "21:00",
                Palestrante = "Luan Moreno",
                Descricao = "Se você é analista de sistemas+DBA, desenvolvedor+DBA, gerente de infra-estrutura+DBA, suporte técnico+DBA, estagiário+DBA ou mesmo um mero DBA, esse palestra pode ser útil pra você. Depois de trabalhar por vários anos com desenvolvimento e consultoria, o MVP em SQL Server Fabiano Amorim tenho gastado vários dias com tarefas do dia a dia de um DBA. Nessa sessão ele irá falar um pouco dessa atividade e mostrar algumas dicas que podem fazer seu dia a dia mais tranquilo. Espere assuntos do tipo, checklist, powershell, dicas e mais dicas…"
            };

            var mineracao = new Palestra
            {
                Tema = "SQL Server",
                Titulo = "Introdução à Mineração de Dados com SQL Server 2014 e além",
                Dia = "Segunda-Feira",
                Hora = "21:00",
                Palestrante = "Luan Moreno",
                Descricao = "Nessa sessão veremos o que é mineração de dados e como ela pode ser realizada utilizando ferramentas que fazem parte do pacote do SQL Server. Abordaremos quais são os métodos implementados pela Microsoft e como tirar proveito deles para extrair conhecimento e fazer previsões com os seus dados. Também abordaremos métodos não disponíveis no SQL Server, mas que fazem parte do kit de ferramentas de quem trabalha com mineração de dados."
            };

            ITEMS.Add(sqlServer);
            ITEMS.Add(protegendoSql);
            ITEMS.Add(dba);
            ITEMS.Add(mineracao);
        }

        private static void Terca()
        {
            var performance = new Palestra
            {
                Tema = "Web",
                Titulo = "Performance Web com ASP.NET MVC",
                Dia = "Terça-Feira",
                Hora = "19:00",
                Palestrante = "Rodolfo Fadino",
                Descricao = "Performance é uma fator de sucesso ou fracasso para nossas aplicações, seja para melhorar a experiência do usuário ou para diminuir o uso de recursos computacionais ela é muito importante. Veja nesta apresentação os principais fatores e as principais técnicas para melhorar a performance de nossas aplicações web. "
            };

            var asp = new Palestra
            {
                Tema = "Web",
                Titulo = "Asp.Net 5",
                Dia = "Terça-Feira",
                Hora = "20:00",
                Palestrante = "Eduardo Pires",
                Descricao = "Conheça o totalmente novo ASP.NET, as recentes novidades, relacionamento com o .NET Core 5 entre outras grandes novidades"
            };

            var roslyn = new Palestra
            {
                Tema = "Web",
                Titulo = "Roslyn e C#: conheça o projeto CodeCracker",
                Dia = "Terça-Feira",
                Hora = "21:00",
                Palestrante = "Giovanni Bassi",
                Descricao = "A grande novidade do C# e do VB para 2015 não são as excelentes novas funcionalidades do C# 6 e do VB 13, mas o fato de que agora o compilador do C# e do VB são escritos em C# e em VB, no projeto conhecido pelo codinome Roslyn. Isso abre uma série de oportunidades que não existiam antes. Nessa palestra conheça a nova arquitetura desses compiladores, o que isso significa pra você, e já conheça o CodeCracker, um projeto que aproveita uma das grandes novidades: os analisadores estáticos de código, para te ajudar a escrever melhor tanto C# quanto VB, e o melhor: é grátis, livre e open source."
            };

            var spa = new Palestra
            {
                Tema = "Web",
                Titulo = "Single Page Applications com AngularJS e WebAPI",
                Dia = "Terça-Feira",
                Hora = "22:00",
                Palestrante = "Andre Baltieri",
                Descricao = "Cansado dos posts do ASP.NET MVC? da confusão que o jQuery causa em seu JavaScript? Confira o futuro das aplicações web! "
            };

            ITEMS.Add(performance);
            ITEMS.Add(asp);
            ITEMS.Add(roslyn);
            ITEMS.Add(spa);
        }

        private static void Quarta()
        {
            var performance = new Palestra
            {
                Tema = "Desenvolvimento",
                Titulo = "Performance ao extremo para aplicações Web Mobile Devices",
                Dia = "Quarta-Feira",
                Hora = "19:00",
                Palestrante = "Alexandre Tarifa",
                Descricao = "Suas aplicações e sites na web em muito pouco tempo serão muito mais acessados por celulares e tablets do que por desktops... e você sabia que isso muda completamente o jogo? Nesta sessão será apresentado as principais técnicas e recursos para o desenvolvimento de aplicações web mobile... dicas de performance, otimizações, etc. "
            };

            var xamarin = new Palestra
            {
                Tema = "Desenvolvimento",
                Titulo = "Xamarin: Criando aplicações nativas multi-plataformas",
                Dia = "Quarta-Feira",
                Hora = "20:00",
                Palestrante = "Angelo Belchior",
                Descricao = "Xamarin é uma plataforma de desenvolvimento que te permite criar aplicações multi-plataforma utilizando C# de forma nativa. Compartilhe código C# entre iOS, Android e Windows Phone. "
            };

            var asp = new Palestra
            {
                Tema = "Desenvolvimento",
                Titulo = "ASP.Net vNext está quase pronto! Você está pronto?",
                Dia = "Quarta-Feira",
                Hora = "21:00",
                Palestrante = "Victor Cavalcante",
                Descricao = "Nessa palestra irei abordar as principais coisas que você precisa saber para estar pronto para esse novo framework de desenvolvimento. Assista e saiba o que vai ter que aprender! "
            };

            var linha = new Palestra
            {
                Tema = "Desenvolvimento",
                Titulo = "Programador .NET, bem-vindo a linha de comando",
                Dia = "Quarta-Feira",
                Hora = "22:00",
                Palestrante = "Fernando Oliveira",
                Descricao = "As novas versões do Windows e do ASP.NET estão trazendo ou amadurecendo ferramentas que podem ser usadas através de um terminal. Nesta sessão vamos conhecer algumas dessas ferramentas e entender porque elas são tão populares em outras plataformas. "
            };

            ITEMS.Add(performance);
            ITEMS.Add(xamarin);
            ITEMS.Add(asp);
            ITEMS.Add(linha);
        }

        private static void Quinta()
        {
            var performance = new Palestra
            {
                Tema = "Cloud Computing",
                Titulo = "Docker no Azure",
                Dia = "Quinta-Feira",
                Hora = "19:00",
                Palestrante = "Wilson Tayar",
                Descricao = "Docker no Azure, conheça esta tecnologia de containers e veja como trabalhar com ela utilizando o Azure"
            };

            var azure = new Palestra
            {
                Tema = "Cloud Computing",
                Titulo = "O que há de novo para desenvolvedores de Microsoft Azure no Visual Studio 2013 e Azure SDK 2.5",
                Dia = "Quinta-Feira",
                Hora = "20:00",
                Palestrante = "Evilazaro Alves",
                Descricao = "Microsoft Visual Studio 2013 fornece as melhores ferramentas para construir e diagnosticar aplicações de nuvem que são executados no Microsoft Azure. Nesta sessão, veremos as mais recentes ferramentas para desenvolvedores dentro Visual Studio 2013 e o Microsoft Azure SDK 2.5. Será apresentado uma visão geral das ferramentas que ajudam você acelerar a criação de aplicativos que serão hospedados no Microsoft Azure WebSites, Virtual Machines, Cloud Services e Mobile Services."
            };

            var ad = new Palestra
            {
                Tema = "Cloud Computing",
                Titulo = "Azure Active Directory (Azure AD) o que é possível fazer com ele?",
                Dia = "Quinta-Feira",
                Hora = "21:00",
                Palestrante = "Lucas Romao",
                Descricao = "Neste hangout iremos discutr e desmistificar o que é o Azure Active Directory, você aprenderá o que é possível fazer com ele, o como implementar e os principais cenários onde é utilizado. "
            };

            ITEMS.Add(performance);
            ITEMS.Add(azure);
            ITEMS.Add(ad);
        }

        private static void Sexta()
        {
            var performance = new Palestra
            {
                Tema = "Fora da Caixa",
                Titulo = "NGINX, Memcached, Redis e RabbitMQ",
                Dia = "Sexta-Feira",
                Hora = "19:00",
                Palestrante = "Rodolfo Fadino e Alexandre Tarifa",
                Descricao = "Nessa apresentação vamos mostrar algumas tecnologias que utilizamos no Portal Minha Vida, conheça quais são os ganhos e quais são nossas apostas para entregar da melhor maneira possível conteúdos para cerca de 80% da população da internet brasileira no ano."
            };

            var azure = new Palestra
            {
                Tema = "Fora da Caixa",
                Titulo = "Azure Machine Learning - AzureML",
                Dia = "Sexta-Feira",
                Hora = "20:00",
                Palestrante = "Thiago Zavaschi",
                Descricao = "Nessa sessão vamos ver o que é aprendizagem de máquina e a função de um cientista de dados, em que cenários se aplica. Vamos aprender como utilizar a plataforma de aprendizagem de máquina na nuvem da Microsoft (AzureML) e criaremos um modelo completo para verificar o seu funcionamento."
            };

            var c = new Palestra
            {
                Tema = "Fora da Caixa",
                Titulo = "C# 6",
                Dia = "Sexta-Feira",
                Hora = "21:00",
                Palestrante = "Carlos dos Santos",
                Descricao = ":)"
            };

            ITEMS.Add(performance);
            ITEMS.Add(azure);
            ITEMS.Add(c);
        }
    }
}