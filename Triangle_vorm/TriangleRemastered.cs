using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangle_vorm
{
    public partial class TriangleRemastered : Form
    {
        Graphics gp;
        Pen p = new Pen(Brushes.Black, 2);

        CheckBox aBox, bBox, cBox, hBox;
        Label label1, label2, label3, label4, label5, label6, label7, label8;
        Button button1, uncheckAll;
        NumericUpDown aNumeric, bNumeric, cNumeric, hNumeric, pNumeric, sNumeric;
        ListView listView1;
        ColumnHeader column1, column2;
        public TriangleRemastered()
        {

           
        
            gp = CreateGraphics();

            this.column1 = new ColumnHeader();
            this.column2 = new ColumnHeader();
            this.aBox = new CheckBox();
            this.label1 = new Label();
            this.bBox = new CheckBox();
            this.cBox = new CheckBox();
            this.hBox = new CheckBox();
            this.aNumeric = new NumericUpDown();
            this.label2 = new Label();
            this.label3 = new Label();
            this.bNumeric = new NumericUpDown();
            this.label4 = new Label();
            this.cNumeric = new NumericUpDown();
            this.label5 = new Label();
            this.hNumeric = new NumericUpDown();
            this.label6 = new Label();
            this.pNumeric = new NumericUpDown();
            this.label7 = new Label();
            this.sNumeric = new NumericUpDown();
            this.label8 = new Label();
            this.button1 = new Button();
            this.uncheckAll = new Button();
            this.listView1 = new ListView();
            ((ISupportInitialize)(this.aNumeric)).BeginInit();
            ((ISupportInitialize)(this.bNumeric)).BeginInit();
            ((ISupportInitialize)(this.cNumeric)).BeginInit();
            ((ISupportInitialize)(this.hNumeric)).BeginInit();
            ((ISupportInitialize)(this.pNumeric)).BeginInit();
            ((ISupportInitialize)(this.sNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // aBox
            // 
            this.aBox.AutoSize = true;
            this.aBox.Location = new Point(63, 105);
            this.aBox.Name = "aBox";
            this.aBox.Size = new Size(32, 17);
            this.aBox.TabIndex = 0;
            this.aBox.Text = "a";
            this.aBox.UseVisualStyleBackColor = true;
            this.aBox.CheckedChanged += new EventHandler(this.aBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true; 
            this.label1.Location = new Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new Size(133, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Какие данные имеются?";
            // 
            // bBox
            // 
            this.bBox.AutoSize = true;
            this.bBox.Location = new Point(63, 125);
            this.bBox.Name = "bBox";
            this.bBox.Size = new Size(32, 17);
            this.bBox.TabIndex = 2;
            this.bBox.Text = "b";
            this.bBox.UseVisualStyleBackColor = true;
            this.bBox.CheckedChanged += new EventHandler(this.bBox_CheckedChanged);
            // 
            // cBox
            // 
            this.cBox.AutoSize = true;
            this.cBox.Location = new Point(63, 145);
            this.cBox.Name = "cBox";
            this.cBox.Size = new Size(32, 17);
            this.cBox.TabIndex = 3;
            this.cBox.Text = "c";
            this.cBox.UseVisualStyleBackColor = true;
            this.cBox.CheckedChanged += new EventHandler(this.cBox_CheckedChanged);
            // 
            // columnHeader1
            // 
            this.column1.Text = "Поле";
            this.column1.Width = 172;
            // 
            // columnHeader2
            // 
            this.column2.Text = "Значение";
            this.column2.Width = 122;
            // 
            // hBox
            // 
            this.hBox.AutoSize = true;
            this.hBox.Location = new Point(63, 165);
            this.hBox.Name = "hBox";
            this.hBox.Size = new Size(32, 17);
            this.hBox.TabIndex = 6;
            this.hBox.Text = "Равносторонний?";
            this.hBox.UseVisualStyleBackColor = true;
            this.hBox.CheckedChanged += new EventHandler(this.hBox_CheckedChanged);
            // 
            // aNumeric
            // 
            this.aNumeric.Location = new Point(31, 268);
            this.aNumeric.Name = "aNumeric";
            this.aNumeric.Size = new Size(94, 20);
            this.aNumeric.TabIndex = 9;
            this.aNumeric.Visible = false;
            this.aNumeric.ValueChanged += new EventHandler(this.aNumeric_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new Point(28, 238);
            this.label2.Name = "label2";
            this.label2.Size = new Size(97, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Вводи данные тут";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new Point(12, 270);
            this.label3.Name = "label3";
            this.label3.Size = new Size(13, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "a";
            this.label3.Visible = false;
            // 
            // bNumeric
            // 
            this.bNumeric.Location = new Point(31, 294);
            this.bNumeric.Name = "bNumeric";
            this.bNumeric.Size = new Size(94, 20);
            this.bNumeric.TabIndex = 12;
            this.bNumeric.Visible = false;
            this.bNumeric.ValueChanged += new EventHandler(this.bNumeric_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new Point(12, 296);
            this.label4.Name = "label4";
            this.label4.Size = new Size(13, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "b";
            this.label4.Visible = false;
            this.label4.Click += new EventHandler(this.label4_Click);
            // 
            // cNumeric
            // 
            this.cNumeric.Location = new Point(31, 320);
            this.cNumeric.Name = "cNumeric";
            this.cNumeric.Size = new Size(94, 20);
            this.cNumeric.TabIndex = 14;
            this.cNumeric.Visible = false;
            this.cNumeric.ValueChanged += new EventHandler(this.cNumeric_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new Point(12, 322);
            this.label5.Name = "label5";
            this.label5.Size = new Size(13, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "c";
            this.label5.Visible = false;
            this.label5.Click += new EventHandler(this.label5_Click);
            // 
            // hNumeric
            // 
            this.hNumeric.Location = new Point(31, 346);
            this.hNumeric.Name = "hNumeric";
            this.hNumeric.Size = new Size(94, 20);
            this.hNumeric.TabIndex = 16;
            this.hNumeric.Visible = false;
            this.hNumeric.ValueChanged += new EventHandler(this.hNumeric_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new Point(12, 348);
            this.label6.Name = "label6";
            this.label6.Size = new Size(13, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "P";
            this.label6.Visible = false;
            this.label6.Click += new EventHandler(this.label6_Click);
            // 
            // pNumeric
            // 
            this.pNumeric.Location = new Point(31, 372);
            this.pNumeric.Name = "pNumeric";
            this.pNumeric.Size = new Size(94, 20);
            this.pNumeric.TabIndex = 18;
            this.pNumeric.Visible = false;
            this.pNumeric.ValueChanged += new EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new Point(12, 374);
            this.label7.Name = "label7";
            this.label7.Size = new Size(14, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "P";
            this.label7.Visible = false;
            this.label7.Click += new EventHandler(this.label7_Click);
            // 
            // sNumeric
            // 
            this.sNumeric.Location = new Point(31, 398);
            this.sNumeric.Name = "sNumeric";
            this.sNumeric.Size = new Size(94, 20);
            this.sNumeric.TabIndex = 20;
            this.sNumeric.Visible = false;
            this.sNumeric.ValueChanged += new EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new Point(12, 400);
            this.label8.Name = "label8";
            this.label8.Size = new Size(14, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "S";
            this.label8.Visible = false;
            this.label8.Click += new EventHandler(this.label8_Click);
            // 
            // button1
            //
            this.button1.Location = new Point(280, 357);
            this.button1.Name = "button1";
            this.button1.Size = new Size(103, 61);
            this.button1.TabIndex = 22;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            //
            // listView
            //
            this.listView1.Columns.AddRange(new ColumnHeader[] {
            this.column1,
            this.column2});
            this.listView1.HideSelection = false;
            this.listView1.Location = new Point(205, 9);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(262, 331);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = View.Details;
            // 
            // uncheckAll
            // 
            this.uncheckAll.Location = new System.Drawing.Point(32, 197);
            this.uncheckAll.Name = "uncheckAll";
            this.uncheckAll.Size = new System.Drawing.Size(92, 21);
            this.uncheckAll.TabIndex = 23;
            this.uncheckAll.Text = "Убрать все галочки";
            this.uncheckAll.UseVisualStyleBackColor = true;
            this.uncheckAll.Click += new System.EventHandler(this.uncheckAll_Click);
            // 
            // From3
            // 
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(517, 450);
            this.Controls.Add(this.uncheckAll);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.sNumeric);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pNumeric);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.hNumeric);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cNumeric);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bNumeric);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aNumeric);
            this.Controls.Add(this.hBox);
            this.Controls.Add(this.cBox);
            this.Controls.Add(this.bBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.aBox);
            this.Controls.Add(this.listView1);
            this.Name = "Triangle v2";
            this.ShowIcon = false;
            this.Text = "Triangle";
            this.Load += new System.EventHandler(this.TriangleRemastered_Load);
            ((ISupportInitialize)(this.aNumeric)).EndInit();
            ((ISupportInitialize)(this.bNumeric)).EndInit();
            ((ISupportInitialize)(this.cNumeric)).EndInit();
            ((ISupportInitialize)(this.hNumeric)).EndInit();
            ((ISupportInitialize)(this.pNumeric)).EndInit();
            ((ISupportInitialize)(this.sNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
            button1.Enabled = false;
        }
        int boxes = 0;
        public void btn_check()
        {
            if (boxes >= 3)
            {
                button1.Enabled = true;
            }
            else if (boxes < 3)
            {
                button1.Enabled = false;
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void aNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TriangleRemastered_Load_1(object sender, EventArgs e)
        {

        }

        private void cNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void hNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TriangleRemastered_Load(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void bBox_CheckedChanged(object sender, EventArgs e)
        {

            if (bBox.Checked == true)
            {
                boxes++;
                bNumeric.Visible = true;
                label4.Visible = true;
            }
            else
            {
                boxes--;
                bNumeric.Visible = false;
                label4.Visible = false;
            }
            btn_check();
        }
        private void aBox_CheckedChanged(object sender, EventArgs e)
        {

            if (aBox.Checked == true)
            {
                boxes++;
                aNumeric.Visible = true;
                label3.Visible = true;
            }
            else
            {
                boxes--;
                aNumeric.Visible = false;
                label3.Visible = false;
            }
            btn_check();
        }

        private void cBox_CheckedChanged(object sender, EventArgs e)
        {

            if (cBox.Checked == true)
            {
                boxes++;
                cNumeric.Visible = true;
                label5.Visible = true;
            }
            else
            {
                boxes--;
                cNumeric.Visible = false;
                label5.Visible = false;
            }
            btn_check();
        }

        private void LevCanvas()
        {

        }
        private void hBox_CheckedChanged(object sender, EventArgs e)
        {

            if (hBox.Checked == true)
            {
                boxes=3;
                aBox.Enabled = false;
                bBox.Enabled = false;
                cBox.Enabled = false;
                hNumeric.Visible = true;
                label6.Visible = true;
            }
            else
            {
                boxes=0;
                hNumeric.Visible = false;
                label6.Visible = false;
            }
            btn_check();
        }
    
        private void button1_Click(object sender, EventArgs e) //расчёт
        {
            gp.Clear(DefaultBackColor);//очистка треугольника
            listView1.Items.Clear();
            if (aBox.Checked == true && bBox.Checked == true && cBox.Checked == true)
            {
                double a, b, c;
                a = Convert.ToDouble(aNumeric.Value);
                b = Convert.ToDouble(bNumeric.Value);
                c = Convert.ToDouble(cNumeric.Value);
                Triangle triangle = new Triangle(a, b, c);
                listView1.Items.Add("Сторона a");
                listView1.Items.Add("Сторона b");
                listView1.Items.Add("Сторона c");
                listView1.Items.Add("Периметр");
                listView1.Items.Add("Площадь");
                listView1.Items.Add("Высота");
                listView1.Items.Add("Существует?");
                listView1.Items.Add("Спецификатор");
                listView1.Items[0].SubItems.Add(triangle.outputA());
                listView1.Items[1].SubItems.Add(triangle.outputB());
                listView1.Items[2].SubItems.Add(triangle.outputC());
                listView1.Items[3].SubItems.Add(Convert.ToString(triangle.Perimeter()));
                listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Surface()));
                listView1.Items[5].SubItems.Add(Convert.ToString(triangle.Height())); // Метод нахождения высоты
                if (a == b && b == c && c == b) { listView1.Items[7].SubItems.Add("Равносторонний"); } // Типы треугольников
                else if (b == c) { listView1.Items[7].SubItems.Add("Равнобедренный"); }
                else { listView1.Items[7].SubItems.Add("Разносторонний"); }
                if (triangle.ExistTriangle) { listView1.Items[6].SubItems.Add("Не существует"); }
                else if (triangle.Height() == 0) { listView1.Items[6].SubItems.Add("Не существует"); }
                else if ((a + b) < c && (b + c) < a && (a + c) < b) { listView1.Items[6].SubItems.Add("Не существует"); }
                else listView1.Items[6].SubItems.Add("Существует");
                listView1.Items.Add("Угол альфа");
                listView1.Items[8].SubItems.Add(Convert.ToString(Math.Round(triangle.getCornerAlpha())));
                listView1.Items.Add("Угол бета");
                listView1.Items[9].SubItems.Add(Convert.ToString(Math.Round(triangle.getCornerBeta())));
                listView1.Items.Add("Угол гамма");
                listView1.Items[10].SubItems.Add(Convert.ToString(Math.Round(triangle.getCornerGamma())));
                if (triangle.getCornerAlpha() == 90 || triangle.getCornerBeta() == 90 || triangle.getCornerGamma() == 90)
                {

                    Point p1 = new Point(10, 5);
                    Point p2 = new Point(150, 5);
                    Point p3 = new Point(150, 50);
                    Point[] list = new Point[3] { p1, p2, p3 };
                    gp.DrawPolygon(p, list);
                }
                else if (triangle.getCornerAlpha() > 90 || triangle.getCornerBeta() > 90 || triangle.getCornerGamma() > 90)
                {
                    Point p1 = new Point(10, 5);
                    Point p2 = new Point(150, 5);
                    Point p3 = new Point(130, 70);
                    Point[] list2 = new Point[3] { p1, p2, p3 };
                    gp.DrawPolygon(p, list2);
                }
                else
                {
                    Point p1 = new Point(10, 5);
                    Point p2 = new Point(150, 5);
                    Point p3 = new Point(75, 60);
                    Point[] list = new Point[3] { p1, p2, p3 };
                    gp.DrawPolygon(p, list);
                }


            }
            else if (hBox.Checked == true)
            {
                
                if(hNumeric.Value % 3 == 0)
                {
                    double per, a, b, c;
                    per = Convert.ToDouble(hNumeric.Value);


                    Triangle triangle = new Triangle(per, a, b, c);
                    decimal perr = hNumeric.Value / 3;
                    listView1.Items.Add("Сторона a");
                    listView1.Items.Add("Сторона b");
                    listView1.Items.Add("Сторона c");
                    listView1.Items.Add("Периметр");
                    listView1.Items.Add("Площадь");
                    listView1.Items.Add("Высота");
                    listView1.Items.Add("Существует?");
                    listView1.Items.Add("Спецификатор");
                    listView1.Items[0].SubItems.Add(Convert.ToString(perr));
                    listView1.Items[1].SubItems.Add(Convert.ToString(perr));
                    listView1.Items[2].SubItems.Add(Convert.ToString(perr));   
                    listView1.Items[3].SubItems.Add(Convert.ToString(hNumeric.Value));
                    listView1.Items[4].SubItems.Add(Convert.ToString(triangle.Surface()));
                    listView1.Items[5].SubItems.Add(Convert.ToString(triangle.Height()));

                    a = Convert.ToDouble(listView1.Items[0]);
                    b = Convert.ToDouble(listView1.Items[1]);
                    c = Convert.ToDouble(listView1.Items[2]);

                }
            }
            
            
            



        }

        private void uncheckAll_Click(object sender, EventArgs e)
        {
            aBox.Checked = false;
            bBox.Checked = false;
            cBox.Checked = false;
            hBox.Checked = false;
        }
    }
}
