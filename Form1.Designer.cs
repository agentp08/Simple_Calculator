namespace SimpCal_again
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txt_a = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txt_b = new TextBox();
            label4 = new Label();
            txt_c = new TextBox();
            plus = new Button();
            minus = new Button();
            mul = new Button();
            div = new Button();
            cls = new Button();
            pow = new Button();
            sqrt = new Button();
            hScrollBar1 = new HScrollBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(341, 29);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 0;
            label1.Text = "This is a Cowculator";
            // 
            // txt_a
            // 
            txt_a.AccessibleName = "";
            txt_a.Location = new Point(163, 74);
            txt_a.Name = "txt_a";
            txt_a.Size = new Size(531, 27);
            txt_a.TabIndex = 1;
            txt_a.KeyPress += txt_a_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 77);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "Cow a";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 150);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 4;
            label3.Text = "Cow b";
            // 
            // txt_b
            // 
            txt_b.AccessibleName = "";
            txt_b.Location = new Point(163, 147);
            txt_b.Name = "txt_b";
            txt_b.Size = new Size(531, 27);
            txt_b.TabIndex = 3;
            txt_b.KeyPress += txt_b_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 307);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 6;
            label4.Text = "Moooooooo";
            // 
            // txt_c
            // 
            txt_c.AccessibleName = "";
            txt_c.Location = new Point(163, 304);
            txt_c.Name = "txt_c";
            txt_c.Size = new Size(531, 27);
            txt_c.TabIndex = 5;
            // 
            // plus
            // 
            plus.AccessibleName = "";
            plus.Location = new Point(42, 215);
            plus.Name = "plus";
            plus.Size = new Size(69, 54);
            plus.TabIndex = 7;
            plus.Text = "+";
            plus.UseVisualStyleBackColor = true;
            plus.Click += plus_Click;
            // 
            // minus
            // 
            minus.AccessibleName = "";
            minus.Location = new Point(170, 215);
            minus.Name = "minus";
            minus.Size = new Size(69, 54);
            minus.TabIndex = 8;
            minus.Text = "-";
            minus.UseVisualStyleBackColor = true;
            minus.Click += minus_Click;
            // 
            // mul
            // 
            mul.AccessibleName = "";
            mul.Location = new Point(298, 215);
            mul.Name = "mul";
            mul.Size = new Size(69, 54);
            mul.TabIndex = 9;
            mul.Text = "*";
            mul.UseVisualStyleBackColor = true;
            mul.Click += mul_Click;
            // 
            // div
            // 
            div.AccessibleName = "";
            div.Location = new Point(426, 215);
            div.Name = "div";
            div.Size = new Size(69, 54);
            div.TabIndex = 10;
            div.Text = "/";
            div.UseVisualStyleBackColor = true;
            div.Click += div_Click;
            // 
            // cls
            // 
            cls.AccessibleName = "";
            cls.Location = new Point(582, 369);
            cls.Name = "cls";
            cls.Size = new Size(122, 58);
            cls.TabIndex = 11;
            cls.Text = "Close";
            cls.UseVisualStyleBackColor = true;
            cls.Click += cls_Click;
            // 
            // pow
            // 
            pow.AccessibleName = "";
            pow.Location = new Point(554, 215);
            pow.Name = "pow";
            pow.Size = new Size(69, 54);
            pow.TabIndex = 12;
            pow.Text = "Sqr";
            pow.UseVisualStyleBackColor = true;
            pow.Click += pow_Click;
            // 
            // sqrt
            // 
            sqrt.AccessibleName = "";
            sqrt.Location = new Point(682, 215);
            sqrt.Name = "sqrt";
            sqrt.Size = new Size(69, 54);
            sqrt.TabIndex = 13;
            sqrt.Text = "Sqrt";
            sqrt.TextImageRelation = TextImageRelation.ImageAboveText;
            sqrt.UseVisualStyleBackColor = true;
            sqrt.Click += sqrt_Click;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(757, 392);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(100, 26);
            hScrollBar1.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(hScrollBar1);
            Controls.Add(sqrt);
            Controls.Add(pow);
            Controls.Add(cls);
            Controls.Add(div);
            Controls.Add(mul);
            Controls.Add(minus);
            Controls.Add(plus);
            Controls.Add(label4);
            Controls.Add(txt_c);
            Controls.Add(label3);
            Controls.Add(txt_b);
            Controls.Add(label2);
            Controls.Add(txt_a);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Label label1;
        private TextBox txt_a;
        private Label label2;
        private Label label3;
        private TextBox txt_b;
        private Label label4;
        private TextBox txt_c;
        private Button plus;
        private Button minus;
        private Button mul;
        private Button div;
        private Button cls;
        private Button pow;
        private Button sqrt;
        private HScrollBar hScrollBar1;
    }
}
