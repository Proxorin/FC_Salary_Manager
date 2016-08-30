namespace FC_Manage_Salary_WIzard.Object_Layer {
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
  using System.Data;


  /// <summary>Класс занимается подсчетом текущего состояния кармы для сотрудника с учетом периода времени</summary>
  class Karma {
    internal Employee myEmp;              // ссылка на родительского сотрудника
    internal List<StepKarma> KarmicPath;  //кармический путь 
    internal DateTime Start;
    internal DateTime Stop;
    private int valueInPeriod;

    /// <summary>Изменения кармы за период</summary>
    internal DataTable PathForPeriod
    {
      get
      {
        valueInPeriod = 0;
        DataTable dt = new DataTable();
        dt.Columns.Add("Дата", Type.GetType("System.DateTime"));
        dt.Columns.Add("Описание", Type.GetType("System.String"));
        dt.Columns.Add("Изменения", Type.GetType("System.Int32"));
        var Steps = from st in KarmicPath
                    where st.DateOfEvent > Start && st.DateOfEvent < Stop
                    select st;
        foreach(StepKarma step in Steps) {
          DataRow dr      = dt.Rows.Add();
          dr["Дата"]      = step.DateOfEvent;
          dr["Описание"]  = step.Description;
          dr["Изменения"] = step.Modification;
          valueInPeriod  += step.Modification;
        }
        return dt;
      }
    }

    /// <summary>Значение кармы </summary>
    internal int Value
    {
      get
      {
        int val = 0;
        foreach(StepKarma stpKrm in KarmicPath) {
          if(stpKrm.DateOfEvent < Stop) {
            val+=stpKrm.Modification;
          }
        }
        return val;
      }
    }

    /// <summary>Только для чтения значение кармы сотрудника за период</summary>
    public int ValueInPeriod
    {
      get
      {
        return valueInPeriod;
      }
    }
  }
}
