namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.bisection = new System.Windows.Forms.RadioButton();
            this.newton = new System.Windows.Forms.RadioButton();
            this.secant = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bisectionMinTxt = new System.Windows.Forms.TextBox();
            this.bisectionMaxTxt = new System.Windows.Forms.TextBox();
            this.bisectionErrorTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bisectionGroup = new System.Windows.Forms.GroupBox();
            this.newtonMethod = new System.Windows.Forms.GroupBox();
            this.newtonStartMax = new System.Windows.Forms.RadioButton();
            this.newronStartMin = new System.Windows.Forms.RadioButton();
            this.relativeError = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.newtonError = new System.Windows.Forms.TextBox();
            this.newtonMaxTxt = new System.Windows.Forms.TextBox();
            this.newtonMinTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.secantGroup = new System.Windows.Forms.GroupBox();
            this.secantRelative = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.secantError = new System.Windows.Forms.TextBox();
            this.secantX1Txt = new System.Windows.Forms.TextBox();
            this.secantX0Txt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.bisectionGroup.SuspendLayout();
            this.newtonMethod.SuspendLayout();
            this.secantGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Function:  x^3 - 7x^2 + 14x - 6 = 0";
            // 
            // bisection
            // 
            this.bisection.AutoSize = true;
            this.bisection.Location = new System.Drawing.Point(233, 70);
            this.bisection.Name = "bisection";
            this.bisection.Size = new System.Drawing.Size(107, 17);
            this.bisection.TabIndex = 1;
            this.bisection.TabStop = true;
            this.bisection.Text = "Bisection Method";
            this.bisection.UseVisualStyleBackColor = true;
            this.bisection.CheckedChanged += new System.EventHandler(this.bisection_CheckedChanged);
            // 
            // newton
            // 
            this.newton.AutoSize = true;
            this.newton.Location = new System.Drawing.Point(233, 113);
            this.newton.Name = "newton";
            this.newton.Size = new System.Drawing.Size(147, 17);
            this.newton.TabIndex = 2;
            this.newton.TabStop = true;
            this.newton.Text = "Newton Raphson Method";
            this.newton.UseVisualStyleBackColor = true;
            this.newton.CheckedChanged += new System.EventHandler(this.newton_CheckedChanged);
            // 
            // secant
            // 
            this.secant.AutoSize = true;
            this.secant.Location = new System.Drawing.Point(233, 159);
            this.secant.Name = "secant";
            this.secant.Size = new System.Drawing.Size(98, 17);
            this.secant.TabIndex = 3;
            this.secant.TabStop = true;
            this.secant.Text = "Secant Method";
            this.secant.UseVisualStyleBackColor = true;
            this.secant.CheckedChanged += new System.EventHandler(this.secant_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Interval:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Min:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Max:";
            // 
            // bisectionMinTxt
            // 
            this.bisectionMinTxt.Location = new System.Drawing.Point(9, 54);
            this.bisectionMinTxt.Multiline = true;
            this.bisectionMinTxt.Name = "bisectionMinTxt";
            this.bisectionMinTxt.Size = new System.Drawing.Size(39, 20);
            this.bisectionMinTxt.TabIndex = 7;
            this.bisectionMinTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bisectionMinTxt_KeyPress);
            // 
            // bisectionMaxTxt
            // 
            this.bisectionMaxTxt.Location = new System.Drawing.Point(78, 54);
            this.bisectionMaxTxt.Name = "bisectionMaxTxt";
            this.bisectionMaxTxt.Size = new System.Drawing.Size(39, 20);
            this.bisectionMaxTxt.TabIndex = 8;
            this.bisectionMaxTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bisectionMaxTxt_KeyPress);
            // 
            // bisectionErrorTxt
            // 
            this.bisectionErrorTxt.Location = new System.Drawing.Point(9, 102);
            this.bisectionErrorTxt.Name = "bisectionErrorTxt";
            this.bisectionErrorTxt.Size = new System.Drawing.Size(51, 20);
            this.bisectionErrorTxt.TabIndex = 9;
            this.bisectionErrorTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.bisectionErrorTxt_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Error:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 30);
            this.button1.TabIndex = 11;
            this.button1.Text = "Find Roots";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bisectionGroup
            // 
            this.bisectionGroup.Controls.Add(this.label5);
            this.bisectionGroup.Controls.Add(this.bisectionErrorTxt);
            this.bisectionGroup.Controls.Add(this.bisectionMaxTxt);
            this.bisectionGroup.Controls.Add(this.bisectionMinTxt);
            this.bisectionGroup.Controls.Add(this.label4);
            this.bisectionGroup.Controls.Add(this.label3);
            this.bisectionGroup.Controls.Add(this.label2);
            this.bisectionGroup.Location = new System.Drawing.Point(25, 61);
            this.bisectionGroup.Name = "bisectionGroup";
            this.bisectionGroup.Size = new System.Drawing.Size(164, 146);
            this.bisectionGroup.TabIndex = 12;
            this.bisectionGroup.TabStop = false;
            this.bisectionGroup.Text = "Bisection";
            // 
            // newtonMethod
            // 
            this.newtonMethod.Controls.Add(this.newtonStartMax);
            this.newtonMethod.Controls.Add(this.newronStartMin);
            this.newtonMethod.Controls.Add(this.relativeError);
            this.newtonMethod.Controls.Add(this.label6);
            this.newtonMethod.Controls.Add(this.newtonError);
            this.newtonMethod.Controls.Add(this.newtonMaxTxt);
            this.newtonMethod.Controls.Add(this.newtonMinTxt);
            this.newtonMethod.Controls.Add(this.label7);
            this.newtonMethod.Controls.Add(this.label8);
            this.newtonMethod.Controls.Add(this.label9);
            this.newtonMethod.Location = new System.Drawing.Point(26, 58);
            this.newtonMethod.Name = "newtonMethod";
            this.newtonMethod.Size = new System.Drawing.Size(174, 203);
            this.newtonMethod.TabIndex = 13;
            this.newtonMethod.TabStop = false;
            this.newtonMethod.Text = "Newton Raphson";
            // 
            // newtonStartMax
            // 
            this.newtonStartMax.AutoSize = true;
            this.newtonStartMax.Location = new System.Drawing.Point(54, 100);
            this.newtonStartMax.Name = "newtonStartMax";
            this.newtonStartMax.Size = new System.Drawing.Size(92, 17);
            this.newtonStartMax.TabIndex = 15;
            this.newtonStartMax.Text = "Start from max";
            this.newtonStartMax.UseVisualStyleBackColor = true;
            // 
            // newronStartMin
            // 
            this.newronStartMin.AutoSize = true;
            this.newronStartMin.Checked = true;
            this.newronStartMin.Location = new System.Drawing.Point(54, 57);
            this.newronStartMin.Name = "newronStartMin";
            this.newronStartMin.Size = new System.Drawing.Size(89, 17);
            this.newronStartMin.TabIndex = 14;
            this.newronStartMin.TabStop = true;
            this.newronStartMin.Text = "Start from min";
            this.newronStartMin.UseVisualStyleBackColor = true;
            // 
            // relativeError
            // 
            this.relativeError.AutoSize = true;
            this.relativeError.Location = new System.Drawing.Point(10, 168);
            this.relativeError.Name = "relativeError";
            this.relativeError.Size = new System.Drawing.Size(90, 17);
            this.relativeError.TabIndex = 11;
            this.relativeError.Text = "Relative Error";
            this.relativeError.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Error:";
            // 
            // newtonError
            // 
            this.newtonError.Location = new System.Drawing.Point(10, 147);
            this.newtonError.Name = "newtonError";
            this.newtonError.Size = new System.Drawing.Size(51, 20);
            this.newtonError.TabIndex = 9;
            this.newtonError.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newtonError_KeyPress);
            // 
            // newtonMaxTxt
            // 
            this.newtonMaxTxt.Location = new System.Drawing.Point(9, 100);
            this.newtonMaxTxt.Name = "newtonMaxTxt";
            this.newtonMaxTxt.Size = new System.Drawing.Size(39, 20);
            this.newtonMaxTxt.TabIndex = 8;
            this.newtonMaxTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newtonMaxTxt_KeyPress);
            // 
            // newtonMinTxt
            // 
            this.newtonMinTxt.Location = new System.Drawing.Point(9, 54);
            this.newtonMinTxt.Name = "newtonMinTxt";
            this.newtonMinTxt.Size = new System.Drawing.Size(39, 20);
            this.newtonMinTxt.TabIndex = 7;
            this.newtonMinTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newtonMinTxt_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Max:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Min:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Interval:";
            // 
            // secantGroup
            // 
            this.secantGroup.Controls.Add(this.secantRelative);
            this.secantGroup.Controls.Add(this.label10);
            this.secantGroup.Controls.Add(this.secantError);
            this.secantGroup.Controls.Add(this.secantX1Txt);
            this.secantGroup.Controls.Add(this.secantX0Txt);
            this.secantGroup.Controls.Add(this.label11);
            this.secantGroup.Controls.Add(this.label12);
            this.secantGroup.Location = new System.Drawing.Point(21, 61);
            this.secantGroup.Name = "secantGroup";
            this.secantGroup.Size = new System.Drawing.Size(148, 156);
            this.secantGroup.TabIndex = 16;
            this.secantGroup.TabStop = false;
            this.secantGroup.Text = "Secant";
            // 
            // secantRelative
            // 
            this.secantRelative.AutoSize = true;
            this.secantRelative.Location = new System.Drawing.Point(8, 115);
            this.secantRelative.Name = "secantRelative";
            this.secantRelative.Size = new System.Drawing.Size(90, 17);
            this.secantRelative.TabIndex = 11;
            this.secantRelative.Text = "Relative Error";
            this.secantRelative.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Error:";
            // 
            // secantError
            // 
            this.secantError.Location = new System.Drawing.Point(8, 94);
            this.secantError.Name = "secantError";
            this.secantError.Size = new System.Drawing.Size(51, 20);
            this.secantError.TabIndex = 9;
            this.secantError.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.secantError_KeyPress);
            // 
            // secantX1Txt
            // 
            this.secantX1Txt.Location = new System.Drawing.Point(82, 42);
            this.secantX1Txt.Name = "secantX1Txt";
            this.secantX1Txt.Size = new System.Drawing.Size(39, 20);
            this.secantX1Txt.TabIndex = 8;
            this.secantX1Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.secantX1Txt_KeyPress);
            // 
            // secantX0Txt
            // 
            this.secantX0Txt.Location = new System.Drawing.Point(8, 42);
            this.secantX0Txt.Name = "secantX0Txt";
            this.secantX0Txt.Size = new System.Drawing.Size(39, 20);
            this.secantX0Txt.TabIndex = 7;
            this.secantX0Txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.secantX0Txt_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(79, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "X1:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "X0:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 361);
            this.Controls.Add(this.secantGroup);
            this.Controls.Add(this.newtonMethod);
            this.Controls.Add(this.bisectionGroup);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.secant);
            this.Controls.Add(this.newton);
            this.Controls.Add(this.bisection);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Finding Roots";
            this.bisectionGroup.ResumeLayout(false);
            this.bisectionGroup.PerformLayout();
            this.newtonMethod.ResumeLayout(false);
            this.newtonMethod.PerformLayout();
            this.secantGroup.ResumeLayout(false);
            this.secantGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton bisection;
        private System.Windows.Forms.RadioButton newton;
        private System.Windows.Forms.RadioButton secant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bisectionMinTxt;
        private System.Windows.Forms.TextBox bisectionMaxTxt;
        private System.Windows.Forms.TextBox bisectionErrorTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox bisectionGroup;
        private System.Windows.Forms.GroupBox newtonMethod;
        private System.Windows.Forms.CheckBox relativeError;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox newtonError;
        private System.Windows.Forms.TextBox newtonMaxTxt;
        private System.Windows.Forms.TextBox newtonMinTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton newtonStartMax;
        private System.Windows.Forms.RadioButton newronStartMin;
        private System.Windows.Forms.GroupBox secantGroup;
        private System.Windows.Forms.CheckBox secantRelative;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox secantError;
        private System.Windows.Forms.TextBox secantX1Txt;
        private System.Windows.Forms.TextBox secantX0Txt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

