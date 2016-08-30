namespace FC_Manage_Salary_WIzard.Object_Layer.Crafts_layer {
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;


  /// <summary>Класс описывает должность</summary>
  class Craft {
    private string name;
    private bool productivity;
    internal List<Day_Yong>         MyDayYong;
    internal List<Hour_In_Day>      MyHourInDay;
    internal List<Ill_Day_Price>    MyIllDayPrice;
    internal List<Night_Hour_Price> MyNightHourPrice;
    internal List<Price_Hour>       MyPriceHour;


    public Craft(string crftname, bool prdct) {
      Name             = crftname;
      Productivity     = prdct;
      MyDayYong        = new List<Day_Yong>();
      MyHourInDay      = new List<Hour_In_Day>();
      MyIllDayPrice    = new List<Ill_Day_Price>();
      MyNightHourPrice = new List<Night_Hour_Price>();
      MyPriceHour      = new List<Price_Hour>();
    }
    /// <summary>Наименование должности</summary>
    public string Name
    {
      get
      {
        return name;
      }

      set
      {
        name=value;
      }
    }

    /// <summary>Признак того что должность является производительной</summary>
    public bool Productivity
    {
      get
      {
        return productivity;
      }

      set
      {
        productivity=value;
      }
    }
  }
}
