namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.firstLabel = new System.Windows.Forms.Label();
            this.secondLabel = new System.Windows.Forms.Label();
            this.secondNumber = new System.Windows.Forms.NumericUpDown();
            this.btnReset = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.taghsimBtn = new System.Windows.Forms.Button();
            this.zarbBtn = new System.Windows.Forms.Button();
            this.firstNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.secondNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // firstLabel
            // 
            resources.ApplyResources(this.firstLabel, "firstLabel");
            this.firstLabel.Name = "firstLabel";
            // 
            // secondLabel
            // 
            resources.ApplyResources(this.secondLabel, "secondLabel");
            this.secondLabel.Name = "secondLabel";
            // 
            // secondNumber
            // 
            resources.ApplyResources(this.secondNumber, "secondNumber");
            this.secondNumber.Name = "secondNumber";
            // 
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // plusBtn
            // 
            resources.ApplyResources(this.plusBtn, "plusBtn");
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // minusBtn
            // 
            resources.ApplyResources(this.minusBtn, "minusBtn");
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // taghsimBtn
            // 
            resources.ApplyResources(this.taghsimBtn, "taghsimBtn");
            this.taghsimBtn.Name = "taghsimBtn";
            this.taghsimBtn.UseVisualStyleBackColor = true;
            this.taghsimBtn.Click += new System.EventHandler(this.taghsimBtn_Click);
            // 
            // zarbBtn
            // 
            resources.ApplyResources(this.zarbBtn, "zarbBtn");
            this.zarbBtn.Name = "zarbBtn";
            this.zarbBtn.UseVisualStyleBackColor = true;
            this.zarbBtn.Click += new System.EventHandler(this.zarbBtn_Click);
            // 
            // firstNumber
            // 
            resources.ApplyResources(this.firstNumber, "firstNumber");
            this.firstNumber.Name = "firstNumber";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.firstNumber);
            this.Controls.Add(this.zarbBtn);
            this.Controls.Add(this.taghsimBtn);
            this.Controls.Add(this.minusBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.secondNumber);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.firstLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.secondNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.NumericUpDown secondNumber;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button taghsimBtn;
        private System.Windows.Forms.Button zarbBtn;
        private System.Windows.Forms.NumericUpDown firstNumber;
    }
}

