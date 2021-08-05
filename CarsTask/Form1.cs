using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarsTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Car> Cars { get; set; }
        public int Index { get; set; } = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            Cars = new List<Car>();
            Cars.Add(new Car("X5", "BMW", 2019, 3.0, Properties.Resources._2019_bmw_x5_xdrive40i));

            Cars.Add(new Car("Rio", "Kia", 2008, 1.5, Properties.Resources._88517_CT9QYGZuJXJIkDNOKuaHRA));

            Cars.Add(new Car("E60", "BMW", 2006, 2.1, Properties.Resources.f8dec61254e60d6f640a63cb646d33dc));

            Cars.Add(new Car("Vito", "Mercedes", 2014, 2.2, Properties.Resources.Ox72q1NpTeP45fE0v3gRCwGo5_P5qI7f5NxudxCiytY3V70IeFmLRMNMWbBVyjJ1Zixb6JbvuhbJDTXeJQPdSfCHiWYz));

            Cars.Add(new Car("CRV", "Honda", 2012, 2.4, Properties.Resources.images));
            btnCarChanger_Click(null, null);
        }

        private void btnCarChanger_Click(object sender, EventArgs e)
        {
            if (Index == Cars.Count)
                Index = 0;
            lblCarModel.Text = Cars[Index].Model;
            lblCarVendor.Text = Cars[Index].Vendor;
            lblCarYear.Text = Cars[Index].Year.ToString();
            lblCarEngine.Text = Cars[Index].Engine.ToString();
            CarPicture.Image = Cars[Index].Picture;
            Index += 1;
        }
    }
}
