namespace FC_Manage_Salary_WIzard.Object_Layer {
  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


  ///<summary>Класс описывает сотрудника</summary>
  class Employee {
    private string name_1C;   
    private string name_LV;   
    private string name_SKUD;
    private string table_Number;
    
  

    /// <summary>Свойство по которому осуществляется поиск (ctrl+f)</summary>
    public string FndKey
    {
      get
      {
        return name_1C.ToLower().Replace(" ", "");
      }
    }

    /// <summary>имя сотрудника в системе 1С</summary>
    public string Name_1C
    {
      get
      {
        return name_1C;
      }

      set
      {
        name_1C=value;
      }
    }

    /// <summary>имя сотрудника в системе LV</summary>
    public string Name_LV
    {
      get
      {
        return name_LV;
      }

      set
      {
        name_LV=value;
      }
    }

    /// <summary>имя сотрудника в системе скуд</summary>
    public string Name_SKUD
    {
      get
      {
        return name_SKUD;
      }
      set
      {
        name_SKUD=value;
      }
    }

    /// <summary>табельный номер сотрудника в системе 1С</summary>
    public string Table_Number
    {
      get
      {
        return table_Number;
      }

      set
      {
        table_Number=value;
      }
    }
        
   
  }
}
