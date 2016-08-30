namespace FC_Manage_Salary_WIzard.Object_Layer.Crafts_layer {
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;


  /// <summary>Инстанс класса описывает количество дней в течение которых сотрудник считается новобранцем</summary>
  class Day_Yong: Crafts_Field {
    private int value;
    public Day_Yong(Craft crft, DateTime dateAcc, int val) : base(crft, dateAcc) {
      Value = val;
      DateAccepted = dateAcc;
      MyCraft = crft;
    }

    /// <summary>Количество дней в течение которых сотрудник проходит испытательный срок</summary>
    public int Value
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
