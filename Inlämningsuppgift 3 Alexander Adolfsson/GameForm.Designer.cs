namespace Inlämningsuppgift_3_Alexander_Adolfsson
{
    partial class GameForm
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
            this.PlayerInventoryList = new System.Windows.Forms.ListBox();
            this.InventoryLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RoomInventoryList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FurnitureList = new System.Windows.Forms.ListBox();
            this.CombineButton = new System.Windows.Forms.Button();
            this.RoomLabel = new System.Windows.Forms.Label();
            this.UseItemButton = new System.Windows.Forms.Button();
            this.GameTitleLabel = new System.Windows.Forms.Label();
            this.ThrowItemButton = new System.Windows.Forms.Button();
            this.PLayerInfoPanel = new System.Windows.Forms.Panel();
            this.PlayerNameLabel = new System.Windows.Forms.Label();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.InsertNameBox = new System.Windows.Forms.TextBox();
            this.InserNameLabel = new System.Windows.Forms.Label();
            this.PickUpButton = new System.Windows.Forms.Button();
            this.LookAroundButton = new System.Windows.Forms.Button();
            this.UseItemOnFurnitureButton = new System.Windows.Forms.Button();
            this.RoomInfoButton = new System.Windows.Forms.Button();
            this.PreviousRoomButton = new System.Windows.Forms.Button();
            this.NextRoomButton = new System.Windows.Forms.Button();
            this.CheckIInventorytemButton = new System.Windows.Forms.Button();
            this.CheckRoomItemButton = new System.Windows.Forms.Button();
            this.UseItemOnRoomItemButton = new System.Windows.Forms.Button();
            this.SearchFurnitureButton = new System.Windows.Forms.Button();
            this.OpenFurnitureButton = new System.Windows.Forms.Button();
            this.CheckFurnitureButton = new System.Windows.Forms.Button();
            this.PLayerInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayerInventoryList
            // 
            this.PlayerInventoryList.FormattingEnabled = true;
            this.PlayerInventoryList.ItemHeight = 15;
            this.PlayerInventoryList.Location = new System.Drawing.Point(979, 127);
            this.PlayerInventoryList.Name = "PlayerInventoryList";
            this.PlayerInventoryList.Size = new System.Drawing.Size(153, 139);
            this.PlayerInventoryList.TabIndex = 0;
            // 
            // InventoryLabel
            // 
            this.InventoryLabel.AutoSize = true;
            this.InventoryLabel.Location = new System.Drawing.Point(979, 109);
            this.InventoryLabel.Name = "InventoryLabel";
            this.InventoryLabel.Size = new System.Drawing.Size(103, 15);
            this.InventoryLabel.TabIndex = 1;
            this.InventoryLabel.Text = "Spelarens Föremål";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(979, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Föremål i rummet";
            // 
            // RoomInventoryList
            // 
            this.RoomInventoryList.FormattingEnabled = true;
            this.RoomInventoryList.ItemHeight = 15;
            this.RoomInventoryList.Location = new System.Drawing.Point(979, 295);
            this.RoomInventoryList.Name = "RoomInventoryList";
            this.RoomInventoryList.Size = new System.Drawing.Size(153, 94);
            this.RoomInventoryList.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(979, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Möbler i rummet";
            // 
            // FurnitureList
            // 
            this.FurnitureList.FormattingEnabled = true;
            this.FurnitureList.ItemHeight = 15;
            this.FurnitureList.Location = new System.Drawing.Point(979, 419);
            this.FurnitureList.Name = "FurnitureList";
            this.FurnitureList.Size = new System.Drawing.Size(153, 94);
            this.FurnitureList.TabIndex = 4;
            // 
            // CombineButton
            // 
            this.CombineButton.Location = new System.Drawing.Point(898, 127);
            this.CombineButton.Name = "CombineButton";
            this.CombineButton.Size = new System.Drawing.Size(75, 40);
            this.CombineButton.TabIndex = 6;
            this.CombineButton.Text = "Kombinera föremål";
            this.CombineButton.UseVisualStyleBackColor = true;
            // 
            // RoomLabel
            // 
            this.RoomLabel.AutoSize = true;
            this.RoomLabel.Location = new System.Drawing.Point(15, 169);
            this.RoomLabel.Name = "RoomLabel";
            this.RoomLabel.Size = new System.Drawing.Size(143, 15);
            this.RoomLabel.TabIndex = 7;
            this.RoomLabel.Text = "Du befinner dig nu i rum :";
            // 
            // UseItemButton
            // 
            this.UseItemButton.Location = new System.Drawing.Point(898, 173);
            this.UseItemButton.Name = "UseItemButton";
            this.UseItemButton.Size = new System.Drawing.Size(75, 40);
            this.UseItemButton.TabIndex = 6;
            this.UseItemButton.Text = "Använd Föremål";
            this.UseItemButton.UseVisualStyleBackColor = true;
            this.UseItemButton.Click += new System.EventHandler(this.UseItemButton_Click);
            // 
            // GameTitleLabel
            // 
            this.GameTitleLabel.AutoSize = true;
            this.GameTitleLabel.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GameTitleLabel.Location = new System.Drawing.Point(409, 24);
            this.GameTitleLabel.Name = "GameTitleLabel";
            this.GameTitleLabel.Size = new System.Drawing.Size(281, 39);
            this.GameTitleLabel.TabIndex = 8;
            this.GameTitleLabel.Text = "Zynads Adventure";
            // 
            // ThrowItemButton
            // 
            this.ThrowItemButton.Location = new System.Drawing.Point(817, 173);
            this.ThrowItemButton.Name = "ThrowItemButton";
            this.ThrowItemButton.Size = new System.Drawing.Size(75, 40);
            this.ThrowItemButton.TabIndex = 6;
            this.ThrowItemButton.Text = "Kasta Föremål";
            this.ThrowItemButton.UseVisualStyleBackColor = true;
            this.ThrowItemButton.Click += new System.EventHandler(this.ThrowItemButton_Click);
            // 
            // PLayerInfoPanel
            // 
            this.PLayerInfoPanel.Controls.Add(this.PlayerNameLabel);
            this.PLayerInfoPanel.Controls.Add(this.RoomLabel);
            this.PLayerInfoPanel.Location = new System.Drawing.Point(12, 127);
            this.PLayerInfoPanel.Name = "PLayerInfoPanel";
            this.PLayerInfoPanel.Size = new System.Drawing.Size(284, 211);
            this.PLayerInfoPanel.TabIndex = 9;
            // 
            // PlayerNameLabel
            // 
            this.PlayerNameLabel.AutoSize = true;
            this.PlayerNameLabel.Location = new System.Drawing.Point(15, 13);
            this.PlayerNameLabel.Name = "PlayerNameLabel";
            this.PlayerNameLabel.Size = new System.Drawing.Size(79, 15);
            this.PlayerNameLabel.TabIndex = 10;
            this.PlayerNameLabel.Text = "Spelarnamn : ";
            // 
            // StartGameButton
            // 
            this.StartGameButton.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartGameButton.Location = new System.Drawing.Point(395, 248);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(335, 153);
            this.StartGameButton.TabIndex = 10;
            this.StartGameButton.Text = "Starta Spelet";
            this.StartGameButton.UseVisualStyleBackColor = true;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // InsertNameBox
            // 
            this.InsertNameBox.Location = new System.Drawing.Point(395, 219);
            this.InsertNameBox.Name = "InsertNameBox";
            this.InsertNameBox.Size = new System.Drawing.Size(151, 23);
            this.InsertNameBox.TabIndex = 11;
            // 
            // InserNameLabel
            // 
            this.InserNameLabel.AutoSize = true;
            this.InserNameLabel.Location = new System.Drawing.Point(395, 198);
            this.InserNameLabel.Name = "InserNameLabel";
            this.InserNameLabel.Size = new System.Drawing.Size(100, 15);
            this.InserNameLabel.TabIndex = 12;
            this.InserNameLabel.Text = "Skriv in ditt namn";
            // 
            // PickUpButton
            // 
            this.PickUpButton.Location = new System.Drawing.Point(898, 295);
            this.PickUpButton.Name = "PickUpButton";
            this.PickUpButton.Size = new System.Drawing.Size(75, 40);
            this.PickUpButton.TabIndex = 6;
            this.PickUpButton.Text = "Ta upp föremål";
            this.PickUpButton.UseVisualStyleBackColor = true;
            this.PickUpButton.Click += new System.EventHandler(this.PickUpButton_Click);
            // 
            // LookAroundButton
            // 
            this.LookAroundButton.Location = new System.Drawing.Point(898, 349);
            this.LookAroundButton.Name = "LookAroundButton";
            this.LookAroundButton.Size = new System.Drawing.Size(75, 40);
            this.LookAroundButton.TabIndex = 6;
            this.LookAroundButton.Text = "Kolla runt i rummet";
            this.LookAroundButton.UseVisualStyleBackColor = true;
            this.LookAroundButton.Click += new System.EventHandler(this.LookAroundButton_Click);
            // 
            // UseItemOnFurnitureButton
            // 
            this.UseItemOnFurnitureButton.Location = new System.Drawing.Point(898, 419);
            this.UseItemOnFurnitureButton.Name = "UseItemOnFurnitureButton";
            this.UseItemOnFurnitureButton.Size = new System.Drawing.Size(75, 40);
            this.UseItemOnFurnitureButton.TabIndex = 6;
            this.UseItemOnFurnitureButton.Text = "Använd föremål på";
            this.UseItemOnFurnitureButton.UseVisualStyleBackColor = true;
            this.UseItemOnFurnitureButton.Click += new System.EventHandler(this.UseItemOnFurnitureButton_Click);
            // 
            // RoomInfoButton
            // 
            this.RoomInfoButton.Location = new System.Drawing.Point(27, 358);
            this.RoomInfoButton.Name = "RoomInfoButton";
            this.RoomInfoButton.Size = new System.Drawing.Size(108, 43);
            this.RoomInfoButton.TabIndex = 13;
            this.RoomInfoButton.Text = "Rumsbeskrivning";
            this.RoomInfoButton.UseVisualStyleBackColor = true;
            this.RoomInfoButton.Click += new System.EventHandler(this.RoomInfoButton_Click);
            // 
            // PreviousRoomButton
            // 
            this.PreviousRoomButton.Location = new System.Drawing.Point(27, 467);
            this.PreviousRoomButton.Name = "PreviousRoomButton";
            this.PreviousRoomButton.Size = new System.Drawing.Size(108, 43);
            this.PreviousRoomButton.TabIndex = 13;
            this.PreviousRoomButton.Text = "Gå till förra rummet";
            this.PreviousRoomButton.UseVisualStyleBackColor = true;
            this.PreviousRoomButton.Click += new System.EventHandler(this.PreviousRoomButton_Click);
            // 
            // NextRoomButton
            // 
            this.NextRoomButton.Location = new System.Drawing.Point(27, 413);
            this.NextRoomButton.Name = "NextRoomButton";
            this.NextRoomButton.Size = new System.Drawing.Size(108, 43);
            this.NextRoomButton.TabIndex = 13;
            this.NextRoomButton.Text = "Gå till nästa rum";
            this.NextRoomButton.UseVisualStyleBackColor = true;
            this.NextRoomButton.Click += new System.EventHandler(this.NextRoomButton_Click);
            // 
            // CheckIInventorytemButton
            // 
            this.CheckIInventorytemButton.Location = new System.Drawing.Point(817, 127);
            this.CheckIInventorytemButton.Name = "CheckIInventorytemButton";
            this.CheckIInventorytemButton.Size = new System.Drawing.Size(75, 40);
            this.CheckIInventorytemButton.TabIndex = 6;
            this.CheckIInventorytemButton.Text = "Granska föremål";
            this.CheckIInventorytemButton.UseVisualStyleBackColor = true;
            this.CheckIInventorytemButton.Click += new System.EventHandler(this.CheckIInventorytemButton_Click);
            // 
            // CheckRoomItemButton
            // 
            this.CheckRoomItemButton.Location = new System.Drawing.Point(817, 295);
            this.CheckRoomItemButton.Name = "CheckRoomItemButton";
            this.CheckRoomItemButton.Size = new System.Drawing.Size(75, 40);
            this.CheckRoomItemButton.TabIndex = 6;
            this.CheckRoomItemButton.Text = "Granska föremål";
            this.CheckRoomItemButton.UseVisualStyleBackColor = true;
            this.CheckRoomItemButton.Click += new System.EventHandler(this.CheckRoomItemButton_Click);
            // 
            // UseItemOnRoomItemButton
            // 
            this.UseItemOnRoomItemButton.Location = new System.Drawing.Point(817, 349);
            this.UseItemOnRoomItemButton.Name = "UseItemOnRoomItemButton";
            this.UseItemOnRoomItemButton.Size = new System.Drawing.Size(75, 40);
            this.UseItemOnRoomItemButton.TabIndex = 6;
            this.UseItemOnRoomItemButton.Text = "Använd föremål på";
            this.UseItemOnRoomItemButton.UseVisualStyleBackColor = true;
            // 
            // SearchFurnitureButton
            // 
            this.SearchFurnitureButton.Location = new System.Drawing.Point(898, 465);
            this.SearchFurnitureButton.Name = "SearchFurnitureButton";
            this.SearchFurnitureButton.Size = new System.Drawing.Size(75, 40);
            this.SearchFurnitureButton.TabIndex = 6;
            this.SearchFurnitureButton.Text = "Leta i möbeln";
            this.SearchFurnitureButton.UseVisualStyleBackColor = true;
            // 
            // OpenFurnitureButton
            // 
            this.OpenFurnitureButton.Location = new System.Drawing.Point(817, 465);
            this.OpenFurnitureButton.Name = "OpenFurnitureButton";
            this.OpenFurnitureButton.Size = new System.Drawing.Size(75, 40);
            this.OpenFurnitureButton.TabIndex = 6;
            this.OpenFurnitureButton.Text = "Öppna möbeln";
            this.OpenFurnitureButton.UseVisualStyleBackColor = true;
            this.OpenFurnitureButton.Click += new System.EventHandler(this.OpenFurnitureButton_Click);
            // 
            // CheckFurnitureButton
            // 
            this.CheckFurnitureButton.Location = new System.Drawing.Point(817, 419);
            this.CheckFurnitureButton.Name = "CheckFurnitureButton";
            this.CheckFurnitureButton.Size = new System.Drawing.Size(75, 40);
            this.CheckFurnitureButton.TabIndex = 6;
            this.CheckFurnitureButton.Text = "Granska föremål";
            this.CheckFurnitureButton.UseVisualStyleBackColor = true;
            this.CheckFurnitureButton.Click += new System.EventHandler(this.CheckFurnitureButton_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 617);
            this.Controls.Add(this.NextRoomButton);
            this.Controls.Add(this.PreviousRoomButton);
            this.Controls.Add(this.RoomInfoButton);
            this.Controls.Add(this.InserNameLabel);
            this.Controls.Add(this.InsertNameBox);
            this.Controls.Add(this.StartGameButton);
            this.Controls.Add(this.PLayerInfoPanel);
            this.Controls.Add(this.GameTitleLabel);
            this.Controls.Add(this.UseItemOnRoomItemButton);
            this.Controls.Add(this.OpenFurnitureButton);
            this.Controls.Add(this.SearchFurnitureButton);
            this.Controls.Add(this.UseItemOnFurnitureButton);
            this.Controls.Add(this.LookAroundButton);
            this.Controls.Add(this.PickUpButton);
            this.Controls.Add(this.CheckFurnitureButton);
            this.Controls.Add(this.CheckRoomItemButton);
            this.Controls.Add(this.CheckIInventorytemButton);
            this.Controls.Add(this.ThrowItemButton);
            this.Controls.Add(this.UseItemButton);
            this.Controls.Add(this.CombineButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FurnitureList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RoomInventoryList);
            this.Controls.Add(this.InventoryLabel);
            this.Controls.Add(this.PlayerInventoryList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GameForm";
            this.Text = "Zynads Adventure";
            this.PLayerInfoPanel.ResumeLayout(false);
            this.PLayerInfoPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox PlayerInventoryList;
        private Label InventoryLabel;
        private Label label1;
        private ListBox RoomInventoryList;
        private Label label2;
        private ListBox FurnitureList;
        private Button CombineButton;
        private Label RoomLabel;
        private Button UseItemButton;
        private Label GameTitleLabel;
        private Button ThrowItemButton;
        private Panel PLayerInfoPanel;
        private Label PlayerNameLabel;
        private Button StartGameButton;
        private TextBox InsertNameBox;
        private Label InserNameLabel;
        private Button PickUpButton;
        private Button LookAroundButton;
        private Button UseItemOnFurnitureButton;
        private Button RoomInfoButton;
        private Button PreviousRoomButton;
        private Button NextRoomButton;
        private Button CheckIInventorytemButton;
        private Button CheckRoomItemButton;
        private Button UseItemOnRoomItemButton;
        private Button SearchFurnitureButton;
        private Button OpenFurnitureButton;
        private Button CheckFurnitureButton;
    }
}