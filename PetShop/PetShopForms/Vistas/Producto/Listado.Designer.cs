﻿
namespace PetShopForms.Vistas.Producto
{
    partial class Listado
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
<<<<<<< HEAD:PetShop/PetShopForms/Vistas/Productos/Listado.Designer.cs
<<<<<<< HEAD:PetShop/PetShopForms/Vistas/Productos/Listado.Designer.cs
=======
            this.dgvProductos = new System.Windows.Forms.DataGridView();
>>>>>>> parent of 1830c94 (Correccion del parcial, falta solucionar problema en ventas):PetShop/PetShopForms/Vistas/Producto/Listado.Designer.cs
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
=======
>>>>>>> parent of 6339477 (Commit final, falta ventas, faltan validaciones):PetShop/PetShopForms/Vistas/Producto/Listado.Designer.cs
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
<<<<<<< HEAD:PetShop/PetShopForms/Vistas/Productos/Listado.Designer.cs
<<<<<<< HEAD:PetShop/PetShopForms/Vistas/Productos/Listado.Designer.cs
            this.label1.Size = new System.Drawing.Size(509, 40);
=======
            this.label1.Size = new System.Drawing.Size(800, 15);
>>>>>>> parent of 1830c94 (Correccion del parcial, falta solucionar problema en ventas):PetShop/PetShopForms/Vistas/Producto/Listado.Designer.cs
            this.label1.TabIndex = 0;
            this.label1.Text = "Listado de Ventas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToOrderColumns = true;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.Location = new System.Drawing.Point(0, 75);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowTemplate.Height = 25;
            this.dgvProductos.Size = new System.Drawing.Size(800, 375);
            this.dgvProductos.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(0, 46);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+ Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(81, 46);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(162, 46);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
=======
            this.label1.Size = new System.Drawing.Size(800, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Listado de Productos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
>>>>>>> parent of 6339477 (Commit final, falta ventas, faltan validaciones):PetShop/PetShopForms/Vistas/Producto/Listado.Designer.cs
            // Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD:PetShop/PetShopForms/Vistas/Productos/Listado.Designer.cs
<<<<<<< HEAD:PetShop/PetShopForms/Vistas/Productos/Listado.Designer.cs
            this.ClientSize = new System.Drawing.Size(529, 420);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
=======
            this.ClientSize = new System.Drawing.Size(800, 450);
>>>>>>> parent of 6339477 (Commit final, falta ventas, faltan validaciones):PetShop/PetShopForms/Vistas/Producto/Listado.Designer.cs
=======
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvProductos);
>>>>>>> parent of 1830c94 (Correccion del parcial, falta solucionar problema en ventas):PetShop/PetShopForms/Vistas/Producto/Listado.Designer.cs
            this.Controls.Add(this.label1);
            this.Name = "Listado";
<<<<<<< HEAD:PetShop/PetShopForms/Vistas/Productos/Listado.Designer.cs
<<<<<<< HEAD:PetShop/PetShopForms/Vistas/Productos/Listado.Designer.cs
            this.Padding = new System.Windows.Forms.Padding(10);
=======
>>>>>>> parent of 1830c94 (Correccion del parcial, falta solucionar problema en ventas):PetShop/PetShopForms/Vistas/Producto/Listado.Designer.cs
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
=======
>>>>>>> parent of 6339477 (Commit final, falta ventas, faltan validaciones):PetShop/PetShopForms/Vistas/Producto/Listado.Designer.cs
            this.Text = "Listado";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
<<<<<<< HEAD:PetShop/PetShopForms/Vistas/Productos/Listado.Designer.cs
<<<<<<< HEAD:PetShop/PetShopForms/Vistas/Productos/Listado.Designer.cs
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvProductos;
=======
>>>>>>> parent of 6339477 (Commit final, falta ventas, faltan validaciones):PetShop/PetShopForms/Vistas/Producto/Listado.Designer.cs
=======
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
>>>>>>> parent of 1830c94 (Correccion del parcial, falta solucionar problema en ventas):PetShop/PetShopForms/Vistas/Producto/Listado.Designer.cs
    }
}