﻿namespace FC_Manage_Salary_WIzard {
  using System;
  using Object_Layer;
  using System.Collections.Generic;
  using System.ComponentModel;
  using System.Data;
  using System.Drawing;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
  using System.Windows.Forms;


  public partial class CraftManager: Form {
    internal VirtualBase myDb; // ссылка на основную базу даннных
    public CraftManager() {
      InitializeComponent();
    }

    private void CraftManager_Load(object sender, EventArgs e) {

    }
  }
}
