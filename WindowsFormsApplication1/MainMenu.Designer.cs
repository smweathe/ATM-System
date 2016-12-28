namespace atmsystem
{
    partial class MainMenu
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
            this.btnbalance = new System.Windows.Forms.Button();
            this.btnwithdraw = new System.Windows.Forms.Button();
            this.btndep = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbalance
            // 
            this.btnbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbalance.Location = new System.Drawing.Point(24, 201);
            this.btnbalance.Name = "btnbalance";
            this.btnbalance.Size = new System.Drawing.Size(183, 44);
            this.btnbalance.TabIndex = 0;
            this.btnbalance.Text = "Check Balance";
            this.btnbalance.UseVisualStyleBackColor = true;
            this.btnbalance.Click += new System.EventHandler(this.btnbalance_Click);
            // 
            // btnwithdraw
            // 
            this.btnwithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnwithdraw.Location = new System.Drawing.Point(24, 121);
            this.btnwithdraw.Name = "btnwithdraw";
            this.btnwithdraw.Size = new System.Drawing.Size(183, 44);
            this.btnwithdraw.TabIndex = 1;
            this.btnwithdraw.Text = "Withdraw";
            this.btnwithdraw.UseVisualStyleBackColor = true;
            this.btnwithdraw.Click += new System.EventHandler(this.btnwithdraw_Click);
            // 
            // btndep
            // 
            this.btndep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndep.Location = new System.Drawing.Point(240, 121);
            this.btndep.Name = "btndep";
            this.btndep.Size = new System.Drawing.Size(183, 44);
            this.btndep.TabIndex = 2;
            this.btndep.Text = "Deposit";
            this.btndep.UseVisualStyleBackColor = true;
            this.btndep.Click += new System.EventHandler(this.btndep_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(240, 201);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(183, 44);
            this.btnupdate.TabIndex = 3;
            this.btnupdate.Text = "Update Acc. Details";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(150, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(350, 26);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(100, 35);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 300);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btndep);
            this.Controls.Add(this.btnwithdraw);
            this.Controls.Add(this.btnbalance);
            this.Name = "MainMenu";
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbalance;
        private System.Windows.Forms.Button btnwithdraw;
        private System.Windows.Forms.Button btndep;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
    }
}