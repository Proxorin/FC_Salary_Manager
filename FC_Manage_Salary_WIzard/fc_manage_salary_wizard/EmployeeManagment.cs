namespace FC_Manage_Salary_WIzard {
  using System;
  using System.Collections.Generic;
  using System.ComponentModel;
  using System.Data;
  using System.Drawing;
  using System.Linq;
  using System.Text;
  using System.Threading.Tasks;
  using System.Windows.Forms;
  using FC_Manage_Salary_WIzard.Object_Layer;


  public partial class EmployeeManagment: Form {
    public EmployeeManagment() {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e) {
      //Employee em = new Employee();
      //em.Name_1C = "Мастер Управления Зарплата";
      //this.Text = em.FndKey;
      CraftManager  cr =new CraftManager();
      cr.Show();
    }
  }
}
