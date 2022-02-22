
namespace FinalPorto
{
    partial class Form2
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
            this.nama = new System.Windows.Forms.TextBox();
            this.lama = new System.Windows.Forms.TextBox();
            this.tujuan = new System.Windows.Forms.TextBox();
            this.no_hp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tanggal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nama
            // 
            this.nama.Location = new System.Drawing.Point(94, 63);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(158, 20);
            this.nama.TabIndex = 0;
            // 
            // lama
            // 
            this.lama.Location = new System.Drawing.Point(94, 197);
            this.lama.Name = "lama";
            this.lama.Size = new System.Drawing.Size(158, 20);
            this.lama.TabIndex = 1;
            // 
            // tujuan
            // 
            this.tujuan.Location = new System.Drawing.Point(94, 154);
            this.tujuan.Name = "tujuan";
            this.tujuan.Size = new System.Drawing.Size(158, 20);
            this.tujuan.TabIndex = 2;
            // 
            // no_hp
            // 
            this.no_hp.Location = new System.Drawing.Point(94, 110);
            this.no_hp.Name = "no_hp";
            this.no_hp.Size = new System.Drawing.Size(158, 20);
            this.no_hp.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "No HP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tujuan ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(97, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lama Sewa";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(273, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(331, 191);
            this.dataGridView1.TabIndex = 8;
            // 
            // tanggal
            // 
            this.tanggal.Location = new System.Drawing.Point(94, 236);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(158, 20);
            this.tanggal.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tanggal Sewa";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(93, 274);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 32);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(185, 274);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(67, 32);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(94, 312);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(67, 32);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(185, 312);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(67, 32);
            this.btnView.TabIndex = 14;
            this.btnView.Text = "VIEW";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tanggal);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.no_hp);
            this.Controls.Add(this.tujuan);
            this.Controls.Add(this.lama);
            this.Controls.Add(this.nama);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form2";
            this.Text = "x";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.TextBox lama;
        private System.Windows.Forms.TextBox tujuan;
        private System.Windows.Forms.TextBox no_hp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tanggal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnView;
    }
}