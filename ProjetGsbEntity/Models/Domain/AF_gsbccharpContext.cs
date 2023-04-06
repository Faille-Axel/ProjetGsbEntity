using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProjetGsbEntity.Models.Domain
{
    public partial class AF_gsbccharpContext : DbContext
    {
        public AF_gsbccharpContext()
        {
        }

        public AF_gsbccharpContext(DbContextOptions<AF_gsbccharpContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActiviteCompl> ActiviteCompl { get; set; }
        public virtual DbSet<Etat> Etat { get; set; }
        public virtual DbSet<Famille> Famille { get; set; }
        public virtual DbSet<Frais> Frais { get; set; }
        public virtual DbSet<Fraisforfait> Fraisforfait { get; set; }
        public virtual DbSet<Fraishorsforfait> Fraishorsforfait { get; set; }
        public virtual DbSet<Laboratoire> Laboratoire { get; set; }
        public virtual DbSet<LigneFraisforfait> LigneFraisforfait { get; set; }
        public virtual DbSet<Medicament> Medicament { get; set; }
        public virtual DbSet<Posseder> Posseder { get; set; }
        public virtual DbSet<Praticien> Praticien { get; set; }
        public virtual DbSet<Prescrire> Prescrire { get; set; }
        public virtual DbSet<Presentation> Presentation { get; set; }
        public virtual DbSet<RapportVisite> RapportVisite { get; set; }
        public virtual DbSet<Realiser> Realiser { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Secteur> Secteur { get; set; }
        public virtual DbSet<Specialite> Specialite { get; set; }
        public virtual DbSet<StatsPrescriptions> StatsPrescriptions { get; set; }
        public virtual DbSet<Travailler> Travailler { get; set; }
        public virtual DbSet<TypeIndividu> TypeIndividu { get; set; }
        public virtual DbSet<TypePraticien> TypePraticien { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Visiteur> Visiteur { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=172.30.32.100;port=3306;user=usersio;password=sio;convert zero datetime=True;database=AF_gsbccharp", x => x.ServerVersion("10.4.11-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActiviteCompl>(entity =>
            {
                entity.HasKey(e => e.IdActiviteCompl)
                    .HasName("PRIMARY");

                entity.ToTable("activite_compl");

                entity.Property(e => e.IdActiviteCompl)
                    .HasColumnName("id_activite_compl")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DateActivite)
                    .HasColumnName("date_activite")
                    .HasColumnType("date");

                entity.Property(e => e.LieuActivite)
                    .HasColumnName("lieu_activite")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MotifActivite)
                    .HasColumnName("motif_activite")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.ThemeActivite)
                    .HasColumnName("theme_activite")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Etat>(entity =>
            {
                entity.HasKey(e => e.IdEtat)
                    .HasName("PRIMARY");

                entity.ToTable("etat");

                entity.Property(e => e.IdEtat)
                    .HasColumnName("id_etat")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LibEtat)
                    .HasColumnName("lib_etat")
                    .HasColumnType("varchar(120)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Famille>(entity =>
            {
                entity.HasKey(e => e.IdFamille)
                    .HasName("PRIMARY");

                entity.ToTable("famille");

                entity.Property(e => e.IdFamille)
                    .HasColumnName("id_famille")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LibFamille)
                    .HasColumnName("lib_famille")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Frais>(entity =>
            {
                entity.HasKey(e => e.IdFrais)
                    .HasName("PRIMARY");

                entity.ToTable("frais");

                entity.HasIndex(e => e.IdEtat)
                    .HasName("fk_frais_etat");

                entity.HasIndex(e => e.IdVisiteur)
                    .HasName("fk_frais_visiteur");

                entity.Property(e => e.IdFrais)
                    .HasColumnName("id_frais")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Anneemois)
                    .IsRequired()
                    .HasColumnName("anneemois")
                    .HasColumnType("char(6)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Datemodification)
                    .HasColumnName("datemodification")
                    .HasColumnType("date");

                entity.Property(e => e.IdEtat)
                    .HasColumnName("id_etat")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdVisiteur)
                    .HasColumnName("id_visiteur")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Montantvalide)
                    .HasColumnName("montantvalide")
                    .HasColumnType("decimal(10,2)");

                entity.Property(e => e.Nbjustificatifs)
                    .HasColumnName("nbjustificatifs")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.IdEtatNavigation)
                    .WithMany(p => p.Frais)
                    .HasForeignKey(d => d.IdEtat)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_frais_etat");

                entity.HasOne(d => d.IdVisiteurNavigation)
                    .WithMany(p => p.Frais)
                    .HasForeignKey(d => d.IdVisiteur)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_frais_visiteur");
            });

            modelBuilder.Entity<Fraisforfait>(entity =>
            {
                entity.HasKey(e => e.IdFraisforfait)
                    .HasName("PRIMARY");

                entity.ToTable("fraisforfait");

                entity.Property(e => e.IdFraisforfait)
                    .HasColumnName("id_fraisforfait")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LibFraisforfait)
                    .HasColumnName("lib_fraisforfait")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MontantFraisForfait)
                    .HasColumnName("montant_frais_forfait")
                    .HasColumnType("decimal(5,2)");
            });

            modelBuilder.Entity<Fraishorsforfait>(entity =>
            {
                entity.HasKey(e => e.IdFraishorsforfait)
                    .HasName("PRIMARY");

                entity.ToTable("fraishorsforfait");

                entity.HasIndex(e => e.IdFrais)
                    .HasName("fk_fraishorsforfait_frais");

                entity.Property(e => e.IdFraishorsforfait)
                    .HasColumnName("id_fraishorsforfait")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DateFraishorsforfait)
                    .HasColumnName("date_fraishorsforfait")
                    .HasColumnType("date");

                entity.Property(e => e.IdFrais)
                    .HasColumnName("id_frais")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LibFraishorsforfait)
                    .HasColumnName("lib_fraishorsforfait")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.MontantFraishorsforfait)
                    .HasColumnName("montant_fraishorsforfait")
                    .HasColumnType("decimal(10,2)");

                entity.HasOne(d => d.IdFraisNavigation)
                    .WithMany(p => p.Fraishorsforfait)
                    .HasForeignKey(d => d.IdFrais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_fraishorsforfait_frais");
            });

            modelBuilder.Entity<Laboratoire>(entity =>
            {
                entity.HasKey(e => e.IdLaboratoire)
                    .HasName("PRIMARY");

                entity.ToTable("laboratoire");

                entity.Property(e => e.IdLaboratoire)
                    .HasColumnName("id_laboratoire")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ChefVente)
                    .HasColumnName("chef_vente")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NomLaboratoire)
                    .HasColumnName("nom_laboratoire")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<LigneFraisforfait>(entity =>
            {
                entity.HasKey(e => new { e.IdFrais, e.IdFraisforfait })
                    .HasName("PRIMARY");

                entity.ToTable("ligne_fraisforfait");

                entity.HasIndex(e => e.IdFraisforfait)
                    .HasName("fk_ligne_fraisforfait");

                entity.Property(e => e.IdFrais)
                    .HasColumnName("id_frais")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdFraisforfait)
                    .HasColumnName("id_fraisforfait")
                    .HasColumnType("int(11)");

                entity.Property(e => e.QuantiteLigne)
                    .HasColumnName("quantite_ligne")
                    .HasColumnType("int(11)");

                entity.HasOne(d => d.IdFraisNavigation)
                    .WithMany(p => p.LigneFraisforfait)
                    .HasForeignKey(d => d.IdFrais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ligne_frais");

                entity.HasOne(d => d.IdFraisforfaitNavigation)
                    .WithMany(p => p.LigneFraisforfait)
                    .HasForeignKey(d => d.IdFraisforfait)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ligne_fraisforfait");
            });

            modelBuilder.Entity<Medicament>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("medicament");

                entity.Property(e => e.ContreIndication)
                    .HasColumnName("contre_indication")
                    .HasColumnType("char(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DepotLegal)
                    .HasColumnName("depot_legal")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Effets)
                    .HasColumnName("effets")
                    .HasColumnType("varchar(512)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdFamille)
                    .HasColumnName("id_famille")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdMedicament)
                    .HasColumnName("id_medicament")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NomCommercial)
                    .HasColumnName("nom_commercial")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PrixEchantillon)
                    .HasColumnName("prix_echantillon")
                    .HasColumnType("decimal(11,2)");
            });

            modelBuilder.Entity<Posseder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("posseder");

                entity.Property(e => e.CoefPrescription)
                    .HasColumnName("coef_prescription")
                    .HasColumnType("decimal(11,2)");

                entity.Property(e => e.Diplome)
                    .HasColumnName("diplome")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdPraticien)
                    .HasColumnName("id_praticien")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdSpecialite)
                    .HasColumnName("id_specialite")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Praticien>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("praticien");

                entity.Property(e => e.AdressePraticien)
                    .HasColumnName("adresse_praticien")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CoefNotoriete)
                    .HasColumnName("coef_notoriete")
                    .HasColumnType("decimal(11,2)");

                entity.Property(e => e.CpPraticien)
                    .HasColumnName("cp_praticien")
                    .HasColumnType("char(5)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdPraticien)
                    .HasColumnName("id_praticien")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdTypePraticien)
                    .HasColumnName("id_type_praticien")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NomPraticien)
                    .HasColumnName("nom_praticien")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PrenomPraticien)
                    .HasColumnName("prenom_praticien")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VillePraticien)
                    .HasColumnName("ville_praticien")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Prescrire>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("prescrire");

                entity.Property(e => e.IdDosage)
                    .HasColumnName("id_dosage")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdMedicament)
                    .HasColumnName("id_medicament")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdTypeIndividu)
                    .HasColumnName("id_type_individu")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Posologie)
                    .HasColumnName("posologie")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Presentation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("presentation");

                entity.Property(e => e.IdPresentation)
                    .HasColumnName("id_presentation")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LibPresentation)
                    .HasColumnName("lib_presentation")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<RapportVisite>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("rapport_visite");

                entity.Property(e => e.Bilan)
                    .HasColumnName("bilan")
                    .HasColumnType("varchar(512)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DateRapport)
                    .HasColumnName("date_rapport")
                    .HasColumnType("date");

                entity.Property(e => e.IdPraticien)
                    .HasColumnName("id_praticien")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdRapport)
                    .HasColumnName("id_rapport")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdVisiteur)
                    .HasColumnName("id_visiteur")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Motif)
                    .HasColumnName("motif")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Realiser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("realiser");

                entity.Property(e => e.IdActiviteCompl)
                    .HasColumnName("id_activite_compl")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdVisiteur)
                    .HasColumnName("id_visiteur")
                    .HasColumnType("int(11)");

                entity.Property(e => e.MontantAc)
                    .HasColumnName("montant_ac")
                    .HasColumnType("decimal(11,2)");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("region");

                entity.Property(e => e.IdRegion)
                    .HasColumnName("id_region")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdSecteur)
                    .HasColumnName("id_secteur")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NomRegion)
                    .HasColumnName("nom_region")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Secteur>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("secteur");

                entity.Property(e => e.IdSecteur)
                    .HasColumnName("id_secteur")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LibSecteur)
                    .HasColumnName("lib_secteur")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Specialite>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("specialite");

                entity.Property(e => e.IdSpecialite)
                    .HasColumnName("id_specialite")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LibSpecialite)
                    .HasColumnName("lib_specialite")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<StatsPrescriptions>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("stats_prescriptions");

                entity.Property(e => e.AnneeMois)
                    .HasColumnName("annee_mois")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdMedicament)
                    .HasColumnName("id_medicament")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdPraticien)
                    .HasColumnName("id_praticien")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Quantite)
                    .HasColumnName("quantite")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<Travailler>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("travailler");

                entity.Property(e => e.IdRegion)
                    .HasColumnName("id_region")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdVisiteur)
                    .HasColumnName("id_visiteur")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Jjmmaa)
                    .HasColumnName("jjmmaa")
                    .HasColumnType("date");

                entity.Property(e => e.RoleVisiteur)
                    .HasColumnName("role_visiteur")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TypeIndividu>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("type_individu");

                entity.Property(e => e.IdTypeIndividu)
                    .HasColumnName("id_type_individu")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LibTypeIndividu)
                    .HasColumnName("lib_type_individu")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<TypePraticien>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("type_praticien");

                entity.Property(e => e.IdTypePraticien)
                    .HasColumnName("id_type_praticien")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LibTypePraticien)
                    .HasColumnName("lib_type_praticien")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.LieuTypePraticien)
                    .HasColumnName("lieu_type_praticien")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.IdVisiteur)
                    .HasName("fk_user_visiteur");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdVisiteur)
                    .HasColumnName("id_visiteur")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LastUpdate)
                    .HasColumnName("last_update")
                    .HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasColumnType("varchar(20)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PwdUser)
                    .IsRequired()
                    .HasColumnName("pwd_user")
                    .HasColumnType("varchar(250)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.Role)
                    .HasColumnName("role")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.UserUpdate)
                    .HasColumnName("user_update")
                    .HasColumnType("date");

                entity.HasOne(d => d.IdVisiteurNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.IdVisiteur)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_user_visiteur");
            });

            modelBuilder.Entity<Visiteur>(entity =>
            {
                entity.HasKey(e => e.IdVisiteur)
                    .HasName("PRIMARY");

                entity.ToTable("visiteur");

                entity.HasIndex(e => e.Email)
                    .HasName("uniq_email")
                    .IsUnique();

                entity.HasIndex(e => e.IdLaboratoire)
                    .HasName("fk_visiteur_laboratoire");

                entity.HasIndex(e => e.IdSecteur)
                    .HasName("fk_visiteur_secteur");

                entity.Property(e => e.IdVisiteur)
                    .HasColumnName("id_visiteur")
                    .HasColumnType("int(11)");

                entity.Property(e => e.AdresseVisiteur)
                    .HasColumnName("adresse_visiteur")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.CpVisiteur)
                    .HasColumnName("cp_visiteur")
                    .HasColumnType("char(5)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.DateEmbauche)
                    .HasColumnName("date_embauche")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.IdLaboratoire)
                    .HasColumnName("id_laboratoire")
                    .HasColumnType("int(11)");

                entity.Property(e => e.IdSecteur)
                    .HasColumnName("id_secteur")
                    .HasColumnType("int(11)");

                entity.Property(e => e.LoginVisiteur)
                    .HasColumnName("login_visiteur")
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.NomVisiteur)
                    .HasColumnName("nom_visiteur")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PrenomVisiteur)
                    .HasColumnName("prenom_visiteur")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PwdVisiteur)
                    .HasColumnName("pwd_visiteur")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.SelVisiteur)
                    .HasColumnName("sel_visiteur")
                    .HasColumnType("varchar(200)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.TypeVisiteur)
                    .HasColumnName("type_visiteur")
                    .HasColumnType("char(1)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.VilleVisiteur)
                    .HasColumnName("ville_visiteur")
                    .HasColumnType("varchar(100)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.HasOne(d => d.IdLaboratoireNavigation)
                    .WithMany(p => p.Visiteur)
                    .HasForeignKey(d => d.IdLaboratoire)
                    .HasConstraintName("fk_visiteur_laboratoire");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
