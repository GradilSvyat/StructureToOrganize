﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StructureToOrganize.Models
{
    public class Country
    {
        public Country()
        {
            Businesses = new List<Business>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Code { get; set; }
        [ForeignKey("Organization")]
        public int? OrganizationCode { get; set; }
        public Organization Organization { get; set; }
        public ICollection<Business> Businesses { get; set; }
        public static Dictionary<string,string> GetAllCountry ()
        {
            return allCountry;
        }
        private static readonly Dictionary<string, string> allCountry = new Dictionary<string, string>()
        {
            {"895","Абхазия"},
            {"036","Австралия"},
            {"040","Австрия"},
            {"031","Азербайджан"},
            {"008","Албания"},
            {"012","Алжир"},
            {"024","Ангола"},
            {"020","Андорра"},
            {"028","Антигуа и Барбуда"},
            {"032","Аргентина"},
            {"051","Армения"},
            {"004","Афганистан"},
            {"044","Багамские Острова"},
            {"050","Бангладеш"},
            {"052","Барбадос"},
            {"048","Бахрейн"},
            {"084","Белиз"},
            {"112","Белоруссия"},
            {"056","Бельгия"},
            {"204","Бенин"},
            {"100","Болгария"},
            {"068","Боливия"},
            {"070","Босния и Герцеговина"},
            {"072","Ботсвана"},
            {"076","Бразилия"},
            {"096","Бруней"},
            {"854","Буркина-Фасо"},
            {"108","Бурунди"},
            {"064","Бутан"},
            {"548","Вануату"},
            {"336","Ватикан"},
            {"826","Великобритания"},
            {"348","Венгрия"},
            {"862","Венесуэла"},
            {"626","Восточный Тимор"},
            {"704","Вьетнам"},
            {"266","Габон"},
            {"332","Гаити"},
            {"328","Гайана"},
            {"270","Гамбия"},
            {"288","Гана"},
            {"320","Гватемала"},
            {"324","Гвинея"},
            {"624","Гвинея-Бисау"},
            {"276","Германия"},
            {"340","Гондурас"},
            {"275","Государство Палестина"},
            {"308","Гренада"},
            {"300","Греция"},
            {"268","Грузия"},
            {"208","Дания"},
            {"262","Джибути"},
            {"212","Доминика"},
            {"214","Доминиканская Республика"},
            {"180","ДР Конго"},
            {"818","Египет"},
            {"894","Замбия"},
            {"716","Зимбабве"},
            {"376","Израиль"},
            {"356","Индия"},
            {"360","Индонезия"},
            {"400","Иордания"},
            {"368","Ирак"},
            {"364","Иран"},
            {"372","Ирландия"},
            {"352","Исландия"},
            {"724","Испания"},
            {"380","Италия"},
            {"887","Йемен"},
            {"132","Кабо-Верде"},
            {"398","Казахстан"},
            {"116","Камбоджа"},
            {"120","Камерун"},
            {"124","Канада"},
            {"634","Катар"},
            {"404","Кения"},
            {"196","Кипр"},
            {"417","Киргизия"},
            {"296","Кирибати"},
            {"156","Китай"},
            {"408","КНДР"},
            {"170","Колумбия"},
            {"174","Коморские Острова"},
            {"188","Коста-Рика"},
            {"384","Кот-д'Ивуар"},
            {"192","Куба"},
            {"414","Кувейт"},
            {"418","Лаос"},
            {"428","Латвия"},
            {"426","Лесото"},
            {"430","Либерия"},
            {"422","Ливан"},
            {"434","Ливия"},
            {"440","Литва"},
            {"438","Лихтенштейн"},
            {"442","Люксембург"},
            {"480","Маврикий"},
            {"478","Мавритания"},
            {"450","Мадагаскар"},
            {"454","Малави"},
            {"458","Малайзия"},
            {"466","Мали"},
            {"462","Мальдивские Острова"},
            {"470","Мальта"},
            {"504","Марокко"},
            {"584","Маршалловы Острова"},
            {"484","Мексика"},
            {"508","Мозамбик"},
            {"498","Молдавия"},
            {"492","Монако"},
            {"496","Монголия"},
            {"104","Мьянма"},
            {"516","Намибия"},
            {"520","Науру"},
            {"524","Непал"},
            {"562","Нигер"},
            {"566","Нигерия"},
            {"528","Нидерланды"},
            {"558","Никарагуа"},
            {"554","Новая Зеландия"},
            {"578","Норвегия"},
            {"784","ОАЭ"},
            {"512","Оман"},
            {"586","Пакистан"},
            {"585","Палау"},
            {"591","Панама"},
            {"598","Папуа - Новая Гвинея"},
            {"600","Парагвай"},
            {"604","Перу"},
            {"616","Польша"},
            {"620","Португалия"},
            {"178","Республика Конго"},
            {"410","Республика Корея"},
            {"643","Россия"},
            {"646","Руанда"},
            {"642","Румыния"},
            {"222","Сальвадор"},
            {"882","Самоа"},
            {"674","Сан-Марино"},
            {"678","Сан-Томе и Принсипи"},
            {"682","Саудовская Аравия"},
            {"807","Северная Македония"},
            {"690","Сейшельские Острова"},
            {"686","Сенегал"},
            {"670","Сент-Винсент и Гренадины"},
            {"659","Сент-Китс и Невис"},
            {"662","Сент-Люсия"},
            {"688","Сербия"},
            {"702","Сингапур"},
            {"760","Сирия"},
            {"703","Словакия"},
            {"705","Словения"},
            {"090","Соломоновы Острова"},
            {"706","Сомали"},
            {"729","Судан"},
            {"740","Суринам"},
            {"840","США"},
            {"694","Сьерра-Леоне"},
            {"762","Таджикистан"},
            {"764","Таиланд"},
            {"834","Танзания"},
            {"768","Того"},
            {"776","Тонга"},
            {"780","Тринидад и Тобаго"},
            {"798","Тувалу"},
            {"788","Тунис"},
            {"795","Туркмения"},
            {"792","Турция"},
            {"800","Уганда"},
            {"860","Узбекистан"},
            {"804","Украина"},
            {"858","Уругвай"},
            {"583","Федеративные Штаты Микронезии"},
            {"242","Фиджи"},
            {"608","Филиппины"},
            {"246","Финляндия"},
            {"250","Франция"},
            {"191","Хорватия"},
            {"140","ЦАР"},
            {"148","Чад"},
            {"499","Черногория"},
            {"203","Чехия"},
            {"152","Чили"},
            {"756","Швейцария"},
            {"752","Швеция"},
            {"144","Шри-Ланка"},
            {"218","Эквадор"},
            {"226","Экваториальная Гвинея"},
            {"232","Эритрея"},
            {"748","Эсватини"},
            {"233","Эстония"},
            {"231","Эфиопия"},
            {"710","ЮАР"},
            {"896","Южная Осетия"},
            {"728","Южный Судан"},
            {"388","Ямайка"},
            {"392","Япония"},
        };
    }
}
