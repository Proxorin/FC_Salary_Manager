namespace FC_Manage_Salary_WIzard.Object_Layer.Crafts_layer {
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;


  /// <summary>Инстанс класса описывает норму часов в день</summary>
  class Hour_In_Day: Crafts_Field {
    private double value;

    public Hour_In_Day(Craft crft, DateTime dateAcc, double val) : base(crft, dateAcc) {
      Value = val;
      DateAccepted = dateAcc;
      MyCraft = crft;
    }

    /// <summary>количество рабочих часов в день (без учета обеда и перекуров)</summary>
    public double Value
    {
      get
      {
        return value;
      }

      set
      {
        this.value=value;
      }
    }
  }
}
