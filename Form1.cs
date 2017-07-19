using System;
using System.Windows.Forms;

namespace MHTPDHSSIC
{
    public partial class Form1 : Form
    {
        string query = "";
        bool j = false;

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            timer1.Interval = 10;
        }
        public void compute()
        {
            if (mathKernel.IsComputing)
            {
                mathKernel.Abort();
            }
            else
            {
                j = true;
                resultBox.Text = "";
                graphicsBox.Image = Properties.Resources.расчёт;
                mathKernel.GraphicsHeight = graphicsBox.Height;
                mathKernel.GraphicsWidth = graphicsBox.Width;
                computeButton.Text = "Отмена";
                query = "ClearAll; Rsourse = " + tbRcool.Text + "; Tcool = " + tbTcool.Text + "; ";
                query += "Ck = " + tbCk.Text + "; Rout = " + tbRout.Text + "; Tout = " + tbTout.Text + "; ";
                query += "C1 = " + tbC1.Text + "; C2 = " + tbC2.Text + "; V1 = " + tbV1.Text + "; V2 = " + tbV2.Text + "; ";
                query += "time = " + tbTime.Text + "; i = 0;Label[start];Clear[t];T = DSolve[{x'[t] == Rsourse * (Tcool - x[t]) * ((C1 * V1) ^ -1) - Ck * (x[t] - y[t]) * ((C1 * V1) ^ -1) - Rout(x[t] - Tout) * ((C1 * V1) ^ -1), ";
                query += "y'[t] == Ck*(x[t] - y[t])*((C2*V2)^-1), x[0] == " + tbT1.Text + ", y[0] == " + tbT2.Text + "}, { x[t], y[t]}, t];t := 60;";
                query += "While[T[[1, 1, 2]] > 60 || T[[1, 2, 2]] < -60 || T[[1, 2, 2]] > 60 || T[[1, 2, 2]] < -60 , {Tcool += 0.01, i++, If[i > 300, Break[]], Goto[start]}]; ";
                query += "If[i > 220, {Print[\"Under current conditions, life is impossible.Check the input\"], Abort[]}];";
                query += "Plot[{ T[[1, 1, 2]], T[[1, 2, 2]]}, { t, 0, time}, Frame -> " + рамкаToolStripMenuItem.Checked + " , PlotLegends -> Placed[{ \"t помещения (T1)\", \"t контура (T2)\"}, { Right, Center}], ";
                query += "AxesLabel -> {\"t, мин\", \"T1 / T2, C°\"}, PlotRange-> { { 0, time}, { 0, " + cbMaxt.SelectedItem + "} }];";
                try
                {
                    mathKernel.Compute(query);     //отправляем математическому ядрy
                    computeButton.Text = "Расчёт";
                    resultBox.Text = (string)mathKernel.Result; // Populate the various boxes with results.
                    foreach (string msg in mathKernel.Messages)
                        resultBox.Text += (msg + "\r\n");
                    foreach (string p in mathKernel.PrintOutput)
                        resultBox.Text += p;
                    if (mathKernel.Graphics.Length == 0) // The Graphics property returns an array of images, so it can accommodate       
                        graphicsBox.Image = Properties.Resources.error;// more than one graphic produced, but we only have room for one image.
                    if (mathKernel.Graphics.Length > 0)
                        graphicsBox.Image = mathKernel.Graphics[0];
                    j = false;
                }
                catch
                {
                    graphicsBox.Image = Properties.Resources.error;
                    resultBox.Text="Не выбрано местоположение ядра Wolfram Mathematica Kernel. Нажмите кнопку \"Обзор\" и выбирете";
                    computeButton.Text = "Обзор";
                }
            }
        }

        public void save_img()
            {
            if (graphicsBox.Image != null) //если в pictureBox есть изображение
            { 
                SaveFileDialog savedialog = new SaveFileDialog(); // "Сохранить как..", для сохранения изображения
                savedialog.Title = "Сохранить картинку как...";
                savedialog.OverwritePrompt = true; //отображать ли предупреждение, если пользователь указывает имя уже существующего файла
                savedialog.CheckPathExists = true; //отображать ли предупреждение, если пользователь указывает несуществующий путь
                savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";                //список форматов файла, отображаемый в поле "Тип файла"
                savedialog.ShowHelp = true; //отображается ли кнопка "Справка" в диалоговом окне
                if (savedialog.ShowDialog() == DialogResult.OK) //если в диалоговом окне нажата кнопка "ОК"
                {
                    try
                    {
                        graphicsBox.Image.Save(savedialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
                    }
                    catch
                    {
                        MessageBox.Show("Невозможно сохранить изображение", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (кнопкойРасчётToolStripMenuItem.Checked)
            {
                compute();
            }
        }

        private void сохранитьГрафикКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save_img();
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbMaxt.SelectedIndex = 0;
            compute();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            cbMaxt.SelectedIndex = 1;
            compute();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            cbMaxt.SelectedIndex = 2;
            compute();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            cbMaxt.SelectedIndex = 3;
            compute();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            cbMaxt.SelectedIndex = 4;
            compute();
        }

        private void расчётToolStripMenuItem_Click(object sender, EventArgs e)
        {
            compute();
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbTcool_TextChanged(object sender, EventArgs e)
        {
            if (приИзменииДанныхToolStripMenuItem.Checked)
                compute();
        }

        private void tbT2_TextChanged(object sender, EventArgs e)
        {
            if (приИзменииДанныхToolStripMenuItem.Checked)
                compute();
        }

        private void tbT1_TextChanged(object sender, EventArgs e)
        {
            if (приИзменииДанныхToolStripMenuItem.Checked)
                compute();
        }

        private void tbTout_TextChanged(object sender, EventArgs e)
        {
            if (приИзменииДанныхToolStripMenuItem.Checked)
                compute();
        }

        private void tbV1_TextChanged(object sender, EventArgs e)
        {
            if (приИзменииДанныхToolStripMenuItem.Checked)
                compute();
        }

        private void tbV2_TextChanged(object sender, EventArgs e)
        {
            if (приИзменииДанныхToolStripMenuItem.Checked)
                compute();
        }

        private void tbC1_TextChanged(object sender, EventArgs e)
        {
            if (приИзменииДанныхToolStripMenuItem.Checked)
                compute();
        }

        private void tbC2_TextChanged(object sender, EventArgs e)
        {
            if (приИзменииДанныхToolStripMenuItem.Checked)
                compute();
        }

        private void tbRcool_TextChanged(object sender, EventArgs e)
        {
            if (приИзменииДанныхToolStripMenuItem.Checked)
                compute();
        }

        private void tbRout_TextChanged(object sender, EventArgs e)
        {
            if (приИзменииДанныхToolStripMenuItem.Checked)
                compute();
        }

        private void tbCk_TextChanged(object sender, EventArgs e)
        {
            if (приИзменииДанныхToolStripMenuItem.Checked)
                compute();
        }

        private void tbTime_TextChanged(object sender, EventArgs e)
        {
            if(приИзменииДанныхToolStripMenuItem.Checked)
               compute();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (приИзменииДанныхToolStripMenuItem.Checked)
            {
                if (j)
                {
                    tbTcool.ReadOnly = true;
                    tbC1.ReadOnly = true;
                    tbC2.ReadOnly = true;
                    tbCk.ReadOnly = true;
                    tbRcool.ReadOnly = true;
                    tbRout.ReadOnly = true;
                    tbT1.ReadOnly = true;
                    tbT2.ReadOnly = true;
                    tbTime.ReadOnly = true;
                    tbTout.ReadOnly = true;
                    tbV1.ReadOnly = true;
                    tbV2.ReadOnly = true;
                }
                else
                {
                    tbTcool.ReadOnly = false;
                    tbTcool.ReadOnly = false;
                    tbC1.ReadOnly = false;
                    tbC2.ReadOnly = false;
                    tbCk.ReadOnly = false;
                    tbRcool.ReadOnly = false;
                    tbRout.ReadOnly = false;
                    tbT1.ReadOnly = false;
                    tbT2.ReadOnly = false;
                    tbTime.ReadOnly = false;
                    tbTout.ReadOnly = false;
                    tbV1.ReadOnly = false;
                    tbV2.ReadOnly = false;
                }
            }
        }

        private void кнопкойРасчётToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if(кнопкойРасчётToolStripMenuItem.Checked)
            {

            }
        }
    }
}
