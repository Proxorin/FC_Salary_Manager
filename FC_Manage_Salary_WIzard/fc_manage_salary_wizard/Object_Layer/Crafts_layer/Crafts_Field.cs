namespace FC_Manage_Salary_WIzard.Object_Layer.Crafts_layer {
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;

  /// <summary>Базовый класс для любых полей должности</summary>
  class Crafts_Field {
    private DateTime dateAccepted;
    private Craft myCraft;

    public Crafts_Field(Craft crft, DateTime dateAcc) {
      MyCraft = crft;
      DateAccepted = dateAcc;
    }
    /// <summary>Дата начала применения</summary>
    public DateTime DateAccepted
    {
      get
      {
        return dateAccepted;
      }

      set
      {
        dateAccepted=value;
      }
    }

    internal Craft MyCraft
    {
      get
      {
        return myCraft;
      }

      set
      {
        myCraft=value;
      }
    }
  }
}
