namespace FC_Manage_Salary_WIzard.Object_Layer {
  using Crafts_layer;
  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


  /// <summary>Виртуальная база данных</summary>
  class VirtualBase {
    internal List<Craft> myCrafts;
    public VirtualBase() {
      myCrafts = new List<Craft>();
    }
  }
}
