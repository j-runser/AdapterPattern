using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdapterPatternV2
{
    public partial class Form1 : Form
    {
        MetricFormulas metricFormulas;

        public Form1()
        {
            InitializeComponent();

            metricFormulas = new MetricFormulas();
            ComputeMetric();
        }

        private void btn_compute_Click(object sender, EventArgs e)
        {
            ComputeMetric();
        }

        private void btn_computeImperial_Click(object sender, EventArgs e)
        {
            ComputeImperial();
        }

        private void ComputeMetric()
        {
            double v1 = Convert.ToDouble(txtBox_avgAccV1.Text);
            double v2 = Convert.ToDouble(txtBox_avgAccV2.Text);
            double t = Convert.ToDouble(txtBox_avgAccT.Text);
            lbl_avgAccOut.Text = "" + metricFormulas.AverageAcceleration(v1, v2, t) + " m/s";

            v1 = Convert.ToDouble(txtBox_fallAccV.Text);
            t = Convert.ToDouble(txtBox_fallAccT.Text);
            lbl_fallAccOut.Text = "" + metricFormulas.FallingAcceleration(v1, t) + " m/s";

            v1 = Convert.ToDouble(txtBox_vertDistV.Text);
            t = Convert.ToDouble(txtBox_vertDistT.Text);
            lbl_projVertDistOut.Text = "" + metricFormulas.ProjectileVerticalDistance(v1, t) + " m";

            v1 = Convert.ToDouble(txtBox_horzDistV.Text);
            t = Convert.ToDouble(txtBox_horzDistT.Text);
            lbl_projHorzDistOut.Text = "" + metricFormulas.ProjectileHorizontalDistance(v1, t) + " m";

            v1 = Convert.ToDouble(txtBox_vertVelV.Text);
            t = Convert.ToDouble(txtBox_vertVelT.Text);
            lbl_projVertVelOut.Text = "" + metricFormulas.ProjectileVerticalVelocity(v1, t) + " m/s";
        }

        private void ComputeImperial()
        {
            double v1 = Convert.ToDouble(txtBox_avgAccV1.Text);
            double v2 = Convert.ToDouble(txtBox_avgAccV2.Text);
            double t = Convert.ToDouble(txtBox_avgAccT.Text);
            lbl_avgAccOut.Text = "" + Formulas.AverageAcceleration(v1, v2, t) + " f/s";

            v1 = Convert.ToDouble(txtBox_fallAccV.Text);
            t = Convert.ToDouble(txtBox_fallAccT.Text);
            lbl_fallAccOut.Text = "" + Formulas.FallingAcceleration(v1, t) + " f/s";

            v1 = Convert.ToDouble(txtBox_vertDistV.Text);
            t = Convert.ToDouble(txtBox_vertDistT.Text);
            lbl_projVertDistOut.Text = "" + Formulas.ProjectileVerticalDistance(v1, t) + " f";

            v1 = Convert.ToDouble(txtBox_horzDistV.Text);
            t = Convert.ToDouble(txtBox_horzDistT.Text);
            lbl_projHorzDistOut.Text = "" + Formulas.ProjectileHorizontalDistance(v1, t) + " f";

            v1 = Convert.ToDouble(txtBox_vertVelV.Text);
            t = Convert.ToDouble(txtBox_vertVelT.Text);
            lbl_projVertVelOut.Text = "" + Formulas.ProjectileVerticalVelocity(v1, t) + " f/s";
        }
    }
}
