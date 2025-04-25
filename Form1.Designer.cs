namespace computer
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.text = new System.Windows.Forms.TextBox();
            this.AC = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.two = new System.Windows.Forms.Button();
            this.three = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.ninus = new System.Windows.Forms.Button();
            this.six = new System.Windows.Forms.Button();
            this.five = new System.Windows.Forms.Button();
            this.four = new System.Windows.Forms.Button();
            this.seven = new System.Windows.Forms.Button();
            this.eight = new System.Windows.Forms.Button();
            this.nine = new System.Windows.Forms.Button();
            this.dot = new System.Windows.Forms.Button();
            this.zero = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.divid = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.Font = new System.Drawing.Font("微軟正黑體", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.text.Location = new System.Drawing.Point(120, 58);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(549, 70);
            this.text.TabIndex = 0;
            this.text.Text = "0";
            // 
            // AC
            // 
            this.AC.Font = new System.Drawing.Font("微軟正黑體", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.AC.Location = new System.Drawing.Point(120, 136);
            this.AC.Name = "AC";
            this.AC.Size = new System.Drawing.Size(105, 60);
            this.AC.TabIndex = 1;
            this.AC.Text = "AC";
            this.AC.UseVisualStyleBackColor = true;
            this.AC.Click += new System.EventHandler(this.ac_Click);
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.one.Location = new System.Drawing.Point(231, 136);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(105, 60);
            this.one.TabIndex = 2;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // two
            // 
            this.two.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.two.Location = new System.Drawing.Point(342, 136);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(105, 60);
            this.two.TabIndex = 3;
            this.two.Text = "2";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // three
            // 
            this.three.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.three.Location = new System.Drawing.Point(453, 136);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(105, 60);
            this.three.TabIndex = 4;
            this.three.Text = "3";
            this.three.UseVisualStyleBackColor = true;
            this.three.Click += new System.EventHandler(this.three_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.add.Location = new System.Drawing.Point(564, 136);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(105, 60);
            this.add.TabIndex = 5;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // ninus
            // 
            this.ninus.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ninus.Location = new System.Drawing.Point(564, 202);
            this.ninus.Name = "ninus";
            this.ninus.Size = new System.Drawing.Size(105, 60);
            this.ninus.TabIndex = 6;
            this.ninus.Text = "-";
            this.ninus.UseVisualStyleBackColor = true;
            this.ninus.Click += new System.EventHandler(this.minus_Click);
            // 
            // six
            // 
            this.six.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.six.Location = new System.Drawing.Point(453, 202);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(105, 60);
            this.six.TabIndex = 7;
            this.six.Text = "6";
            this.six.UseVisualStyleBackColor = true;
            this.six.Click += new System.EventHandler(this.six_Click);
            // 
            // five
            // 
            this.five.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.five.Location = new System.Drawing.Point(342, 202);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(105, 60);
            this.five.TabIndex = 8;
            this.five.Text = "5";
            this.five.UseVisualStyleBackColor = true;
            this.five.Click += new System.EventHandler(this.five_Click);
            // 
            // four
            // 
            this.four.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.four.Location = new System.Drawing.Point(231, 202);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(105, 60);
            this.four.TabIndex = 9;
            this.four.Text = "4";
            this.four.UseVisualStyleBackColor = true;
            this.four.Click += new System.EventHandler(this.four_Click);
            // 
            // seven
            // 
            this.seven.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.seven.Location = new System.Drawing.Point(231, 268);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(105, 60);
            this.seven.TabIndex = 10;
            this.seven.Text = "7";
            this.seven.UseVisualStyleBackColor = true;
            this.seven.Click += new System.EventHandler(this.seven_Click);
            // 
            // eight
            // 
            this.eight.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.eight.Location = new System.Drawing.Point(342, 268);
            this.eight.Name = "eight";
            this.eight.Size = new System.Drawing.Size(105, 60);
            this.eight.TabIndex = 11;
            this.eight.Text = "8";
            this.eight.UseVisualStyleBackColor = true;
            this.eight.Click += new System.EventHandler(this.eight_Click);
            // 
            // nine
            // 
            this.nine.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.nine.Location = new System.Drawing.Point(453, 268);
            this.nine.Name = "nine";
            this.nine.Size = new System.Drawing.Size(105, 60);
            this.nine.TabIndex = 12;
            this.nine.Text = "9";
            this.nine.UseVisualStyleBackColor = true;
            this.nine.Click += new System.EventHandler(this.nine_Click);
            // 
            // dot
            // 
            this.dot.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dot.Location = new System.Drawing.Point(231, 334);
            this.dot.Name = "dot";
            this.dot.Size = new System.Drawing.Size(105, 60);
            this.dot.TabIndex = 13;
            this.dot.Text = ".";
            this.dot.UseVisualStyleBackColor = true;
            this.dot.Click += new System.EventHandler(this.dot_Click);
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.zero.Location = new System.Drawing.Point(342, 334);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(105, 60);
            this.zero.TabIndex = 14;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // equal
            // 
            this.equal.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.equal.Location = new System.Drawing.Point(453, 334);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(105, 60);
            this.equal.TabIndex = 15;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // multiply
            // 
            this.multiply.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.multiply.Location = new System.Drawing.Point(564, 268);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(105, 60);
            this.multiply.TabIndex = 16;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // divid
            // 
            this.divid.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.divid.Location = new System.Drawing.Point(564, 334);
            this.divid.Name = "divid";
            this.divid.Size = new System.Drawing.Size(105, 60);
            this.divid.TabIndex = 17;
            this.divid.Text = "/";
            this.divid.UseVisualStyleBackColor = true;
            this.divid.Click += new System.EventHandler(this.divided_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("微軟正黑體", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDelete.Location = new System.Drawing.Point(120, 268);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 60);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "<<";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPercent
            // 
            this.btnPercent.Font = new System.Drawing.Font("微軟正黑體", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPercent.Location = new System.Drawing.Point(120, 334);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(105, 60);
            this.btnPercent.TabIndex = 19;
            this.btnPercent.Text = "%";
            this.btnPercent.UseVisualStyleBackColor = true;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.divid);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.dot);
            this.Controls.Add(this.nine);
            this.Controls.Add(this.eight);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.four);
            this.Controls.Add(this.five);
            this.Controls.Add(this.six);
            this.Controls.Add(this.ninus);
            this.Controls.Add(this.add);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.AC);
            this.Controls.Add(this.text);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.Button AC;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button two;
        private System.Windows.Forms.Button three;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button ninus;
        private System.Windows.Forms.Button six;
        private System.Windows.Forms.Button five;
        private System.Windows.Forms.Button four;
        private System.Windows.Forms.Button seven;
        private System.Windows.Forms.Button eight;
        private System.Windows.Forms.Button nine;
        private System.Windows.Forms.Button dot;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button divid;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPercent;
    }
}

