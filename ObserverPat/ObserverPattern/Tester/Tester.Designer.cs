namespace WindowsFormsApplication4
{
    partial class FormTester
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.switch2 = new WindowsFormsApplication4.Component.Switch();
            this.light3 = new WindowsFormsApplication4.Component.Light();
            this.light2 = new WindowsFormsApplication4.Component.Light();
            this.light1 = new WindowsFormsApplication4.Component.Light();
            this.switch1 = new WindowsFormsApplication4.Component.Switch();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Light1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Light2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(176, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Light3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Switch1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(190, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Switch2";
            // 
            // switch2
            // 
            this.switch2.itemState = WindowsFormsApplication4.Component.Status.off;
            this.switch2.Location = new System.Drawing.Point(148, 31);
            this.switch2.Name = "switch2";
            this.switch2.Size = new System.Drawing.Size(130, 40);
            this.switch2.TabIndex = 4;
            this.switch2.Text = "switch2";
            // 
            // light3
            // 
            this.light3.itemState = WindowsFormsApplication4.Component.Status.off;
            this.light3.Location = new System.Drawing.Point(179, 110);
            this.light3.Name = "light3";
            this.light3.Size = new System.Drawing.Size(50, 70);
            this.light3.TabIndex = 3;
            this.light3.Text = "light3";
            // 
            // light2
            // 
            this.light2.itemState = WindowsFormsApplication4.Component.Status.off;
            this.light2.Location = new System.Drawing.Point(123, 110);
            this.light2.Name = "light2";
            this.light2.Size = new System.Drawing.Size(50, 70);
            this.light2.TabIndex = 2;
            this.light2.Text = "light2";
            // 
            // light1
            // 
            this.light1.itemState = WindowsFormsApplication4.Component.Status.off;
            this.light1.Location = new System.Drawing.Point(67, 110);
            this.light1.Name = "light1";
            this.light1.Size = new System.Drawing.Size(50, 70);
            this.light1.TabIndex = 1;
            this.light1.Text = "light1";
            // 
            // switch1
            // 
            this.switch1.itemState = WindowsFormsApplication4.Component.Status.off;
            this.switch1.Location = new System.Drawing.Point(12, 31);
            this.switch1.Name = "switch1";
            this.switch1.Size = new System.Drawing.Size(130, 40);
            this.switch1.TabIndex = 0;
            this.switch1.Text = "switch1";
            // 
            // FormTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 263);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.switch2);
            this.Controls.Add(this.light3);
            this.Controls.Add(this.light2);
            this.Controls.Add(this.light1);
            this.Controls.Add(this.switch1);
            this.Name = "FormTester";
            this.Text = "ObserverTestEnVironment";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Component.Switch switch1;
        private Component.Light light1;
        private Component.Light light2;
        private Component.Light light3;
        private Component.Switch switch2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
















    }
}

