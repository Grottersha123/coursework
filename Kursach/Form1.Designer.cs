using System.Collections.Generic;
namespace Kursach
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        int a,c;
        string b;
        int count;
        //bool sign;
        public static string Arabic_Parse(int  arabic)
        {
            
            Dictionary<int, string> lookup = new Dictionary<int, string>();
            lookup.Add(1000, "M");
            lookup.Add(900, "CM");
            lookup.Add(100, "C");
            lookup.Add(90, "XC");
            lookup.Add(50, "L");
            lookup.Add(40, "XL");
            lookup.Add(10, "X");
            lookup.Add(9, "IX");
            lookup.Add(5, "V");
            lookup.Add(4, "IV");
            lookup.Add(1, "I");
            string S = "";
            Dictionary<int, string>.KeyCollection keyColl =
            lookup.Keys;
            int[] ke = new int[11] { 1000, 900, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            for (int i = 0; i < 11; i++)
            {
                while ((arabic / ke[i]) != 0)
                {
                    S += lookup[ke[i]];
                    arabic -= ke[i];
                }

            }
            return S;
        }
        public void calculate()
        {
            switch(count)
            {
                case 1:
                    c = Roman_Parse(textBox3.Text) + a;
                    textBox3.Text = Arabic_Parse(c);
                    break;
                case 2:
                    c = -Roman_Parse(textBox3.Text) + a;
                    textBox3.Text = Arabic_Parse(c);
                    break;
                case 3:
                    c = Roman_Parse(textBox3.Text) * a;
                    textBox3.Text = Arabic_Parse(c);
                    break;
                case 4:
                    c = a / Roman_Parse(textBox3.Text);
                    textBox3.Text = Arabic_Parse(c);
                    break;



            }
        }

        public int Roman_Parse(string roman)
        {
            Dictionary<char, short> lookup = new Dictionary<char, short>();
            lookup.Add('M', 1000);
            lookup.Add('C', 100);
            lookup.Add('L', 50);
            lookup.Add('X', 10);
            lookup.Add('V', 5);
            lookup.Add('I', 1);
            lookup.Add('m', 1000);
            lookup.Add('c', 100);
            lookup.Add('l', 50);
            lookup.Add('x', 10);
            lookup.Add('v', 5);
            lookup.Add('i', 1);

            int arabic = 0;
            
            for (int i = 0; i < roman.Length; i++)
            {
                //
                // return 0 if not valid roman numeral
                //
                if (!lookup.ContainsKey(roman[i]))
                    return 0;

                if (i == roman.Length - 1)
                {
                    arabic += lookup[roman[i]];
                }
                else
                {
                    if (lookup[roman[i + 1]] > lookup[roman[i]]) arabic -= lookup[roman[i]];
                    else arabic += lookup[roman[i]];
                }
            }
            
            return arabic;
        }
        
        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonI = new System.Windows.Forms.Button();
            this.buttonX = new System.Windows.Forms.Button();
            this.buttonV = new System.Windows.Forms.Button();
            this.buttonL = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonM = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonMulti = new System.Windows.Forms.Button();
            this.buttonDevide = new System.Windows.Forms.Button();
            this.buttonEqually = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Перевести из римской в арабскую";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(361, 90);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(361, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(204, 22);
            this.textBox2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(126, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(152, 84);
            this.button2.TabIndex = 3;
            this.button2.Text = "Перевести из арабской в римскую";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonI
            // 
            this.buttonI.Location = new System.Drawing.Point(101, 257);
            this.buttonI.Name = "buttonI";
            this.buttonI.Size = new System.Drawing.Size(75, 23);
            this.buttonI.TabIndex = 4;
            this.buttonI.Text = "I";
            this.buttonI.UseVisualStyleBackColor = true;
            this.buttonI.Click += new System.EventHandler(this.buttonI_Click);
            // 
            // buttonX
            // 
            this.buttonX.Location = new System.Drawing.Point(310, 257);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(75, 23);
            this.buttonX.TabIndex = 5;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = true;
            this.buttonX.Click += new System.EventHandler(this.buttonX_Click);
            // 
            // buttonV
            // 
            this.buttonV.Location = new System.Drawing.Point(203, 257);
            this.buttonV.Name = "buttonV";
            this.buttonV.Size = new System.Drawing.Size(75, 23);
            this.buttonV.TabIndex = 6;
            this.buttonV.Text = "V";
            this.buttonV.UseVisualStyleBackColor = true;
            this.buttonV.Click += new System.EventHandler(this.buttonV_Click);
            // 
            // buttonL
            // 
            this.buttonL.Location = new System.Drawing.Point(101, 307);
            this.buttonL.Name = "buttonL";
            this.buttonL.Size = new System.Drawing.Size(75, 23);
            this.buttonL.TabIndex = 7;
            this.buttonL.Text = "L";
            this.buttonL.UseVisualStyleBackColor = true;
            this.buttonL.Click += new System.EventHandler(this.buttonL_Click);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(203, 307);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(75, 23);
            this.buttonC.TabIndex = 8;
            this.buttonC.Text = "С";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonM
            // 
            this.buttonM.Location = new System.Drawing.Point(310, 307);
            this.buttonM.Name = "buttonM";
            this.buttonM.Size = new System.Drawing.Size(75, 23);
            this.buttonM.TabIndex = 9;
            this.buttonM.Text = "M";
            this.buttonM.UseVisualStyleBackColor = true;
            this.buttonM.Click += new System.EventHandler(this.buttonM_Click);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(101, 363);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(75, 23);
            this.buttonPlus.TabIndex = 10;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(203, 363);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(75, 23);
            this.buttonMinus.TabIndex = 11;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // buttonMulti
            // 
            this.buttonMulti.Location = new System.Drawing.Point(310, 363);
            this.buttonMulti.Name = "buttonMulti";
            this.buttonMulti.Size = new System.Drawing.Size(75, 23);
            this.buttonMulti.TabIndex = 12;
            this.buttonMulti.Text = "*";
            this.buttonMulti.UseVisualStyleBackColor = true;
            this.buttonMulti.Click += new System.EventHandler(this.buttonMulti_Click);
            // 
            // buttonDevide
            // 
            this.buttonDevide.Location = new System.Drawing.Point(101, 413);
            this.buttonDevide.Name = "buttonDevide";
            this.buttonDevide.Size = new System.Drawing.Size(75, 23);
            this.buttonDevide.TabIndex = 13;
            this.buttonDevide.Text = "/";
            this.buttonDevide.UseVisualStyleBackColor = true;
            this.buttonDevide.Click += new System.EventHandler(this.buttonDevide_Click);
            // 
            // buttonEqually
            // 
            this.buttonEqually.Location = new System.Drawing.Point(203, 413);
            this.buttonEqually.Name = "buttonEqually";
            this.buttonEqually.Size = new System.Drawing.Size(75, 23);
            this.buttonEqually.TabIndex = 14;
            this.buttonEqually.Text = "=";
            this.buttonEqually.UseVisualStyleBackColor = true;
            this.buttonEqually.Click += new System.EventHandler(this.buttonEqually_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(455, 304);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(224, 22);
            this.textBox3.TabIndex = 16;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(650, 307);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(623, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 44);
            this.button3.TabIndex = 19;
            this.button3.Text = "Сброс результата";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(775, 296);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(178, 44);
            this.button4.TabIndex = 20;
            this.button4.Text = "Сброс результата";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Ваш результат";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(775, 408);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(152, 71);
            this.button5.TabIndex = 22;
            this.button5.Text = "Перевести из арабской в римскую";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(775, 353);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(152, 43);
            this.button6.TabIndex = 21;
            this.button6.Text = "Перевести из римской в арабскую";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 491);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.buttonEqually);
            this.Controls.Add(this.buttonDevide);
            this.Controls.Add(this.buttonMulti);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonM);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonL);
            this.Controls.Add(this.buttonV);
            this.Controls.Add(this.buttonX);
            this.Controls.Add(this.buttonI);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonI;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.Button buttonV;
        private System.Windows.Forms.Button buttonL;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonM;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonMulti;
        private System.Windows.Forms.Button buttonDevide;
        private System.Windows.Forms.Button buttonEqually;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

