namespace FC_Manage_Salary_WIzard.Object_Layer.Crafts_layer {
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;


  /// <summary>Инстанс класса содержит данные о стоимости часа работы и дату начала применения</summary>
  class Price_Hour: Crafts_Field {
    private double value;
    public Price_Hour(Craft crft, DateTime dateAcc, double val) :base(crft, dateAcc) {
      Value = val;
      DateAccepted = dateAcc;
      MyCraft = crft;
    }

    /// <summary>Стоимость часа</summary>
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
