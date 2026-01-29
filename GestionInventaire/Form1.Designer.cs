namespace GestionInventaire
{
	partial class FormProduits
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
			this.dgvProduits = new System.Windows.Forms.DataGridView();
			this.btnCharger = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNom = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPrix = new System.Windows.Forms.TextBox();
			this.txtQuantite = new System.Windows.Forms.TextBox();
			this.btnAjouter = new System.Windows.Forms.Button();
			this.btnSupprimer = new System.Windows.Forms.Button();
			this.btnModifier = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvProduits
			// 
			this.dgvProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvProduits.Location = new System.Drawing.Point(423, 12);
			this.dgvProduits.Name = "dgvProduits";
			this.dgvProduits.Size = new System.Drawing.Size(275, 194);
			this.dgvProduits.TabIndex = 0;
			// 
			// btnCharger
			// 
			this.btnCharger.Location = new System.Drawing.Point(423, 288);
			this.btnCharger.Name = "btnCharger";
			this.btnCharger.Size = new System.Drawing.Size(275, 23);
			this.btnCharger.TabIndex = 1;
			this.btnCharger.Text = "Charger";
			this.btnCharger.UseVisualStyleBackColor = true;
			this.btnCharger.Click += new System.EventHandler(this.btnCharger_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Nom";
			// 
			// txtNom
			// 
			this.txtNom.Location = new System.Drawing.Point(98, 28);
			this.txtNom.Name = "txtNom";
			this.txtNom.Size = new System.Drawing.Size(100, 20);
			this.txtNom.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 66);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Quantite";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(21, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(24, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Prix";
			// 
			// txtPrix
			// 
			this.txtPrix.Location = new System.Drawing.Point(98, 97);
			this.txtPrix.Name = "txtPrix";
			this.txtPrix.Size = new System.Drawing.Size(100, 20);
			this.txtPrix.TabIndex = 6;
			// 
			// txtQuantite
			// 
			this.txtQuantite.Location = new System.Drawing.Point(98, 59);
			this.txtQuantite.Name = "txtQuantite";
			this.txtQuantite.Size = new System.Drawing.Size(100, 20);
			this.txtQuantite.TabIndex = 7;
			// 
			// btnAjouter
			// 
			this.btnAjouter.Location = new System.Drawing.Point(24, 151);
			this.btnAjouter.Name = "btnAjouter";
			this.btnAjouter.Size = new System.Drawing.Size(174, 23);
			this.btnAjouter.TabIndex = 8;
			this.btnAjouter.Text = "Ajouter";
			this.btnAjouter.UseVisualStyleBackColor = true;
			this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click_1);
			// 
			// btnSupprimer
			// 
			this.btnSupprimer.Location = new System.Drawing.Point(24, 182);
			this.btnSupprimer.Name = "btnSupprimer";
			this.btnSupprimer.Size = new System.Drawing.Size(174, 23);
			this.btnSupprimer.TabIndex = 9;
			this.btnSupprimer.Text = "Supprimer";
			this.btnSupprimer.UseVisualStyleBackColor = true;
			this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
			// 
			// btnModifier
			// 
			this.btnModifier.Location = new System.Drawing.Point(24, 226);
			this.btnModifier.Name = "btnModifier";
			this.btnModifier.Size = new System.Drawing.Size(174, 23);
			this.btnModifier.TabIndex = 10;
			this.btnModifier.Text = "Modifier";
			this.btnModifier.UseVisualStyleBackColor = true;
			this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
			// 
			// FormProduits
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnModifier);
			this.Controls.Add(this.btnSupprimer);
			this.Controls.Add(this.btnAjouter);
			this.Controls.Add(this.txtQuantite);
			this.Controls.Add(this.txtPrix);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtNom);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnCharger);
			this.Controls.Add(this.dgvProduits);
			this.Name = "FormProduits";
			this.Text = "Gestion d\'inventaire";
			((System.ComponentModel.ISupportInitialize)(this.dgvProduits)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvProduits;
		private System.Windows.Forms.Button btnCharger;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtNom;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPrix;
		private System.Windows.Forms.TextBox txtQuantite;
		private System.Windows.Forms.Button btnAjouter;
		private System.Windows.Forms.Button btnSupprimer;
		private System.Windows.Forms.Button btnModifier;
	}
}

