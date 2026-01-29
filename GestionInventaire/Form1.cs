using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GestionInventaire
{
	public partial class FormProduits : Form
	{

		private int idSelectionne = -1;

		private string connectionString =
	@"Data Source=(LocalDB)\MSSQLLocalDB;
      AttachDbFilename=C:\IMPLEMENTATION\GestionInventaire\GestionInventaire\GestionInventaireDB.mdf;
      Integrated Security=True";


		public FormProduits()
		{
			InitializeComponent();
		}

		private void btnCharger_Click(object sender, EventArgs e)
		{
			ChargerProduits();
		}

		// Méthode simple pour charger les données dans le DataGridView
		private void ChargerProduits()
		{
			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					string query = "SELECT Id, Nom, Quantite, Prix FROM Produits";
					SqlDataAdapter da = new SqlDataAdapter(query, conn);

					DataTable dt = new DataTable();
					da.Fill(dt);

					dgvProduits.DataSource = dt;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erreur: " + ex.Message);
			}
		}

		private void btnAjouter_Click(object sender, EventArgs e)
		{

		}

		private void btnAjouter_Click_1(object sender, EventArgs e)
		{
			// Validation simple (niveau CEGEP)
			if (txtNom.Text.Trim() == "")
			{
				MessageBox.Show("Veuillez entrer un nom.");
				return;
			}

			int quantite;
			decimal prix;

			if (!int.TryParse(txtQuantite.Text.Trim(), out quantite))
			{
				MessageBox.Show("Quantité invalide (entrez un nombre).");
				return;
			}

			if (!decimal.TryParse(txtPrix.Text.Trim(), out prix))
			{
				MessageBox.Show("Prix invalide (ex: 9.99).");
				return;
			}

			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					string query = "INSERT INTO Produits (Nom, Quantite, Prix) VALUES (@Nom, @Quantite, @Prix)";
					SqlCommand cmd = new SqlCommand(query, conn);

					cmd.Parameters.AddWithValue("@Nom", txtNom.Text.Trim());
					cmd.Parameters.AddWithValue("@Quantite", quantite);
					cmd.Parameters.AddWithValue("@Prix", prix);

					conn.Open();
					cmd.ExecuteNonQuery();
				}

				MessageBox.Show("Produit ajouté !");
				ViderChamps();
				ChargerProduits(); // refresh
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erreur: " + ex.Message);
			}
		}

		// Méthode pour vider les champs après ajout
		private void ViderChamps()
		{
			txtNom.Text = "";
			txtQuantite.Text = "";
			txtPrix.Text = "";
			txtNom.Focus();
		}

		private void btnSupprimer_Click(object sender, EventArgs e)
		{
			if (dgvProduits.CurrentRow == null)
			{
				MessageBox.Show("Veuillez sélectionner un produit.");
				return;
			}

			int id = Convert.ToInt32(dgvProduits.CurrentRow.Cells["Id"].Value);

			DialogResult rep = MessageBox.Show(
				"Voulez-vous vraiment supprimer ce produit ?",
				"Confirmation",
				MessageBoxButtons.YesNo
			);

			if (rep == DialogResult.No)
				return;

			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					string query = "DELETE FROM Produits WHERE Id = @Id";
					SqlCommand cmd = new SqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@Id", id);

					conn.Open();
					cmd.ExecuteNonQuery();
				}

				MessageBox.Show("Produit supprimé !");
				ChargerProduits();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erreur: " + ex.Message);
			}
		}

		private void btnModifier_Click(object sender, EventArgs e)
		{
			if (idSelectionne == -1)
			{
				MessageBox.Show("Veuillez sélectionner un produit à modifier.");
				return;
			}

			if (txtNom.Text.Trim() == "")
			{
				MessageBox.Show("Veuillez entrer un nom.");
				return;
			}

			int quantite;
			decimal prix;

			if (!int.TryParse(txtQuantite.Text.Trim(), out quantite))
			{
				MessageBox.Show("Quantité invalide.");
				return;
			}

			if (!decimal.TryParse(txtPrix.Text.Trim(), out prix))
			{
				MessageBox.Show("Prix invalide (ex: 9.99).");
				return;
			}

			try
			{
				using (SqlConnection conn = new SqlConnection(connectionString))
				{
					string query = @"UPDATE Produits
                             SET Nom=@Nom, Quantite=@Quantite, Prix=@Prix
                             WHERE Id=@Id";

					SqlCommand cmd = new SqlCommand(query, conn);
					cmd.Parameters.AddWithValue("@Nom", txtNom.Text.Trim());
					cmd.Parameters.AddWithValue("@Quantite", quantite);
					cmd.Parameters.AddWithValue("@Prix", prix);
					cmd.Parameters.AddWithValue("@Id", idSelectionne);

					conn.Open();
					cmd.ExecuteNonQuery();
				}

				MessageBox.Show("Produit modifié !");
				ChargerProduits();
				ViderChamps();
				idSelectionne = -1;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Erreur: " + ex.Message);
			}
		}
	}
}
