namespace TextScape
{
    partial class CreateAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateAccount));
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_pass = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.lbl_Confirm = new System.Windows.Forms.Label();
            this.txt_confirm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(12, 179);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(465, 41);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Create Account";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.BackColor = System.Drawing.Color.Transparent;
            this.lbl_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_user.Location = new System.Drawing.Point(1, 52);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(117, 24);
            this.lbl_user.TabIndex = 1;
            this.lbl_user.Text = "Username: ";
            // 
            // lbl_pass
            // 
            this.lbl_pass.AutoSize = true;
            this.lbl_pass.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pass.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_pass.Location = new System.Drawing.Point(1, 89);
            this.lbl_pass.Name = "lbl_pass";
            this.lbl_pass.Size = new System.Drawing.Size(106, 24);
            this.lbl_pass.TabIndex = 2;
            this.lbl_pass.Text = "Password:";
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(123, 56);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(353, 20);
            this.txt_user.TabIndex = 3;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(123, 93);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(353, 20);
            this.txt_pass.TabIndex = 4;
            // 
            // lbl_Confirm
            // 
            this.lbl_Confirm.AutoSize = true;
            this.lbl_Confirm.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Confirm.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_Confirm.Location = new System.Drawing.Point(1, 127);
            this.lbl_Confirm.Name = "lbl_Confirm";
            this.lbl_Confirm.Size = new System.Drawing.Size(190, 24);
            this.lbl_Confirm.TabIndex = 5;
            this.lbl_Confirm.Text = "Confirm Password: ";
            // 
            // txt_confirm
            // 
            this.txt_confirm.Location = new System.Drawing.Point(186, 132);
            this.txt_confirm.Name = "txt_confirm";
            this.txt_confirm.PasswordChar = '*';
            this.txt_confirm.Size = new System.Drawing.Size(291, 20);
            this.txt_confirm.TabIndex = 6;
            // 
            // CreateAccount
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::TextScape.Properties.Resources.medieval_dungeon_modular_3d_model_low_poly_obj_3ds_fbx_blend_X_mtl;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(488, 246);
            this.Controls.Add(this.txt_confirm);
            this.Controls.Add(this.lbl_Confirm);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.lbl_pass);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.btn_login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateAccount";
            this.Text = "Create Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_pass;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label lbl_Confirm;
        private System.Windows.Forms.TextBox txt_confirm;
    }
}