namespace FC_Manage_Salary_WIzard.ActionLayer {
  using System.Xml.Linq;
  using Object_Layer;
  using Object_Layer.Crafts_layer;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;


  /// <summary>Инстанс класса занимается чтением и записью данных из XML и созданием объектов</summary>
  class XML_Exchenger {
    /// <summary>чтение данных о должностях из xml</summary>
    private static void readDocument(XDocument docDocumen) {
      foreach(XElement el in docDocumen.Root.Elements()) {

      }
    }


    /// <summary>Запись данных о Должностях</summary>
    internal static void WrightCounterParty(VirtualBase myDb) {
      string fileName = Properties.Settings.Default.Path_to_Base_Directory + "\\Craft.xml";
      XDocument doc = new XDocument();
      XElement crafts = new XElement("Crafts");
      doc.Add(crafts);
      foreach(Craft crft in myDb.myCrafts) {
        XElement craft = new XElement("Craft",
        new XAttribute("Name", crft.Name),
        new XAttribute("Productivity", crft.Productivity)
         );
        foreach(Day_Yong dy in crft.MyDayYong) {
          XElement dy_el = new XElement("Day_Yong",
          new XAttribute("value", dy.Value.ToString()),
          new XAttribute("date", dy.DateAccepted.ToString())
        );
        }
        foreach(Hour_In_Day hd in crft.MyHourInDay) {
          XElement hd_el = new XElement("Hour_In_Day",
          new XAttribute("value", hd.Value.ToString()),
          new XAttribute("date", hd.DateAccepted.ToString())
        );
        }
        foreach(Ill_Day_Price ip in crft.MyIllDayPrice) {
          XElement ip_el = new XElement("Ill_Day_Price",
          new XAttribute("value", ip.Value.ToString()),
          new XAttribute("date", ip.DateAccepted.ToString())
        );
        }
        foreach(Night_Hour_Price np in crft.MyNightHourPrice) {
          XElement np_el = new XElement("Night_Hour_Price",
          new XAttribute("value", np.Value.ToString()),
          new XAttribute("date", np.DateAccepted.ToString())
        );
        }
        foreach(Price_Hour ph in crft.MyPriceHour) {
          XElement ph_el = new XElement("Night_Hour_Price",
          new XAttribute("value", ph.Value.ToString()),
          new XAttribute("date", ph.DateAccepted.ToString())
        );
        }
      }
      doc.Save(fileName);
    }
  }
}
