// See https://aka.ms/new-console-template for more information

using System.Collections.Specialized;
using Alina.Models;
using Type = Alina.Enums.Type;

Section section1 = new Section();
section1.Name = "Главная";
var sectionItem = new SectionItem();
sectionItem.Name = "Ясно";
sectionItem.Type = Type.list;
sectionItem.Section = section1;

var sectionItem2 = new SectionItem();
sectionItem2.Name = "Ясно";
sectionItem2.Type = Type.list;
sectionItem2.Section = section1;

var sectionItem3 = new SectionItem();
sectionItem3.Name = "Ясно";
sectionItem3.Type = Type.list;
sectionItem3.Section = section1;

List<SectionItem> sectionItems = new List<SectionItem>();

sectionItems.Add(sectionItem);
sectionItems.Add(sectionItem2);
sectionItems.Add(sectionItem3);
foreach (var sectionItemInList in sectionItems)
{
    Console.WriteLine(sectionItemInList.Name);
    Console.WriteLine(sectionItemInList.Type);
    Console.WriteLine(sectionItemInList.Section.Name);
    Console.WriteLine("------------------------------");
}

var content = new Content();
content.Description = "Ну понятно";
// content.SectionItems = sectionItems;
content.Hyperlink = "Нажми меня, солнышко";
var heading = new Heading();
heading.Content = content;
heading.ContentHeading = "Было круто когда то";
var contentOfTable = new ContentsOfTables();
contentOfTable.Heading = heading;
contentOfTable.Content = "Это база";
var cardNews = new CardNews();
cardNews.Section = section1;
cardNews.Hyperlink = "Нажми";
cardNews.Name = "При";
cardNews.Author= "Алина";
cardNews.Date = DateTime.Now;
var news = new News();
news.CardNews = cardNews;
news.Content = "Дело";
