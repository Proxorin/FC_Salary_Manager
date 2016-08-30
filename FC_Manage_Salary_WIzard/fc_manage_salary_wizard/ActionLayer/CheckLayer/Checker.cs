namespace FC_Manage_Salary_WIzard.CheckLayer {
  using ActionLayer;
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
  using System.IO;


  /// <summary>Класс занимается исключительно проверками</summary>
  class Checker: Messager {

    /// <summary>проверка всех и сразу параметров</summary>
    internal static bool All(string[] param) {
      // первый этап - проверяем наличие доступа к директории базы данных
      if(!PathExchenge(Properties.Settings.Default.Path_to_Base_Directory))
        return false;
      // второй этап проверяем наличие списка должностей
      if(!PathExchenge(param[0] + "\\Craft.xml"))
        return false;
      SayMessage("Проверка всех необходимых данных прошла успешно");
      return true;
    }

    /// <summary>проверка наличия списка должностей</summary>
    internal static bool Counterparty(string fname) {
      if(File.Exists(fname) && Path.GetExtension(fname) ==".xml") {
        SayMessage("Проверка доступа к списку должностей прошла успешно");
        return true;
      }
      else {
        SayMessage("Проверка доступа к списку должностей завершилась неудачей");
        return false;
      }
    }

    /// <summary>Проверка пути к директории выгрузки xml</summary>
    internal static bool PathExchenge(string fname) {
      if(Directory.Exists(fname)) {
        SayMessage("Проверка доступа к базе данных прошла успешно");
        return true;
      }
      else {
        SayMessage("Проверка доступа к базе данных завершилась неудачей");
        return false;
      }

    }
  }
}
