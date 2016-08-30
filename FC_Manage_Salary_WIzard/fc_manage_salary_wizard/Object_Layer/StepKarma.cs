namespace FC_Manage_Salary_WIzard.Object_Layer {
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;


  /// <summary>Класс описывает сдвиг в карме</summary>
  class StepKarma {
    private string description;
    private sbyte modification;
    private DateTime dateOfEvent;

    /// <summary>Описание (суть произошедшего)</summary>
    public string Description
    {
      get
      {
        return description;
      }

      set
      {
        description=value;
      }
    }

    /// <summary>Дата и время возникновения события</summary>
    public DateTime DateOfEvent
    {
      get
      {
        return dateOfEvent;
      }

      set
      {
        dateOfEvent=value;
      }
    }

    /// <summary>Влияние на карму в целом (вектор и значение)</summary>
    public sbyte Modification
    {
      get
      {
        return modification;
      }

      set
      {
        modification=value;
      }
    }

  }
}
