
namespace PetShopForms
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblUserType = new System.Windows.Forms.Label();
            this.pRenderBody = new System.Windows.Forms.Panel();
            this.pMenu = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
<<<<<<< HEAD
<<<<<<< HEAD
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
=======
>>>>>>> parent of 1830c94 (Correccion del parcial, falta solucionar problema en ventas)
            this.lblWelcome.Font = new System.Drawing.Font("Roboto Thin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(12, 16);
=======
            this.lblWelcome.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.Location = new System.Drawing.Point(12, 8);
>>>>>>> parent of 6339477 (Commit final, falta ventas, faltan validaciones)
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(94, 19);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Bienvenido, ";
            // 
            // lblUserType
            // 
            this.lblUserType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUserType.Location = new System.Drawing.Point(630, 20);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(177, 14);
            this.lblUserType.TabIndex = 1;
            this.lblUserType.Text = "UserType";
            this.lblUserType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pRenderBody
            // 
            this.pRenderBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
<<<<<<< HEAD
<<<<<<< HEAD
            this.pRenderBody.BackColor = System.Drawing.Color.Transparent;
            this.pRenderBody.ForeColor = System.Drawing.Color.Black;
            this.pRenderBody.Location = new System.Drawing.Point(152, 124);
=======
            this.pRenderBody.Location = new System.Drawing.Point(152, 52);
>>>>>>> parent of 6339477 (Commit final, falta ventas, faltan validaciones)
=======
            this.pRenderBody.BackColor = System.Drawing.Color.White;
            this.pRenderBody.ForeColor = System.Drawing.Color.Black;
            this.pRenderBody.Location = new System.Drawing.Point(152, 52);
>>>>>>> parent of 1830c94 (Correccion del parcial, falta solucionar problema en ventas)
            this.pRenderBody.Name = "pRenderBody";
            this.pRenderBody.Size = new System.Drawing.Size(685, 401);
            this.pRenderBody.TabIndex = 8;
            // 
            // pMenu
            // 
            this.pMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pMenu.AutoSize = true;
            this.pMenu.BackColor = System.Drawing.Color.Transparent;
            this.pMenu.Location = new System.Drawing.Point(12, 52);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(134, 401);
            this.pMenu.TabIndex = 9;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(813, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 30);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.BackColor = System.Drawing.Color.Indigo;
<<<<<<< HEAD
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(849, 620);
=======
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(849, 465);
>>>>>>> parent of 6339477 (Commit final, falta ventas, faltan validaciones)
=======
            this.ClientSize = new System.Drawing.Size(849, 465);
>>>>>>> parent of 1830c94 (Correccion del parcial, falta solucionar problema en ventas)
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.pRenderBody);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.lblWelcome);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de gestion de PetShop";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblUserType;
        private System.Windows.Forms.Panel pRenderBody;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Button btnClose;
    }
}

