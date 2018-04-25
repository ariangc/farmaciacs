namespace Presentation
{
    partial class RegisterClient
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
            this.dniTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.districtTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(59, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registrar Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.label2.Location = new System.Drawing.Point(87, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario: Daniela Argumanis";
            // 
            // dniTextBox
            // 
            this.dniTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.dniTextBox.Location = new System.Drawing.Point(61, 93);
            this.dniTextBox.Name = "dniTextBox";
            this.dniTextBox.Size = new System.Drawing.Size(100, 20);
            this.dniTextBox.TabIndex = 2;
            this.dniTextBox.Text = "DNI";
            this.dniTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            this.dniTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.nameTextBox.Location = new System.Drawing.Point(61, 138);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 3;
            this.nameTextBox.Text = "Nombres";
            this.nameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseClick);
            this.nameTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lastnameTextBox.Location = new System.Drawing.Point(61, 185);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastnameTextBox.TabIndex = 4;
            this.lastnameTextBox.Text = "Apellidos";
            this.lastnameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox3_MouseClick);
            this.lastnameTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // districtTextBox
            // 
            this.districtTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.districtTextBox.Location = new System.Drawing.Point(218, 93);
            this.districtTextBox.Name = "districtTextBox";
            this.districtTextBox.Size = new System.Drawing.Size(100, 20);
            this.districtTextBox.TabIndex = 5;
            this.districtTextBox.Text = "Distrito";
            this.districtTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox4_MouseClick);
            this.districtTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.phoneTextBox.Location = new System.Drawing.Point(218, 138);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 6;
            this.phoneTextBox.Text = "Telefono";
            this.phoneTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox5_MouseClick);
            this.phoneTextBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // emailTextBox
            // 
            this.emailTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.emailTextBox.Location = new System.Drawing.Point(218, 185);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 7;
            this.emailTextBox.Text = "E-mail";
            this.emailTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox6_MouseClick);
            this.emailTextBox.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(146, 236);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 8;
            this.ConfirmButton.Text = "Confirmar";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.AutoSize = true;
            this.ReturnButton.Location = new System.Drawing.Point(13, 268);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(59, 13);
            this.ReturnButton.TabIndex = 9;
            this.ReturnButton.Text = "< Regresar";
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // RegisterClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 293);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.districtTextBox);
            this.Controls.Add(this.lastnameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.dniTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegisterClient";
            this.Text = "RegisterClient";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.RegisterClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dniTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.TextBox districtTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Label ReturnButton;
    }
}