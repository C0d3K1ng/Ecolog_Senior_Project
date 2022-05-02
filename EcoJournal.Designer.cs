
namespace Ecolog
{
    partial class EcoJournal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcoJournal));
            this.dietGroupBox = new System.Windows.Forms.GroupBox();
            this.omnivoreRB = new System.Windows.Forms.RadioButton();
            this.pesectarianRB = new System.Windows.Forms.RadioButton();
            this.vegetarianRB = new System.Windows.Forms.RadioButton();
            this.veganRB = new System.Windows.Forms.RadioButton();
            this.dietLbl = new System.Windows.Forms.Label();
            this.recycleGroupBox = new System.Windows.Forms.GroupBox();
            this.metalTextBox = new System.Windows.Forms.TextBox();
            this.metalLbl = new System.Windows.Forms.Label();
            this.plasticTextBox = new System.Windows.Forms.TextBox();
            this.plasticLbl = new System.Windows.Forms.Label();
            this.glasstextBox = new System.Windows.Forms.TextBox();
            this.glassLbl = new System.Windows.Forms.Label();
            this.recycleNoRB = new System.Windows.Forms.RadioButton();
            this.recycleYesRB = new System.Windows.Forms.RadioButton();
            this.recycleQuestionLbl = new System.Windows.Forms.Label();
            this.recycleLbl = new System.Windows.Forms.Label();
            this.travelGroupBox = new System.Windows.Forms.GroupBox();
            this.planetextBox = new System.Windows.Forms.TextBox();
            this.planeLbl = new System.Windows.Forms.Label();
            this.electricRB = new System.Windows.Forms.RadioButton();
            this.gasCarRB = new System.Windows.Forms.RadioButton();
            this.carTypeLabel = new System.Windows.Forms.Label();
            this.driveTextBox = new System.Windows.Forms.TextBox();
            this.driveLbl = new System.Windows.Forms.Label();
            this.biketextBox = new System.Windows.Forms.TextBox();
            this.bikeMiles = new System.Windows.Forms.Label();
            this.walkTextBox = new System.Windows.Forms.TextBox();
            this.walkLbl = new System.Windows.Forms.Label();
            this.homeGroupBox = new System.Windows.Forms.GroupBox();
            this.ebillTextBox = new System.Windows.Forms.TextBox();
            this.energyBillLabel = new System.Windows.Forms.Label();
            this.windHomeRB = new System.Windows.Forms.RadioButton();
            this.solarHomeRB = new System.Windows.Forms.RadioButton();
            this.coalHomeRB = new System.Windows.Forms.RadioButton();
            this.gasHomeRB = new System.Windows.Forms.RadioButton();
            this.homePowerLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.explanationLabel = new System.Windows.Forms.Label();
            this.buttongroupBox = new System.Windows.Forms.GroupBox();
            this.backButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.enterJournalBtn = new System.Windows.Forms.Button();
            this.msgLbl = new System.Windows.Forms.Label();
            this.testTotal = new System.Windows.Forms.Label();
            this.dietGroupBox.SuspendLayout();
            this.recycleGroupBox.SuspendLayout();
            this.travelGroupBox.SuspendLayout();
            this.homeGroupBox.SuspendLayout();
            this.buttongroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // dietGroupBox
            // 
            this.dietGroupBox.BackColor = System.Drawing.Color.LightGreen;
            this.dietGroupBox.Controls.Add(this.omnivoreRB);
            this.dietGroupBox.Controls.Add(this.pesectarianRB);
            this.dietGroupBox.Controls.Add(this.vegetarianRB);
            this.dietGroupBox.Controls.Add(this.veganRB);
            this.dietGroupBox.Controls.Add(this.dietLbl);
            this.dietGroupBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dietGroupBox.Location = new System.Drawing.Point(18, 83);
            this.dietGroupBox.Name = "dietGroupBox";
            this.dietGroupBox.Size = new System.Drawing.Size(388, 159);
            this.dietGroupBox.TabIndex = 0;
            this.dietGroupBox.TabStop = false;
            this.dietGroupBox.Text = "Diet";
            // 
            // omnivoreRB
            // 
            this.omnivoreRB.AutoSize = true;
            this.omnivoreRB.Location = new System.Drawing.Point(6, 117);
            this.omnivoreRB.Name = "omnivoreRB";
            this.omnivoreRB.Size = new System.Drawing.Size(200, 20);
            this.omnivoreRB.TabIndex = 4;
            this.omnivoreRB.Text = "Omnivore (Meat or Everything)";
            this.omnivoreRB.UseVisualStyleBackColor = true;
            // 
            // pesectarianRB
            // 
            this.pesectarianRB.AutoSize = true;
            this.pesectarianRB.Location = new System.Drawing.Point(6, 94);
            this.pesectarianRB.Name = "pesectarianRB";
            this.pesectarianRB.Size = new System.Drawing.Size(210, 20);
            this.pesectarianRB.TabIndex = 3;
            this.pesectarianRB.Text = "Pesectarian (Fish and No Meat)";
            this.pesectarianRB.UseVisualStyleBackColor = true;
            // 
            // vegetarianRB
            // 
            this.vegetarianRB.AutoSize = true;
            this.vegetarianRB.Location = new System.Drawing.Point(6, 71);
            this.vegetarianRB.Name = "vegetarianRB";
            this.vegetarianRB.Size = new System.Drawing.Size(192, 20);
            this.vegetarianRB.TabIndex = 2;
            this.vegetarianRB.Text = "Vegetarian (No Meat or Fish)";
            this.vegetarianRB.UseVisualStyleBackColor = true;
            // 
            // veganRB
            // 
            this.veganRB.AutoSize = true;
            this.veganRB.Checked = true;
            this.veganRB.Location = new System.Drawing.Point(6, 48);
            this.veganRB.Name = "veganRB";
            this.veganRB.Size = new System.Drawing.Size(139, 20);
            this.veganRB.TabIndex = 1;
            this.veganRB.TabStop = true;
            this.veganRB.Text = "Vegan (Just Plants)";
            this.veganRB.UseVisualStyleBackColor = true;
            // 
            // dietLbl
            // 
            this.dietLbl.AutoSize = true;
            this.dietLbl.Location = new System.Drawing.Point(3, 29);
            this.dietLbl.Name = "dietLbl";
            this.dietLbl.Size = new System.Drawing.Size(116, 16);
            this.dietLbl.TabIndex = 0;
            this.dietLbl.Text = "What is your Diet?";
            // 
            // recycleGroupBox
            // 
            this.recycleGroupBox.BackColor = System.Drawing.Color.Yellow;
            this.recycleGroupBox.Controls.Add(this.metalTextBox);
            this.recycleGroupBox.Controls.Add(this.metalLbl);
            this.recycleGroupBox.Controls.Add(this.plasticTextBox);
            this.recycleGroupBox.Controls.Add(this.plasticLbl);
            this.recycleGroupBox.Controls.Add(this.glasstextBox);
            this.recycleGroupBox.Controls.Add(this.glassLbl);
            this.recycleGroupBox.Controls.Add(this.recycleNoRB);
            this.recycleGroupBox.Controls.Add(this.recycleYesRB);
            this.recycleGroupBox.Controls.Add(this.recycleQuestionLbl);
            this.recycleGroupBox.Controls.Add(this.recycleLbl);
            this.recycleGroupBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recycleGroupBox.Location = new System.Drawing.Point(18, 248);
            this.recycleGroupBox.Name = "recycleGroupBox";
            this.recycleGroupBox.Size = new System.Drawing.Size(388, 165);
            this.recycleGroupBox.TabIndex = 1;
            this.recycleGroupBox.TabStop = false;
            this.recycleGroupBox.Text = "Recycling";
            // 
            // metalTextBox
            // 
            this.metalTextBox.Location = new System.Drawing.Point(114, 129);
            this.metalTextBox.Name = "metalTextBox";
            this.metalTextBox.Size = new System.Drawing.Size(100, 22);
            this.metalTextBox.TabIndex = 9;
            // 
            // metalLbl
            // 
            this.metalLbl.AutoSize = true;
            this.metalLbl.Location = new System.Drawing.Point(10, 129);
            this.metalLbl.Name = "metalLbl";
            this.metalLbl.Size = new System.Drawing.Size(82, 16);
            this.metalLbl.TabIndex = 8;
            this.metalLbl.Text = "Metal - Cans";
            // 
            // plasticTextBox
            // 
            this.plasticTextBox.Location = new System.Drawing.Point(114, 102);
            this.plasticTextBox.Name = "plasticTextBox";
            this.plasticTextBox.Size = new System.Drawing.Size(100, 22);
            this.plasticTextBox.TabIndex = 8;
            // 
            // plasticLbl
            // 
            this.plasticLbl.AutoSize = true;
            this.plasticLbl.Location = new System.Drawing.Point(7, 102);
            this.plasticLbl.Name = "plasticLbl";
            this.plasticLbl.Size = new System.Drawing.Size(101, 16);
            this.plasticLbl.TabIndex = 6;
            this.plasticLbl.Text = "Plastic - Bottles";
            // 
            // glasstextBox
            // 
            this.glasstextBox.Location = new System.Drawing.Point(114, 78);
            this.glasstextBox.Name = "glasstextBox";
            this.glasstextBox.Size = new System.Drawing.Size(100, 22);
            this.glasstextBox.TabIndex = 7;
            // 
            // glassLbl
            // 
            this.glassLbl.AutoSize = true;
            this.glassLbl.Location = new System.Drawing.Point(10, 78);
            this.glassLbl.Name = "glassLbl";
            this.glassLbl.Size = new System.Drawing.Size(99, 16);
            this.glassLbl.TabIndex = 4;
            this.glassLbl.Text = "Glass - Bottles ";
            // 
            // recycleNoRB
            // 
            this.recycleNoRB.AutoSize = true;
            this.recycleNoRB.Checked = true;
            this.recycleNoRB.Location = new System.Drawing.Point(164, 61);
            this.recycleNoRB.Name = "recycleNoRB";
            this.recycleNoRB.Size = new System.Drawing.Size(42, 20);
            this.recycleNoRB.TabIndex = 6;
            this.recycleNoRB.TabStop = true;
            this.recycleNoRB.Text = "No";
            this.recycleNoRB.UseVisualStyleBackColor = true;
            // 
            // recycleYesRB
            // 
            this.recycleYesRB.AutoSize = true;
            this.recycleYesRB.Location = new System.Drawing.Point(114, 61);
            this.recycleYesRB.Name = "recycleYesRB";
            this.recycleYesRB.Size = new System.Drawing.Size(48, 20);
            this.recycleYesRB.TabIndex = 5;
            this.recycleYesRB.Text = "Yes";
            this.recycleYesRB.UseVisualStyleBackColor = true;
            // 
            // recycleQuestionLbl
            // 
            this.recycleQuestionLbl.AutoSize = true;
            this.recycleQuestionLbl.Location = new System.Drawing.Point(7, 61);
            this.recycleQuestionLbl.Name = "recycleQuestionLbl";
            this.recycleQuestionLbl.Size = new System.Drawing.Size(105, 16);
            this.recycleQuestionLbl.TabIndex = 1;
            this.recycleQuestionLbl.Text = "Did you recycle?";
            // 
            // recycleLbl
            // 
            this.recycleLbl.AutoSize = true;
            this.recycleLbl.Location = new System.Drawing.Point(10, 20);
            this.recycleLbl.Name = "recycleLbl";
            this.recycleLbl.Size = new System.Drawing.Size(236, 32);
            this.recycleLbl.TabIndex = 0;
            this.recycleLbl.Text = "If you had recycled this week,\r\n please approximate the answers below";
            // 
            // travelGroupBox
            // 
            this.travelGroupBox.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.travelGroupBox.Controls.Add(this.planetextBox);
            this.travelGroupBox.Controls.Add(this.planeLbl);
            this.travelGroupBox.Controls.Add(this.electricRB);
            this.travelGroupBox.Controls.Add(this.gasCarRB);
            this.travelGroupBox.Controls.Add(this.carTypeLabel);
            this.travelGroupBox.Controls.Add(this.driveTextBox);
            this.travelGroupBox.Controls.Add(this.driveLbl);
            this.travelGroupBox.Controls.Add(this.biketextBox);
            this.travelGroupBox.Controls.Add(this.bikeMiles);
            this.travelGroupBox.Controls.Add(this.walkTextBox);
            this.travelGroupBox.Controls.Add(this.walkLbl);
            this.travelGroupBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.travelGroupBox.Location = new System.Drawing.Point(18, 419);
            this.travelGroupBox.Name = "travelGroupBox";
            this.travelGroupBox.Size = new System.Drawing.Size(388, 165);
            this.travelGroupBox.TabIndex = 2;
            this.travelGroupBox.TabStop = false;
            this.travelGroupBox.Text = "Travel";
            // 
            // planetextBox
            // 
            this.planetextBox.Location = new System.Drawing.Point(222, 132);
            this.planetextBox.Name = "planetextBox";
            this.planetextBox.Size = new System.Drawing.Size(100, 22);
            this.planetextBox.TabIndex = 15;
            // 
            // planeLbl
            // 
            this.planeLbl.AutoSize = true;
            this.planeLbl.Location = new System.Drawing.Point(16, 132);
            this.planeLbl.Name = "planeLbl";
            this.planeLbl.Size = new System.Drawing.Size(174, 16);
            this.planeLbl.TabIndex = 9;
            this.planeLbl.Text = "How many miles did you fly?";
            // 
            // electricRB
            // 
            this.electricRB.AutoSize = true;
            this.electricRB.Location = new System.Drawing.Point(275, 106);
            this.electricRB.Name = "electricRB";
            this.electricRB.Size = new System.Drawing.Size(70, 20);
            this.electricRB.TabIndex = 14;
            this.electricRB.Text = "Electric";
            this.electricRB.UseVisualStyleBackColor = true;
            // 
            // gasCarRB
            // 
            this.gasCarRB.AutoSize = true;
            this.gasCarRB.Checked = true;
            this.gasCarRB.Location = new System.Drawing.Point(219, 106);
            this.gasCarRB.Name = "gasCarRB";
            this.gasCarRB.Size = new System.Drawing.Size(50, 20);
            this.gasCarRB.TabIndex = 13;
            this.gasCarRB.TabStop = true;
            this.gasCarRB.Text = "Gas";
            this.gasCarRB.UseVisualStyleBackColor = true;
            // 
            // carTypeLabel
            // 
            this.carTypeLabel.AutoSize = true;
            this.carTypeLabel.Location = new System.Drawing.Point(16, 103);
            this.carTypeLabel.Name = "carTypeLabel";
            this.carTypeLabel.Size = new System.Drawing.Size(184, 16);
            this.carTypeLabel.TabIndex = 6;
            this.carTypeLabel.Text = "What type of car do you drive?";
            // 
            // driveTextBox
            // 
            this.driveTextBox.Location = new System.Drawing.Point(222, 78);
            this.driveTextBox.Name = "driveTextBox";
            this.driveTextBox.Size = new System.Drawing.Size(100, 22);
            this.driveTextBox.TabIndex = 12;
            // 
            // driveLbl
            // 
            this.driveLbl.AutoSize = true;
            this.driveLbl.Location = new System.Drawing.Point(16, 74);
            this.driveLbl.Name = "driveLbl";
            this.driveLbl.Size = new System.Drawing.Size(187, 16);
            this.driveLbl.TabIndex = 4;
            this.driveLbl.Text = "How many miles did you drive?";
            // 
            // biketextBox
            // 
            this.biketextBox.Location = new System.Drawing.Point(222, 52);
            this.biketextBox.Name = "biketextBox";
            this.biketextBox.Size = new System.Drawing.Size(100, 22);
            this.biketextBox.TabIndex = 11;
            // 
            // bikeMiles
            // 
            this.bikeMiles.AutoSize = true;
            this.bikeMiles.Location = new System.Drawing.Point(16, 48);
            this.bikeMiles.Name = "bikeMiles";
            this.bikeMiles.Size = new System.Drawing.Size(185, 16);
            this.bikeMiles.TabIndex = 2;
            this.bikeMiles.Text = "How many miles did you bike?";
            // 
            // walkTextBox
            // 
            this.walkTextBox.Location = new System.Drawing.Point(222, 23);
            this.walkTextBox.Name = "walkTextBox";
            this.walkTextBox.Size = new System.Drawing.Size(100, 22);
            this.walkTextBox.TabIndex = 10;
            // 
            // walkLbl
            // 
            this.walkLbl.AutoSize = true;
            this.walkLbl.Location = new System.Drawing.Point(16, 26);
            this.walkLbl.Name = "walkLbl";
            this.walkLbl.Size = new System.Drawing.Size(187, 16);
            this.walkLbl.TabIndex = 0;
            this.walkLbl.Text = "How many miles did you walk?";
            // 
            // homeGroupBox
            // 
            this.homeGroupBox.BackColor = System.Drawing.Color.Coral;
            this.homeGroupBox.Controls.Add(this.ebillTextBox);
            this.homeGroupBox.Controls.Add(this.energyBillLabel);
            this.homeGroupBox.Controls.Add(this.windHomeRB);
            this.homeGroupBox.Controls.Add(this.solarHomeRB);
            this.homeGroupBox.Controls.Add(this.coalHomeRB);
            this.homeGroupBox.Controls.Add(this.gasHomeRB);
            this.homeGroupBox.Controls.Add(this.homePowerLabel);
            this.homeGroupBox.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeGroupBox.Location = new System.Drawing.Point(18, 588);
            this.homeGroupBox.Name = "homeGroupBox";
            this.homeGroupBox.Size = new System.Drawing.Size(388, 103);
            this.homeGroupBox.TabIndex = 3;
            this.homeGroupBox.TabStop = false;
            this.homeGroupBox.Text = "Home";
            // 
            // ebillTextBox
            // 
            this.ebillTextBox.Location = new System.Drawing.Point(245, 57);
            this.ebillTextBox.Name = "ebillTextBox";
            this.ebillTextBox.Size = new System.Drawing.Size(100, 22);
            this.ebillTextBox.TabIndex = 21;
            // 
            // energyBillLabel
            // 
            this.energyBillLabel.AutoSize = true;
            this.energyBillLabel.Location = new System.Drawing.Point(19, 60);
            this.energyBillLabel.Name = "energyBillLabel";
            this.energyBillLabel.Size = new System.Drawing.Size(220, 16);
            this.energyBillLabel.TabIndex = 5;
            this.energyBillLabel.Text = "How much was your last energy bill?";
            // 
            // windHomeRB
            // 
            this.windHomeRB.AutoSize = true;
            this.windHomeRB.Location = new System.Drawing.Point(173, 37);
            this.windHomeRB.Name = "windHomeRB";
            this.windHomeRB.Size = new System.Drawing.Size(56, 20);
            this.windHomeRB.TabIndex = 20;
            this.windHomeRB.Text = "Wind";
            this.windHomeRB.UseVisualStyleBackColor = true;
            // 
            // solarHomeRB
            // 
            this.solarHomeRB.AutoSize = true;
            this.solarHomeRB.Location = new System.Drawing.Point(122, 37);
            this.solarHomeRB.Name = "solarHomeRB";
            this.solarHomeRB.Size = new System.Drawing.Size(56, 20);
            this.solarHomeRB.TabIndex = 19;
            this.solarHomeRB.Text = "Solar";
            this.solarHomeRB.UseVisualStyleBackColor = true;
            // 
            // coalHomeRB
            // 
            this.coalHomeRB.AutoSize = true;
            this.coalHomeRB.Location = new System.Drawing.Point(69, 36);
            this.coalHomeRB.Name = "coalHomeRB";
            this.coalHomeRB.Size = new System.Drawing.Size(52, 20);
            this.coalHomeRB.TabIndex = 18;
            this.coalHomeRB.Text = "Coal";
            this.coalHomeRB.UseVisualStyleBackColor = true;
            // 
            // gasHomeRB
            // 
            this.gasHomeRB.AutoSize = true;
            this.gasHomeRB.Checked = true;
            this.gasHomeRB.Location = new System.Drawing.Point(19, 36);
            this.gasHomeRB.Name = "gasHomeRB";
            this.gasHomeRB.Size = new System.Drawing.Size(50, 20);
            this.gasHomeRB.TabIndex = 16;
            this.gasHomeRB.TabStop = true;
            this.gasHomeRB.Text = "Gas";
            this.gasHomeRB.UseVisualStyleBackColor = true;
            // 
            // homePowerLabel
            // 
            this.homePowerLabel.AutoSize = true;
            this.homePowerLabel.Location = new System.Drawing.Point(16, 20);
            this.homePowerLabel.Name = "homePowerLabel";
            this.homePowerLabel.Size = new System.Drawing.Size(256, 16);
            this.homePowerLabel.TabIndex = 0;
            this.homePowerLabel.Text = "What is the source of power in your home?";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.titleLabel.Location = new System.Drawing.Point(130, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(165, 32);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "EcoJournal";
            // 
            // explanationLabel
            // 
            this.explanationLabel.AutoSize = true;
            this.explanationLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.explanationLabel.Location = new System.Drawing.Point(28, 44);
            this.explanationLabel.Name = "explanationLabel";
            this.explanationLabel.Size = new System.Drawing.Size(353, 32);
            this.explanationLabel.TabIndex = 5;
            this.explanationLabel.Text = "This your ecojournal. Here is where you\'ll answer questions \r\nthat\'ll help calcul" +
    "ate your carbon footprint.";
            // 
            // buttongroupBox
            // 
            this.buttongroupBox.Controls.Add(this.backButton);
            this.buttongroupBox.Controls.Add(this.clearButton);
            this.buttongroupBox.Controls.Add(this.enterJournalBtn);
            this.buttongroupBox.Location = new System.Drawing.Point(18, 697);
            this.buttongroupBox.Name = "buttongroupBox";
            this.buttongroupBox.Size = new System.Drawing.Size(388, 62);
            this.buttongroupBox.TabIndex = 6;
            this.buttongroupBox.TabStop = false;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.White;
            this.backButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.backButton.Location = new System.Drawing.Point(261, 19);
            this.backButton.MinimumSize = new System.Drawing.Size(100, 20);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(100, 25);
            this.backButton.TabIndex = 24;
            this.backButton.Text = "Bac&k";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.White;
            this.clearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.clearButton.Location = new System.Drawing.Point(139, 19);
            this.clearButton.MinimumSize = new System.Drawing.Size(100, 20);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(100, 25);
            this.clearButton.TabIndex = 23;
            this.clearButton.Text = "Clea&r";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // enterJournalBtn
            // 
            this.enterJournalBtn.BackColor = System.Drawing.Color.White;
            this.enterJournalBtn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterJournalBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.enterJournalBtn.Location = new System.Drawing.Point(13, 19);
            this.enterJournalBtn.MinimumSize = new System.Drawing.Size(100, 20);
            this.enterJournalBtn.Name = "enterJournalBtn";
            this.enterJournalBtn.Size = new System.Drawing.Size(100, 25);
            this.enterJournalBtn.TabIndex = 22;
            this.enterJournalBtn.Text = "Ent&er Journal";
            this.enterJournalBtn.UseVisualStyleBackColor = false;
            this.enterJournalBtn.Click += new System.EventHandler(this.enterJournalBtn_Click);
            // 
            // msgLbl
            // 
            this.msgLbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.msgLbl.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgLbl.ForeColor = System.Drawing.Color.Red;
            this.msgLbl.Location = new System.Drawing.Point(212, 762);
            this.msgLbl.MinimumSize = new System.Drawing.Size(200, 20);
            this.msgLbl.Name = "msgLbl";
            this.msgLbl.Size = new System.Drawing.Size(200, 25);
            this.msgLbl.TabIndex = 7;
            this.msgLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // testTotal
            // 
            this.testTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.testTotal.AutoSize = true;
            this.testTotal.BackColor = System.Drawing.Color.Transparent;
            this.testTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.testTotal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testTotal.ForeColor = System.Drawing.Color.White;
            this.testTotal.Location = new System.Drawing.Point(12, 762);
            this.testTotal.MinimumSize = new System.Drawing.Size(200, 25);
            this.testTotal.Name = "testTotal";
            this.testTotal.Size = new System.Drawing.Size(200, 25);
            this.testTotal.TabIndex = 8;
            this.testTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EcoJournal
            // 
            this.AcceptButton = this.enterJournalBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CancelButton = this.clearButton;
            this.ClientSize = new System.Drawing.Size(424, 811);
            this.Controls.Add(this.testTotal);
            this.Controls.Add(this.msgLbl);
            this.Controls.Add(this.buttongroupBox);
            this.Controls.Add(this.explanationLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.homeGroupBox);
            this.Controls.Add(this.travelGroupBox);
            this.Controls.Add(this.recycleGroupBox);
            this.Controls.Add(this.dietGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(440, 850);
            this.Name = "EcoJournal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EcoJournal";
            this.dietGroupBox.ResumeLayout(false);
            this.dietGroupBox.PerformLayout();
            this.recycleGroupBox.ResumeLayout(false);
            this.recycleGroupBox.PerformLayout();
            this.travelGroupBox.ResumeLayout(false);
            this.travelGroupBox.PerformLayout();
            this.homeGroupBox.ResumeLayout(false);
            this.homeGroupBox.PerformLayout();
            this.buttongroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox dietGroupBox;
        private System.Windows.Forms.RadioButton omnivoreRB;
        private System.Windows.Forms.RadioButton pesectarianRB;
        private System.Windows.Forms.RadioButton vegetarianRB;
        private System.Windows.Forms.RadioButton veganRB;
        private System.Windows.Forms.Label dietLbl;
        private System.Windows.Forms.GroupBox recycleGroupBox;
        private System.Windows.Forms.Label metalLbl;
        private System.Windows.Forms.TextBox plasticTextBox;
        private System.Windows.Forms.Label plasticLbl;
        private System.Windows.Forms.TextBox glasstextBox;
        private System.Windows.Forms.Label glassLbl;
        private System.Windows.Forms.RadioButton recycleNoRB;
        private System.Windows.Forms.RadioButton recycleYesRB;
        private System.Windows.Forms.Label recycleQuestionLbl;
        private System.Windows.Forms.Label recycleLbl;
        private System.Windows.Forms.GroupBox travelGroupBox;
        private System.Windows.Forms.GroupBox homeGroupBox;
        private System.Windows.Forms.TextBox metalTextBox;
        private System.Windows.Forms.Label bikeMiles;
        private System.Windows.Forms.TextBox walkTextBox;
        private System.Windows.Forms.Label walkLbl;
        private System.Windows.Forms.RadioButton electricRB;
        private System.Windows.Forms.RadioButton gasCarRB;
        private System.Windows.Forms.Label carTypeLabel;
        private System.Windows.Forms.TextBox driveTextBox;
        private System.Windows.Forms.Label driveLbl;
        private System.Windows.Forms.TextBox biketextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox planetextBox;
        private System.Windows.Forms.Label planeLbl;
        private System.Windows.Forms.RadioButton windHomeRB;
        private System.Windows.Forms.RadioButton solarHomeRB;
        private System.Windows.Forms.RadioButton coalHomeRB;
        private System.Windows.Forms.RadioButton gasHomeRB;
        private System.Windows.Forms.Label homePowerLabel;
        private System.Windows.Forms.TextBox ebillTextBox;
        private System.Windows.Forms.Label energyBillLabel;
        private System.Windows.Forms.Label explanationLabel;
        private System.Windows.Forms.GroupBox buttongroupBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button enterJournalBtn;
        private System.Windows.Forms.Label msgLbl;
        private System.Windows.Forms.Label testTotal;
    }
}