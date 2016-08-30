namespace FC_Manage_Salary_WIzard.Object_Layer {
  using System;
  using System.Collections.Generic;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;


  /// <summary>Класс описывает этапы в карьере сотрудника</summary>


  class CareerHistoryLine {
    private Employee myemp;
    private byte typeCareerStep;
    private DateTime dateOfEvent;


    /// <summary>Тип карьерного шага
    /// 0 - принят впервые;
    /// 1 - принят вновь (работал ранее);
    /// 2 - переведен;
    /// 3 - выход из декретного отпуска;
    /// 3 - уволен;
    /// 4 - декретный отпуск;
    /// 5 - не определён
    /// </summary>
    public byte TypeCareerStep
    {
      get
      {
        return typeCareerStep;
      }

      set
      {
        if(value >= 0 && value <=4) {
          typeCareerStep=value;
        }
        else {
          typeCareerStep=5; // статус не определен!
        }

      }
    }

    /// <summary>Ссылка на родительского сотрудника</summary>
    internal Employee Myemp
    {
      get
      {
        return myemp;
      }

      set
      {
        myemp=value;
      }
    }

    /// <summary>Дата фиксации события</summary>
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
  }
}
