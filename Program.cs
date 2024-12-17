using System;
using System.Collections.Generic;
using System.Linq;

namespace TravelTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var cities = new List<City>
{
    new City("Москва", "Россия", new List<string> { "Бефстроганов (говядина, сметана, лук, грибы)", "Щи (капуста, мясо, картофель, морковь)" }, new List<string> { "Красная площадь", "ГУМ" }),
    new City("Санкт-Петербург", "Россия", new List<string> { "Пышки (мука, яйца, молоко, сахар)", "Борщ (свекла, мясо, капуста, картофель)" }, new List<string> { "Эрмитаж", "Дворцовая площадь" }),
    new City("Казань", "Россия", new List<string> { "Эчпочмак (мясо, картофель, лук, тесто)", "Кумыс (кобылье молоко)" }, new List<string> { "Казанский кремль", "Кул-Шариф" }),
    new City("Новосибирск", "Россия", new List<string> { "Пельмени (мясо, тесто)", "Морс (ягоды, вода, сахар)" }, new List<string> { "Оперный театр", "Центральный парк" }),
    new City("Екатеринбург", "Россия", new List<string> { "Уральские пирожки (мясо, тесто)", "Квас (хлеб, вода, сахар)" }, new List<string> { "Храм-на-Крови", "Плотинка" }),
    new City("Сочи", "Россия", new List<string> { "Шашлык (мясо, специи, лук)", "Чай (чайные листья, вода)" }, new List<string> { "Роза Хутор", "Олимпийский парк" }),
    new City("Владивосток", "Россия", new List<string> { "Крабы (крабы, специи)", "Водка (зерно, вода)" }, new List<string> { "Русский мост", "Корабельная набережная" }),
    new City("Минск", "Беларусь", new List<string> { "Драники (картофель, яйцо, мука)", "Квас (хлеб, вода, сахар)" }, new List<string> { "Троицкое предместье", "Национальная библиотека" }),
    new City("Брест", "Беларусь", new List<string> { "Солянка (мясо, овощи, специи)", "Медовуха (мед, вода, дрожжи)" }, new List<string> { "Брестская крепость", "Улица Советская" }),
    new City("Гродно", "Беларусь", new List<string> { "Мачанка (мясо, тесто, соус)", "Кисель (ягоды, крахмал, сахар)" }, new List<string> { "Фарный костел", "Замковая гора" }),
    new City("Витебск", "Беларусь", new List<string> { "Клёцки (картофель, мука, яйца)", "Кефир (молоко, закваска)" }, new List<string> { "Усадьба Репина", "Музей Марка Шагала" }),
    new City("Гомель", "Беларусь", new List<string> { "Печеня (мясо, картофель, овощи)", "Компот (фрукты, вода, сахар)" }, new List<string> { "Дворцово-парковый ансамбль", "Ратуша" }),
    new City("Могилёв", "Беларусь", new List<string> { "Торт Наполеон (мука, масло, крем)", "Чай (чайные листья, вода)" }, new List<string> { "Площадь Звезды", "Печерский лесопарк" }),
    new City("Полоцк", "Беларусь", new List<string> { "Кислые щи (капуста, мясо, картофель)", "Морс (ягоды, вода, сахар)" }, new List<string> { "Софийский собор", "Борисов камень" }),
    new City("Торонто", "Канада", new List<string> { "Путин (картофель, сыр, мясо)", "Кленовый сироп (кленовый сок)" }, new List<string> { "CN Tower", "Ripley's Aquarium" }),
    new City("Монреаль", "Канада", new List<string> { "Смокт мясо (мясо, специи)", "Багель (мука, вода, сахар)" }, new List<string> { "Старый Монреаль", "Базилика Нотр-Дам" }),
    new City("Ванкувер", "Канада", new List<string> { "Лосось (лосось, специи)", "Эгг-ног (яйца, молоко, сахар)" }, new List<string> { "Stanley Park", "Гастон" }),
    new City("Квебек", "Канада", new List<string> { "Туртиер (мясо, специи, тесто)", "Кленовый чай (кленовый сироп, чай)" }, new List<string> { "Château Frontenac", "Старый город" }),
    new City("Калгари", "Канада", new List<string> { "Стейк (мясо)", "Кофе (кофейные зерна, вода)" }, new List<string> { "Калгари Стампид", "Башня Калгари" }),
    new City("Оттава", "Канада", new List<string> { "Бобовый суп (бобы, овощи, специи)", "Эгг-ног (яйца, молоко, сахар)" }, new List<string> { "Parliament Hill", "Rideau Canal" }),
    new City("Виннипег", "Канада", new List<string> { "Баннок (мука, вода, соль)", "Мед (мед)" }, new List<string> { "The Forks", "Assiniboine Park" }),
    new City("Пекин", "Китай", new List<string> { "Утка по-пекински (утка, специи)", "Зеленый чай (чайные листья, вода)" }, new List<string> { "Великая Китайская стена", "Запретный город" }),
    new City("Шанхай", "Китай", new List<string> { "Димсам (тесто, мясо, овощи)", "Чай Улун (чайные листья, вода)" }, new List<string> { "Шанхайская башня", "Набережная Вайтань" }),
    new City("Гуанчжоу", "Китай", new List<string> { "Димсам (тесто, мясо, овощи)", "Суп с лапшой (лапша, бульон, овощи)" }, new List<string> { "Кантонская башня", "Храм шести баньяновых деревьев" }),
    new City("Чэнду", "Китай", new List<string> { "Хот-пот (мясо, овощи, бульон)", "Чай пуэр (чайные листья, вода)" }, new List<string> { "Центр гигантских панд", "Храм Ухоу" }),
    new City("Сиань", "Китай", new List<string> { "Бараньи шашлыки (баранина, специи)", "Чай (чайные листья, вода)" }, new List<string> { "Терракотовая армия", "Старый город" }),
    new City("Ханчжоу", "Китай", new List<string> { "Курица с лонганом (курица, лонган)", "Чай Драконов колодец (чайные листья, вода)" }, new List<string> { "Западное озеро", "Храм Линьинь" }),
    new City("Гонконг", "Китай", new List<string> { "Дан-Тат (тесто, яйца, сахар)", "Молочный чай (чайные листья, молоко)" }, new List<string> { "Пик Виктории", "Алея звезд" }),
    new City("Алматы", "Казахстан", new List<string> { "Бешбармак (мясо, лапша, лук)", "Кумыс (кобылье молоко)" }, new List<string> { "Медео", "Кок-Тобе" }),
    new City("Астана", "Казахстан", new List<string> { "Куырдак (мясо, картофель, лук)", "Айран (молоко, закваска)" }, new List<string> { "Байтерек", "Дворец мира и согласия" }),
    new City("Шымкент", "Казахстан", new List<string> { "Плов (рис, мясо, специи)", "Шубат (кобылье молоко)" }, new List<string> { "Кокжайлау", "Этноаул" }),
    new City("Караганда", "Казахстан", new List<string> { "Манты (мясо, тесто)", "Чай (чайные листья, вода)" }, new List<string> { "Парк культуры", "Музей КарЛАГ" }),
    new City("Тараз", "Казахстан", new List<string> { "Казы (мясо, специи)", "Кумыс (кобылье молоко)" }, new List<string> { "Мавзолей Айша-биби", "Крепость Тараз" }),
    new City("Уральск", "Казахстан", new List<string> { "Лагман (лапша, мясо, овощи)", "Компот (фрукты, вода, сахар)" }, new List<string> { "Исторический музей", "Набережная Урала" }),
    new City("Павлодар", "Казахстан", new List<string> { "Шашлык (мясо, специи)", "Морс (ягоды, вода, сахар)" }, new List<string> { "Мечеть Машхур Жусупа", "Парк Металлургов" }),
};


            var routes = new List<Route>
            {
            new Route("Москва", "Санкт-Петербург", "Поезд", new List<string>()),
            new Route("Москва", "Казань", "Самолёт", new List<string>()),
            new Route("Москва", "Новосибирск", "Самолёт", new List<string>()),
            new Route("Москва", "Екатеринбург", "Самолёт", new List<string>()),
            new Route("Москва", "Сочи", "Самолёт", new List<string>()),
            new Route("Москва", "Владивосток", "Самолёт", new List<string> { "Новосибирск" }),

            new Route("Санкт-Петербург", "Москва", "Поезд", new List<string>()),
            new Route("Санкт-Петербург", "Екатеринбург", "Самолёт", new List<string>()),
            new Route("Санкт-Петербург", "Казань", "Самолёт", new List<string> { "Москва" }),
            new Route("Санкт-Петербург", "Новосибирск", "Самолёт", new List<string> { "Москва" }),
            new Route("Санкт-Петербург", "Владивосток", "Самолёт", new List<string> { "Новосибирск" }),
            new Route("Санкт-Петербург", "Сочи", "Самолёт", new List<string> { "Москва" }),

            new Route("Казань", "Москва", "Самолёт", new List<string>()),
            new Route("Казань", "Санкт-Петербург", "Самолёт", new List<string> { "Москва" }),
            new Route("Казань", "Екатеринбург", "Самолёт", new List<string>()),
            new Route("Казань", "Новосибирск", "Самолёт", new List<string>()),
            new Route("Казань", "Владивосток", "Самолёт", new List<string> { "Новосибирск" }),
            new Route("Казань", "Сочи", "Самолёт", new List<string> { "Москва" }),

            new Route("Новосибирск", "Москва", "Самолёт", new List<string>()),
            new Route("Новосибирск", "Санкт-Петербург", "Самолёт", new List<string> { "Москва" }),
            new Route("Новосибирск", "Казань", "Самолёт", new List<string>()),
            new Route("Новосибирск", "Екатеринбург", "Самолёт", new List<string>()),
            new Route("Новосибирск", "Владивосток", "Самолёт", new List<string>()),
            new Route("Новосибирск", "Сочи", "Самолёт", new List<string> { "Москва" }),

            new Route("Екатеринбург", "Москва", "Самолёт", new List<string>()),
            new Route("Екатеринбург", "Санкт-Петербург", "Самолёт", new List<string>()),
            new Route("Екатеринбург", "Казань", "Самолёт", new List<string>()),
            new Route("Екатеринбург", "Новосибирск", "Самолёт", new List<string>()),
            new Route("Екатеринбург", "Владивосток", "Самолёт", new List<string> { "Новосибирск" }),
            new Route("Екатеринбург", "Сочи", "Самолёт", new List<string> { "Москва" }),

            new Route("Владивосток", "Москва", "Самолёт", new List<string> { "Новосибирск" }),
            new Route("Владивосток", "Санкт-Петербург", "Самолёт", new List<string> { "Новосибирск", "Москва" }),
            new Route("Владивосток", "Казань", "Самолёт", new List<string> { "Новосибирск" }),
            new Route("Владивосток", "Новосибирск", "Самолёт", new List<string>()),
            new Route("Владивосток", "Екатеринбург", "Самолёт", new List<string> { "Новосибирск" }),
            new Route("Владивосток", "Сочи", "Самолёт", new List<string> { "Новосибирск", "Москва" }),

            new Route("Сочи", "Москва", "Самолёт", new List<string>()),
            new Route("Сочи", "Санкт-Петербург", "Самолёт", new List<string> { "Москва" }),
            new Route("Сочи", "Казань", "Самолёт", new List<string> { "Москва" }),
            new Route("Сочи", "Новосибирск", "Самолёт", new List<string> { "Москва" }),
            new Route("Сочи", "Екатеринбург", "Самолёт", new List<string> { "Москва" }),
            new Route("Сочи", "Владивосток", "Самолёт", new List<string> { "Новосибирск", "Москва" }),

            new Route("Минск", "Брест", "Поезд", new List<string>()),
            new Route("Минск", "Гродно", "Поезд", new List<string>()),
            new Route("Минск", "Витебск", "Поезд", new List<string>()),
            new Route("Минск", "Гомель", "Поезд", new List<string>()),
            new Route("Минск", "Могилёв", "Поезд", new List<string>()),
            new Route("Минск", "Полоцк", "Поезд", new List<string> { "Витебск" }),

            new Route("Брест", "Минск", "Поезд", new List<string>()),
            new Route("Брест", "Гродно", "Поезд", new List<string>()),
            new Route("Брест", "Витебск", "Поезд", new List<string> { "Минск" }),
            new Route("Брест", "Гомель", "Поезд", new List<string> { "Минск" }),
            new Route("Брест", "Могилёв", "Поезд", new List<string> { "Минск" }),
            new Route("Брест", "Полоцк", "Поезд", new List<string> { "Минск", "Витебск" }),

            new Route("Гродно", "Минск", "Поезд", new List<string>()),
            new Route("Гродно", "Брест", "Поезд", new List<string>()),
            new Route("Гродно", "Витебск", "Поезд", new List<string> { "Минск" }),
            new Route("Гродно", "Гомель", "Поезд", new List<string> { "Минск" }),
            new Route("Гродно", "Могилёв", "Поезд", new List<string> { "Минск" }),
            new Route("Гродно", "Полоцк", "Поезд", new List<string> { "Минск", "Витебск" }),

            new Route("Витебск", "Минск", "Поезд", new List<string>()),
            new Route("Витебск", "Брест", "Поезд", new List<string> { "Минск" }),
            new Route("Витебск", "Гродно", "Поезд", new List<string> { "Минск" }),
            new Route("Витебск", "Гомель", "Поезд", new List<string> { "Минск" }),
            new Route("Витебск", "Могилёв", "Поезд", new List<string>()),
            new Route("Витебск", "Полоцк", "Поезд", new List<string>()),

            new Route("Гомель", "Минск", "Поезд", new List<string>()),
            new Route("Гомель", "Брест", "Поезд", new List<string> { "Минск" }),
            new Route("Гомель", "Гродно", "Поезд", new List<string> { "Минск" }),
            new Route("Гомель", "Витебск", "Поезд", new List<string> { "Минск" }),
            new Route("Гомель", "Могилёв", "Поезд", new List<string>()),
            new Route("Гомель", "Полоцк", "Поезд", new List<string> { "Минск", "Витебск" }),

            new Route("Могилёв", "Минск", "Поезд", new List<string>()),
            new Route("Могилёв", "Брест", "Поезд", new List<string> { "Минск" }),
            new Route("Могилёв", "Гродно", "Поезд", new List<string> { "Минск" }),
            new Route("Могилёв", "Витебск", "Поезд", new List<string>()),
            new Route("Могилёв", "Гомель", "Поезд", new List<string>()),
            new Route("Могилёв", "Полоцк", "Поезд", new List<string> { "Витебск" }),

            new Route("Полоцк", "Минск", "Поезд", new List<string> { "Витебск" }),
            new Route("Полоцк", "Брест", "Поезд", new List<string> { "Витебск", "Минск" }),
            new Route("Полоцк", "Гродно", "Поезд", new List<string> { "Витебск", "Минск" }),
            new Route("Полоцк", "Витебск", "Поезд", new List<string>()),
            new Route("Полоцк", "Гомель", "Поезд", new List<string> { "Витебск", "Минск" }),
            new Route("Полоцк", "Могилёв", "Поезд", new List<string> { "Витебск" }),

            new Route("Торонто", "Монреаль", "Самолёт", new List<string>()),
            new Route("Торонто", "Ванкувер", "Самолёт", new List<string>()),
            new Route("Торонто", "Квебек", "Самолёт", new List<string>()),
            new Route("Торонто", "Калгари", "Самолёт", new List<string>()),
            new Route("Торонто", "Оттава", "Самолёт", new List<string>()),
            new Route("Торонто", "Виннипег", "Самолёт", new List<string> { "Калгари" }),

            new Route("Монреаль", "Торонто", "Самолёт", new List<string>()),
            new Route("Монреаль", "Квебек", "Самолёт", new List<string>()),
            new Route("Монреаль", "Ванкувер", "Самолёт", new List<string> { "Торонто" }),
            new Route("Монреаль", "Калгари", "Самолёт", new List<string> { "Торонто" }),
            new Route("Монреаль", "Оттава", "Самолёт", new List<string>()),
            new Route("Монреаль", "Виннипег", "Самолёт", new List<string> { "Калгари" }),

            new Route("Ванкувер", "Торонто", "Самолёт", new List<string>()),
            new Route("Ванкувер", "Монреаль", "Самолёт", new List<string> { "Торонто" }),
            new Route("Ванкувер", "Квебек", "Самолёт", new List<string> { "Торонто" }),
            new Route("Ванкувер", "Калгари", "Самолёт", new List<string>()),
            new Route("Ванкувер", "Оттава", "Самолёт", new List<string> { "Торонто" }),
            new Route("Ванкувер", "Виннипег", "Самолёт", new List<string> { "Калгари" }),

            new Route("Калгари", "Торонто", "Самолёт", new List<string>()),
            new Route("Калгари", "Монреаль", "Самолёт", new List<string> { "Торонто" }),
            new Route("Калгари", "Ванкувер", "Самолёт", new List<string>()),
            new Route("Калгари", "Квебек", "Самолёт", new List<string> { "Торонто" }),
            new Route("Калгари", "Оттава", "Самолёт", new List<string> { "Торонто" }),
            new Route("Калгари", "Виннипег", "Самолёт", new List<string>()),

            new Route("Квебек", "Торонто", "Самолёт", new List<string>()),
            new Route("Квебек", "Монреаль", "Самолёт", new List<string>()),
            new Route("Квебек", "Ванкувер", "Самолёт", new List<string> { "Торонто" }),
            new Route("Квебек", "Калгари", "Самолёт", new List<string> { "Торонто" }),
            new Route("Квебек", "Оттава", "Самолёт", new List<string> { "Торонто" }),
            new Route("Квебек", "Виннипег", "Самолёт", new List<string> { "Калгари" }),

            new Route("Оттава", "Торонто", "Самолёт", new List<string>()),
            new Route("Оттава", "Монреаль", "Самолёт", new List<string>()),
            new Route("Оттава", "Ванкувер", "Самолёт", new List<string> { "Торонто" }),
            new Route("Оттава", "Калгари", "Самолёт", new List<string> { "Торонто" }),
            new Route("Оттава", "Квебек", "Самолёт", new List<string>()),
            new Route("Оттава", "Виннипег", "Самолёт", new List<string> { "Калгари" }),

            new Route("Виннипег", "Торонто", "Самолёт", new List<string> { "Калгари" }),
            new Route("Виннипег", "Монреаль", "Самолёт", new List<string> { "Калгари" }),
            new Route("Виннипег", "Ванкувер", "Самолёт", new List<string> { "Калгари" }),
            new Route("Виннипег", "Калгари", "Самолёт", new List<string>()),
            new Route("Виннипег", "Квебек", "Самолёт", new List<string> { "Калгари" }),
            new Route("Виннипег", "Оттава", "Самолёт", new List<string> { "Калгари" }),

             new Route("Пекин", "Шанхай", "Самолёт", new List<string>()),
            new Route("Пекин", "Гуанчжоу", "Самолёт", new List<string>()),
            new Route("Пекин", "Чэнду", "Самолёт", new List<string>()),
            new Route("Пекин", "Сиань", "Самолёт", new List<string>()),
            new Route("Пекин", "Ханчжоу", "Самолёт", new List<string>()),
            new Route("Пекин", "Гонконг", "Самолёт", new List<string> { "Шанхай" }),

            new Route("Шанхай", "Пекин", "Самолёт", new List<string>()),
            new Route("Шанхай", "Гуанчжоу", "Самолёт", new List<string>()),
            new Route("Шанхай", "Чэнду", "Самолёт", new List<string>()),
            new Route("Шанхай", "Сиань", "Самолёт", new List<string>()),
            new Route("Шанхай", "Ханчжоу", "Самолёт", new List<string>()),
            new Route("Шанхай", "Гонконг", "Самолёт", new List<string>()),

            new Route("Гуанчжоу", "Пекин", "Самолёт", new List<string>()),
            new Route("Гуанчжоу", "Шанхай", "Самолёт", new List<string>()),
            new Route("Гуанчжоу", "Чэнду", "Самолёт", new List<string>()),
            new Route("Гуанчжоу", "Сиань", "Самолёт", new List<string>()),
            new Route("Гуанчжоу", "Ханчжоу", "Самолёт", new List<string>()),
            new Route("Гуанчжоу", "Гонконг", "Самолёт", new List<string>()),

            new Route("Чэнду", "Пекин", "Самолёт", new List<string>()),
            new Route("Чэнду", "Шанхай", "Самолёт", new List<string>()),
            new Route("Чэнду", "Гуанчжоу", "Самолёт", new List<string>()),
            new Route("Чэнду", "Сиань", "Самолёт", new List<string>()),
            new Route("Чэнду", "Ханчжоу", "Самолёт", new List<string>()),
            new Route("Чэнду", "Гонконг", "Самолёт", new List<string> { "Шанхай" }),

            new Route("Сиань", "Пекин", "Самолёт", new List<string>()),
            new Route("Сиань", "Шанхай", "Самолёт", new List<string>()),
            new Route("Сиань", "Гуанчжоу", "Самолёт", new List<string>()),
            new Route("Сиань", "Чэнду", "Самолёт", new List<string>()),
            new Route("Сиань", "Ханчжоу", "Самолёт", new List<string>()),
            new Route("Сиань", "Гонконг", "Самолёт", new List<string> { "Шанхай" }),

            new Route("Ханчжоу", "Пекин", "Самолёт", new List<string>()),
            new Route("Ханчжоу", "Шанхай", "Самолёт", new List<string>()),
            new Route("Ханчжоу", "Гуанчжоу", "Самолёт", new List<string>()),
            new Route("Ханчжоу", "Чэнду", "Самолёт", new List<string>()),
            new Route("Ханчжоу", "Сиань", "Самолёт", new List<string>()),
            new Route("Ханчжоу", "Гонконг", "Самолёт", new List<string>()),

            new Route("Гонконг", "Пекин", "Самолёт", new List<string> { "Шанхай" }),
            new Route("Гонконг", "Шанхай", "Самолёт", new List<string>()),
            new Route("Гонконг", "Гуанчжоу", "Самолёт", new List<string>()),
            new Route("Гонконг", "Чэнду", "Самолёт", new List<string> { "Шанхай" }),
            new Route("Гонконг", "Сиань", "Самолёт", new List<string> { "Шанхай" }),
            new Route("Гонконг", "Ханчжоу", "Самолёт", new List<string> { "Шанхай" }),

             new Route("Алматы", "Астана", "Поезд", new List<string>()),
            new Route("Алматы", "Шымкент", "Поезд", new List<string>()),
            new Route("Алматы", "Караганда", "Самолёт", new List<string>()),
            new Route("Алматы", "Тараз", "Поезд", new List<string>()),
            new Route("Алматы", "Уральск", "Самолёт", new List<string>()),
            new Route("Алматы", "Павлодар", "Самолёт", new List<string>()),

            new Route("Астана", "Алматы", "Поезд", new List<string>()),
            new Route("Астана", "Шымкент", "Самолёт", new List<string>()),
            new Route("Астана", "Караганда", "Поезд", new List<string>()),
            new Route("Астана", "Тараз", "Самолёт", new List<string> { "Алматы" }),
            new Route("Астана", "Уральск", "Самолёт", new List<string>()),
            new Route("Астана", "Павлодар", "Поезд", new List<string>()),

            new Route("Шымкент", "Алматы", "Поезд", new List<string>()),
            new Route("Шымкент", "Астана", "Самолёт", new List<string>()),
            new Route("Шымкент", "Караганда", "Самолёт", new List<string>()),
            new Route("Шымкент", "Тараз", "Поезд", new List<string>()),
            new Route("Шымкент", "Уральск", "Самолёт", new List<string> { "Алматы" }),
            new Route("Шымкент", "Павлодар", "Самолёт", new List<string> { "Алматы" }),

            new Route("Караганда", "Алматы", "Самолёт", new List<string>()),
            new Route("Караганда", "Астана", "Поезд", new List<string>()),
            new Route("Караганда", "Шымкент", "Самолёт", new List<string>()),
            new Route("Караганда", "Тараз", "Самолёт", new List<string> { "Алматы" }),
            new Route("Караганда", "Уральск", "Самолёт", new List<string>()),
            new Route("Караганда", "Павлодар", "Самолёт", new List<string>()),

            new Route("Тараз", "Алматы", "Поезд", new List<string>()),
            new Route("Тараз", "Астана", "Самолёт", new List<string> { "Алматы" }),
            new Route("Тараз", "Шымкент", "Поезд", new List<string>()),
            new Route("Тараз", "Караганда", "Самолёт", new List<string> { "Алматы" }),
            new Route("Тараз", "Уральск", "Самолёт", new List<string> { "Алматы" }),
            new Route("Тараз", "Павлодар", "Самолёт", new List<string> { "Алматы" }),

            new Route("Уральск", "Алматы", "Самолёт", new List<string>()),
            new Route("Уральск", "Астана", "Самолёт", new List<string>()),
            new Route("Уральск", "Шымкент", "Самолёт", new List<string> { "Алматы" }),
            new Route("Уральск", "Караганда", "Самолёт", new List<string>()),
            new Route("Уральск", "Тараз", "Самолёт", new List<string> { "Алматы" }),
            new Route("Уральск", "Павлодар", "Самолёт", new List<string>()),

            new Route("Павлодар", "Алматы", "Самолёт", new List<string>()),
            new Route("Павлодар", "Астана", "Поезд", new List<string>()),
            new Route("Павлодар", "Шымкент", "Самолёт", new List<string> { "Алматы" }),
            new Route("Павлодар", "Караганда", "Самолёт", new List<string>()),
            new Route("Павлодар", "Тараз", "Самолёт", new List<string> { "Алматы" }),
            new Route("Павлодар", "Уральск", "Самолёт", new List<string>()),


            new Route("Москва", "Минск", "Самолёт", new List<string>()),
            new Route("Минск", "Москва", "Самолёт", new List<string>()),

            new Route("Москва", "Астана", "Самолёт", new List<string>()),
            new Route("Астана", "Москва", "Самолёт", new List<string>()),


            new Route("Москва", "Торонто", "Самолёт", new List<string>()),
            new Route("Торонто", "Москва", "Самолёт", new List<string>()),

            new Route("Москва", "Пекин", "Самолёт", new List<string>()),
            new Route("Пекин", "Москва", "Самолёт", new List<string>()),

            new Route("Минск", "Астана", "Самолёт", new List<string> { "Москва" }),
            new Route("Астана", "Минск", "Самолёт", new List<string> { "Москва" }),

            new Route("Минск", "Торонто", "Самолёт", new List<string> { "Москва" }),
            new Route("Торонто", "Минск", "Самолёт", new List<string> { "Москва" }),

            new Route("Минск", "Пекин", "Самолёт", new List<string> { "Москва" }),
            new Route("Пекин", "Минск", "Самолёт", new List<string> { "Москва" }),

            new Route("Астана", "Торонто", "Самолёт", new List<string> { "Москва" }),
            new Route("Торонто", "Астана", "Самолёт", new List<string> { "Москва" }),

            new Route("Астана", "Пекин", "Самолёт", new List<string>()),
            new Route("Пекин", "Астана", "Самолёт", new List<string>()),

            new Route("Торонто", "Пекин", "Самолёт", new List<string>()),
            new Route("Пекин", "Торонто", "Самолёт", new List<string>())
            };

            Console.WriteLine("Добро пожаловать в систему поиска маршрутов!");
            Console.Write("Введите город отправления: ");
            string departure = Console.ReadLine().Trim() ?? "";

            Console.Write("Введите город назначения: ");
            string destination = Console.ReadLine().Trim() ?? "";

            if (string.IsNullOrWhiteSpace(departure) || string.IsNullOrWhiteSpace(destination))
            {
                Console.WriteLine("Ошибка: Необходимо ввести оба города!");
                return;
            }

            var routeList = FindRouteWithConnections(routes, departure, destination, new HashSet<string>());
            if (routeList.Any())
            {
                Console.WriteLine("\nВаш маршрут:");
                foreach (var r in routeList)
                {
                    Console.WriteLine($" - {r.Transport} из {r.From} в {r.To}");
                }

                var destinationCity = cities.FirstOrDefault(c => c.Name.Equals(destination, StringComparison.OrdinalIgnoreCase));
                if (destinationCity != null)
                {
                    Console.WriteLine($"Места: {string.Join(", ", destinationCity.Places)}.");
                    Console.WriteLine($"Попробуйте: {string.Join(", ", destinationCity.Food)}.");
                }
            }
            else
            {
                Console.WriteLine("\nМаршрут не найден.");
            }

        }



        private static List<Route> FindRouteWithConnections(List<Route> routes, string from, string to, HashSet<string> visited, int maxConnections = 3)
        {
            if (from.Equals(to, StringComparison.OrdinalIgnoreCase))
                return new List<Route>();

            visited.Add(from);

            var directRoute = routes.FirstOrDefault(r => r.From.Equals(from, StringComparison.OrdinalIgnoreCase) && r.To.Equals(to, StringComparison.OrdinalIgnoreCase));
            if (directRoute != null)
            {
                return new List<Route> { directRoute };
            }

            if (maxConnections > 0)
            {
                foreach (var route in routes.Where(r => r.From.Equals(from, StringComparison.OrdinalIgnoreCase) && !visited.Contains(r.To)))
                {
                    var nextRoutes = FindRouteWithConnections(routes, route.To, to, new HashSet<string>(visited), maxConnections - 1);
                    if (nextRoutes.Any())
                    {
                        return new List<Route> { route }.Concat(nextRoutes).ToList();
                    }
                }
            }

            return new List<Route>();
        }
    }

    public class City
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public List<string> Food { get; set; }
        public List<string> Places { get; set; }

        public City(string name, string country, List<string> food, List<string> places)
        {
            Name = name;
            Country = country;
            Food = food;
            Places = places;
        }
    }

    public class Route
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Transport { get; set; }
        public List<string> Connections { get; set; }

        public Route(string from, string to, string transport, List<string> connections)
        {
            From = from;
            To = to;
            Transport = transport;
            Connections = connections;
        }
    }
}