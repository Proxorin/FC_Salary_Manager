namespace FC_Manage_Salary_WIzard.Object_Layer.Crafts_layer {
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;


  /// <summary>Инстанс класса описывает стоимость оплаты одного ночного часа для сотрудника</summary>
  class Night_Hour_Price: Crafts_Field {
    private double value;
    public Night_Hour_Price(Craft crft, DateTime dateAcc, double val) : base(crft, dateAcc) {
      Value = val;
      DateAccepted = dateAcc;
      MyCraft = crft;
    }

    /// <summary>Стоимость оплаты одного ночного часа для указанной должности</summary>
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
