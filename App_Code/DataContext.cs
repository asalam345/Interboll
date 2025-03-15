using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class DataContext
{
    public List<string> GetPlatForm()
    {
        List<string> list = new List<string>();
        list.Add("Interboll");
        list.Add("Android");
        list.Add("IOS");
        return list;
    }

    public List<Category> GetGameCategory()
    {
        List<Category> list = new List<Category>();
        list.Add(new Category { catId = 1, catName = "Casual" });
        list.Add(new Category { catId = 2, catName = "Battle" });
        list.Add(new Category { catId = 3, catName = "Casino" });
        return list;
    }

    public List<Type> GetGameType()
    {
        List<Type> list = new List<Type>();
        list.Add(new Type { typeId = 1, typeName = "Puzzle", catId = 1 });
        list.Add(new Type { typeId = 2, typeName = "Board", catId = 1 });
        list.Add(new Type { typeId = 3, typeName = "Simulation", catId = 1 });
        list.Add(new Type { typeId = 4, typeName = "Match 3", catId = 1 });
        list.Add(new Type { typeId = 5, typeName = "Runner", catId = 1 });
        list.Add(new Type { typeId = 6, typeName = "Card", catId = 1 });
        list.Add(new Type { typeId = 7, typeName = "Builder", catId = 1 });
        list.Add(new Type { typeId = 8, typeName = "Trivia & Word", catId = 1 });
        list.Add(new Type { typeId = 9, typeName = "Action", catId = 2 });
        list.Add(new Type { typeId = 10, typeName = "Role Playing", catId = 2 });
        list.Add(new Type { typeId = 11, typeName = "Strategy", catId = 2 });
        list.Add(new Type { typeId = 12, typeName = "Card Battle", catId = 2 });
        list.Add(new Type { typeId = 13, typeName = "Sports", catId = 2 });
        list.Add(new Type { typeId = 14, typeName = "MOBA", catId = 2 });
        list.Add(new Type { typeId = 15, typeName = "Slots", catId = 3 });
        list.Add(new Type { typeId = 16, typeName = "Poker & Table", catId = 3 });
        list.Add(new Type { typeId = 17, typeName = "Bingo", catId = 3 });
        return list;
    }

    public List<string> GetPriceType()
    {
        List<string> list = new List<string>();
        list.Add("Free");
        list.Add("Not Free");
        return list;
    }

    public List<string> GetDefaultCurrency()
    {
        List<string> list = new List<string>();
        list.Add("BDT ৳");
        list.Add("USD $");
        return list;
    }

    public List<Status> GetGameStatus()
    {
        List<Status> list = new List<Status>();
        list.Add(new Status { s_id = 0, s_name = "Present Game" });
        list.Add(new Status { s_id = 1, s_name = "Comming Soon" });
        return list;
    }

    public List<string> GetPageName()
    {
        List<string> list = new List<string>();
        list.Add("Home");
        list.Add("Tour Destination");
        list.Add("Tour Operator");
        list.Add("Tour Quality");
        list.Add("Tour Style");
        list.Add("Tour Categories");
        list.Add("Tour Spots");
        list.Add("Hotel");
        list.Add("Transportation");
        list.Add("Host");
        list.Add("More");
        list.Add("Details");
        list.Add("Help");
        list.Add("Assist");
        return list;
    }

    public List<EmptyImagePath> GetEmptyImagePath()
    {
        List<EmptyImagePath> list = new List<EmptyImagePath>();
        list.Add(new EmptyImagePath { s_image = "Images/upload/blank_image.jpg", s_url="#" });
        list.Add(new EmptyImagePath { s_image = "Images/upload/blank_image.jpg", s_url="#" });
        list.Add(new EmptyImagePath { s_image = "Images/upload/blank_image.jpg", s_url="#" });
        return list;
    }

}

public class Category
{
    public int catId { get; set; }
    public string catName { get; set; }
}

public class Status
{
    public int s_id { get; set; }
    public string s_name { get; set; }
}

public class Type
{
    public int typeId { get; set; }
    public string typeName { get; set; }
    public int catId { get; set; }
}

public class EmptyImagePath
{
	public string s_image { get; set; }
    public string s_url { get; set; }
}