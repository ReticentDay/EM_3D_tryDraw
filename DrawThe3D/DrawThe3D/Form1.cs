using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawThe3D
{
    public partial class Form1 : Form
    {
        List<Draw3D> drawList = new List<Draw3D>();

        void showNow() {
            pointText.Text = "";
            for (int i = 0; i < drawList[objectList.SelectedIndex].pointList.Length; i++) {
                pointText.Text += "Point[" + i + "]:\r\n";
                pointText.Text += (int)drawList[objectList.SelectedIndex].reXYZList[i].x + " ";
                pointText.Text += (int)drawList[objectList.SelectedIndex].reXYZList[i].y + " ";
                pointText.Text += (int)drawList[objectList.SelectedIndex].reXYZList[i].z + "\r\n";
            }
        }

        void drawIt() {
            Draw3D.p = -100;
            Graphics print3D = DisplayScreen.CreateGraphics();
            print3D.Clear(Color.White);
            print3D.DrawLine(new Pen(Brushes.Black), 0, 200, 800, 200);
            print3D.DrawLine(new Pen(Brushes.Black), 400, 0, 400, 400);
            print3D.DrawRectangle(new Pen(Brushes.Black), 0, 0, 799, 399);
            for (int i = 0; i < drawList.Count; i++)
            {
                drawList[i].printIt(ref print3D, new Pen(Brushes.Red), Brushes.Pink);
            }
            showNow();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            
            

            drawList.Add(new Line3D(100, 100, 1, 100, 100, 10));
            drawList.Add(new Line3D(100, 100, 10, -100, 100, 10));
            drawList.Add(new Line3D(-100, 100, 10, -100, 100, 1));
            drawList.Add(new Line3D(-100, 100, 1, 100, 100, 1));

            drawList.Add(new Rectangle3D(300, -100, 4, 122, 43));

        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                setBoxHeight.Enabled = setBoxLong.Enabled = setBoxName.Enabled = setBoxWeight.Enabled = setBoxX.Enabled = setBoxY.Enabled = setBoxZ.Enabled = true;
                setBoxName.Text = drawList[objectList.SelectedIndex].Name;
                setBoxX.Text = drawList[objectList.SelectedIndex].pointList[0].x.ToString();
                setBoxY.Text = drawList[objectList.SelectedIndex].pointList[0].y.ToString();
                setBoxZ.Text = drawList[objectList.SelectedIndex].pointList[0].z.ToString();
                setBoxHeight.Text = drawList[objectList.SelectedIndex].H.ToString();
                setBoxWeight.Text = drawList[objectList.SelectedIndex].W.ToString();
                setBoxLong.Text = drawList[objectList.SelectedIndex].L.ToString();
                switch (drawList[objectList.SelectedIndex].pointList.Length)
                {
                    case 1:
                        setBoxHeight.Enabled = setBoxLong.Enabled = setBoxWeight.Enabled = false;
                        break;
                    case 2:
                        break;
                    case 4:
                        setBoxLong.Enabled = false;
                        break;
                    case 8:
                        break;
                }
                setBoxTurnX.Text = (drawList[objectList.SelectedIndex].getTurnX()).ToString();
                setBoxTurnY.Text = (drawList[objectList.SelectedIndex].getTurnY()).ToString();
                setBoxTurnZ.Text = (drawList[objectList.SelectedIndex].getTurnZ()).ToString();
            }
            catch {
            }
        }
        private void pointToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawList.Add(new Point3D(0,0,0));
            objectList.Items.Add(drawList[drawList.Count - 1].Name);
        }

        private void setBoxX_TextChanged(object sender, EventArgs e)
        {
            try { 
                drawList[objectList.SelectedIndex].X = Convert.ToSingle(setBoxX.Text);
                drawIt();
            }
            catch
            {
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                drawList[objectList.SelectedIndex].Name = setBoxName.Text;
                objectList.Items[objectList.SelectedIndex] = setBoxName.Text;
            }
            catch
            {
            }
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                drawList.Add(new Line3D(0, 0, 0, 10, 10, 10));
                objectList.Items.Add(drawList[drawList.Count - 1].Name);
                drawIt();
            }
            catch
            {
            }
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                drawList.Add(new Rectangle3D(0, 0, 0,10,10));
                objectList.Items.Add(drawList[drawList.Count - 1].Name);
                drawIt();
            }
            catch
            {
            }
        }

        private void boxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                drawList.Add(new Box3D(0, 0, 0,10,10,10));
                objectList.Items.Add(drawList[drawList.Count - 1].Name);
                drawIt();
            }
            catch
            {
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            try
            {
                setBoxTurnX.Text = trackBar1.Value.ToString();
            }
            catch
            {
            }
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            try
            {
                setBoxTurnY.Text = trackBar2.Value.ToString();
            }
            catch
            {
            }
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            try
            {
                setBoxTurnZ.Text = trackBar3.Value.ToString();
            }
            catch
            {
            }
        }

        private void setBoxY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                drawList[objectList.SelectedIndex].Y = Convert.ToSingle(setBoxY.Text);
                drawIt();
            }
            catch
            {
            }
        }

        private void setBoxZ_TextChanged(object sender, EventArgs e)
        {
            try
            {
                drawList[objectList.SelectedIndex].Z = Convert.ToSingle(setBoxZ.Text);
                drawIt();
            }
            catch
            {
            }
        }

        private void setBoxHeight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                drawList[objectList.SelectedIndex].H = Convert.ToSingle(setBoxHeight.Text);
                drawIt();
            }
            catch
            {
            }
        }

        private void setBoxWeight_TextChanged(object sender, EventArgs e)
        {
            try
            {
                drawList[objectList.SelectedIndex].W = Convert.ToSingle(setBoxWeight.Text);
                drawIt();
            }
            catch
            {
            }
        }

        private void setBoxLong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                drawList[objectList.SelectedIndex].L = Convert.ToSingle(setBoxLong.Text);
                drawIt();
            }
            catch
            {
            }
        }

        private void setBoxTurnX_TextChanged(object sender, EventArgs e)
        {
            try
            {
                drawList[objectList.SelectedIndex].setTurnX(Convert.ToSingle(setBoxTurnX.Text), Convert.ToSingle(setBoxTurnY.Text), Convert.ToSingle(setBoxTurnZ.Text));
                trackBar1.Value = Convert.ToInt16(setBoxTurnX.Text);
                drawIt();
            }
            catch
            {
            }
        }

        private void setBoxTurnY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                drawList[objectList.SelectedIndex].setTurnX(Convert.ToSingle(setBoxTurnX.Text), Convert.ToSingle(setBoxTurnY.Text), Convert.ToSingle(setBoxTurnZ.Text));
                trackBar2.Value = Convert.ToInt16(setBoxTurnY.Text);
                drawIt();
            }
            catch
            {
            }
        }

        private void setBoxTurnZ_TextChanged(object sender, EventArgs e)
        {
            try
            {
                drawList[objectList.SelectedIndex].setTurnX(Convert.ToSingle(setBoxTurnX.Text), Convert.ToSingle(setBoxTurnY.Text), Convert.ToSingle(setBoxTurnZ.Text));
                trackBar3.Value = Convert.ToInt16(setBoxTurnZ.Text);
                drawIt();
            }
            catch
            {
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("3D繪圖範例程式" +
                                                  "製作：Silent Chang\r\n" +
                                                  "版本：1.0.0\r\n" +
                                                  "時間：2017/04","關於");
        }
    }
}
