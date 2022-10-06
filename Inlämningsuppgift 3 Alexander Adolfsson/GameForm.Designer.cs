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
            this.PlayerInventoryList.ItemHeight = 20;
            this.PlayerInventoryList.Location = new System.Drawing.Point(1119, 169);
            this.PlayerInventoryList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PlayerInventoryList.Name = "PlayerInventoryList";
            this.PlayerInventoryList.Size = new System.Drawing.Size(174, 184);
            this.PlayerInventoryList.TabIndex = 0;
            // 
            // InventoryLabel
            // 
            this.InventoryLabel.AutoSize = true;
            this.InventoryLabel.Location = new System.Drawing.Point(1119, 145);
            this.InventoryLabel.Name = "InventoryLabel";
            this.InventoryLabel.Size = new System.Drawing.Size(131, 20);
            this.InventoryLabel.TabIndex = 1;
            this.InventoryLabel.Text = "Spelarens Föremål";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1119, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Föremål i rummet";
            // 
            // RoomInventoryList
            // 
            this.RoomInventoryList.FormattingEnabled = true;
            this.RoomInventoryList.ItemHeight = 20;
            this.RoomInventoryList.Location = new System.Drawing.Point(1119, 393);
            this.RoomInventoryList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RoomInventoryList.Name = "RoomInventoryList";
            this.RoomInventoryList.Size = new System.Drawing.Size(174, 124);
            this.RoomInventoryList.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1119, 535);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Möbler i rummet";
            // 
            // FurnitureList
            // 
            this.FurnitureList.FormattingEnabled = true;
            this.FurnitureList.ItemHeight = 20;
            this.FurnitureList.Location = new System.Drawing.Point(1119, 559);
            this.FurnitureList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FurnitureList.Name = "FurnitureList";
            this.FurnitureList.Size = new System.Drawing.Size(174, 124);
            this.FurnitureList.TabIndex = 4;
            // 
            // CombineButton
            // 
            this.CombineButton.Location = new System.Drawing.Point(1026, 169);
            this.CombineButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CombineButton.Name = "CombineButton";
            this.CombineButton.Size = new System.Drawing.Size(86, 53);
            this.CombineButton.TabIndex = 6;
            this.CombineButton.Text = "Kombinera föremål";
            this.CombineButton.UseVisualStyleBackColor = true;
            // 
            // RoomLabel
            // 
            this.RoomLabel.AutoSize = true;
            this.RoomLabel.Location = new System.Drawing.Point(17, 225);
            this.RoomLabel.Name = "RoomLabel";
            this.RoomLabel.Size = new System.Drawing.Size(178, 20);
            this.RoomLabel.TabIndex = 7;
            this.RoomLabel.Text = "Du befinner dig nu i rum :";
            // 
            // UseItemButton
            // 
            this.UseItemButton.Location = new System.Drawing.Point(1026, 231);
            this.UseItemButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UseItemButton.Name = "UseItemButton";
            this.UseItemButton.Size = new System.Drawing.Size(86, 53);
            this.UseItemButton.TabIndex = 6;
            this.UseItemButton.Text = "Använd Föremål";
            this.UseItemButton.UseVisualStyleBackColor = true;
            this.UseItemButton.Click += new System.EventHandler(this.UseItemButton_Click);
            // 
            // GameTitleLabel
            // 
            this.GameTitleLabel.AutoSize = true;
            this.GameTitleLabel.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GameTitleLabel.Location = new System.Drawing.Point(467, 32);
            this.GameTitleLabel.Name = "GameTitleLabel";
            this.GameTitleLabel.Size = new System.Drawing.Size(357, 49);
            this.GameTitleLabel.TabIndex = 8;
            this.GameTitleLabel.Text = "Zynads Adventure";
            // 
            // ThrowItemButton
            // 
            this.ThrowItemButton.Location = new System.Drawing.Point(934, 231);
            this.ThrowItemButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ThrowItemButton.Name = "ThrowItemButton";
            this.ThrowItemButton.Size = new System.Drawing.Size(86, 53);
            this.ThrowItemButton.TabIndex = 6;
            this.ThrowItemButton.Text = "Kasta Föremål";
            this.ThrowItemButton.UseVisualStyleBackColor = true;
            this.ThrowItemButton.Click += new System.EventHandler(this.ThrowItemButton_Click);
            // 
            // PLayerInfoPanel
            // 
            this.PLayerInfoPanel.Controls.Add(this.PlayerNameLabel);
            this.PLayerInfoPanel.Controls.Add(this.RoomLabel);
            this.PLayerInfoPanel.Location = new System.Drawing.Point(14, 169);
            this.PLayerInfoPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PLayerInfoPanel.Name = "PLayerInfoPanel";
            this.PLayerInfoPanel.Size = new System.Drawing.Size(325, 281);
            this.PLayerInfoPanel.TabIndex = 9;
            // 
            // PlayerNameLabel
            // 
            this.PlayerNameLabel.AutoSize = true;
            this.PlayerNameLabel.Location = new System.Drawing.Point(17, 17);
            this.PlayerNameLabel.Name = "PlayerNameLabel";
            this.PlayerNameLabel.Size = new System.Drawing.Size(99, 20);
            this.PlayerNameLabel.TabIndex = 10;
            this.PlayerNameLabel.Text = "Spelarnamn : ";
            // 
            // StartGameButton
            // 
            this.StartGameButton.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartGameButton.Location = new System.Drawing.Point(451, 331);
            this.StartGameButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(383, 204);
            this.StartGameButton.TabIndex = 10;
            this.StartGameButton.Text = "Starta Spelet";
            this.StartGameButton.UseVisualStyleBackColor = true;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // InsertNameBox
            // 
            this.InsertNameBox.Location = new System.Drawing.Point(451, 292);
            this.InsertNameBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InsertNameBox.Name = "InsertNameBox";
            this.InsertNameBox.Size = new System.Drawing.Size(172, 27);
            this.InsertNameBox.TabIndex = 11;
            // 
            // InserNameLabel
            // 
            this.InserNameLabel.AutoSize = true;
            this.InserNameLabel.Location = new System.Drawing.Point(451, 264);
            this.InserNameLabel.Name = "InserNameLabel";
            this.InserNameLabel.Size = new System.Drawing.Size(124, 20);
            this.InserNameLabel.TabIndex = 12;
            this.InserNameLabel.Text = "Skriv in ditt namn";
            // 
            // PickUpButton
            // 
            this.PickUpButton.Location = new System.Drawing.Point(1026, 393);
            this.PickUpButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PickUpButton.Name = "PickUpButton";
            this.PickUpButton.Size = new System.Drawing.Size(86, 53);
            this.PickUpButton.TabIndex = 6;
            this.PickUpButton.Text = "Ta upp föremål";
            this.PickUpButton.UseVisualStyleBackColor = true;
            this.PickUpButton.Click += new System.EventHandler(this.PickUpButton_Click);
            // 
            // LookAroundButton
            // 
            this.LookAroundButton.Location = new System.Drawing.Point(1026, 465);
            this.LookAroundButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LookAroundButton.Name = "LookAroundButton";
            this.LookAroundButton.Size = new System.Drawing.Size(86, 53);
            this.LookAroundButton.TabIndex = 6;
            this.LookAroundButton.Text = "Kolla runt i rummet";
            this.LookAroundButton.UseVisualStyleBackColor = true;
            this.LookAroundButton.Click += new System.EventHandler(this.LookAroundButton_Click);
            // 
            // UseItemOnFurnitureButton
            // 
            this.UseItemOnFurnitureButton.Location = new System.Drawing.Point(1026, 559);
            this.UseItemOnFurnitureButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UseItemOnFurnitureButton.Name = "UseItemOnFurnitureButton";
            this.UseItemOnFurnitureButton.Size = new System.Drawing.Size(86, 53);
            this.UseItemOnFurnitureButton.TabIndex = 6;
            this.UseItemOnFurnitureButton.Text = "Använd föremål på";
            this.UseItemOnFurnitureButton.UseVisualStyleBackColor = true;
            this.UseItemOnFurnitureButton.Click += new System.EventHandler(this.UseItemOnFurnitureButton_Click);
            // 
            // RoomInfoButton
            // 
            this.RoomInfoButton.Location = new System.Drawing.Point(31, 477);
            this.RoomInfoButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RoomInfoButton.Name = "RoomInfoButton";
            this.RoomInfoButton.Size = new System.Drawing.Size(123, 57);
            this.RoomInfoButton.TabIndex = 13;
            this.RoomInfoButton.Text = "Rumsbeskrivning";
            this.RoomInfoButton.UseVisualStyleBackColor = true;
            this.RoomInfoButton.Click += new System.EventHandler(this.RoomInfoButton_Click);
            // 
            // PreviousRoomButton
            // 
            this.PreviousRoomButton.Location = new System.Drawing.Point(31, 623);
            this.PreviousRoomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PreviousRoomButton.Name = "PreviousRoomButton";
            this.PreviousRoomButton.Size = new System.Drawing.Size(123, 57);
            this.PreviousRoomButton.TabIndex = 13;
            this.PreviousRoomButton.Text = "Gå till förra rummet";
            this.PreviousRoomButton.UseVisualStyleBackColor = true;
            this.PreviousRoomButton.Click += new System.EventHandler(this.PreviousRoomButton_Click);
            // 
            // NextRoomButton
            // 
            this.NextRoomButton.Location = new System.Drawing.Point(31, 551);
            this.NextRoomButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NextRoomButton.Name = "NextRoomButton";
            this.NextRoomButton.Size = new System.Drawing.Size(123, 57);
            this.NextRoomButton.TabIndex = 13;
            this.NextRoomButton.Text = "Gå till nästa rum";
            this.NextRoomButton.UseVisualStyleBackColor = true;
            this.NextRoomButton.Click += new System.EventHandler(this.NextRoomButton_Click);
            // 
            // CheckIInventorytemButton
            // 
            this.CheckIInventorytemButton.Location = new System.Drawing.Point(934, 169);
            this.CheckIInventorytemButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckIInventorytemButton.Name = "CheckIInventorytemButton";
            this.CheckIInventorytemButton.Size = new System.Drawing.Size(86, 53);
            this.CheckIInventorytemButton.TabIndex = 6;
            this.CheckIInventorytemButton.Text = "Granska föremål";
            this.CheckIInventorytemButton.UseVisualStyleBackColor = true;
            this.CheckIInventorytemButton.Click += new System.EventHandler(this.CheckIInventorytemButton_Click);
            // 
            // CheckRoomItemButton
            // 
            this.CheckRoomItemButton.Location = new System.Drawing.Point(934, 393);
            this.CheckRoomItemButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckRoomItemButton.Name = "CheckRoomItemButton";
            this.CheckRoomItemButton.Size = new System.Drawing.Size(86, 53);
            this.CheckRoomItemButton.TabIndex = 6;
            this.CheckRoomItemButton.Text = "Granska föremål";
            this.CheckRoomItemButton.UseVisualStyleBackColor = true;
            this.CheckRoomItemButton.Click += new System.EventHandler(this.CheckRoomItemButton_Click);
            // 
            // UseItemOnRoomItemButton
            // 
            this.UseItemOnRoomItemButton.Location = new System.Drawing.Point(934, 465);
            this.UseItemOnRoomItemButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UseItemOnRoomItemButton.Name = "UseItemOnRoomItemButton";
            this.UseItemOnRoomItemButton.Size = new System.Drawing.Size(86, 53);
            this.UseItemOnRoomItemButton.TabIndex = 6;
            this.UseItemOnRoomItemButton.Text = "Använd föremål på";
            this.UseItemOnRoomItemButton.UseVisualStyleBackColor = true;
            // 
            // SearchFurnitureButton
            // 
            this.SearchFurnitureButton.Location = new System.Drawing.Point(1026, 620);
            this.SearchFurnitureButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SearchFurnitureButton.Name = "SearchFurnitureButton";
            this.SearchFurnitureButton.Size = new System.Drawing.Size(86, 53);
            this.SearchFurnitureButton.TabIndex = 6;
            this.SearchFurnitureButton.Text = "Leta i möbeln";
            this.SearchFurnitureButton.UseVisualStyleBackColor = true;
            // 
            // OpenFurnitureButton
            // 
            this.OpenFurnitureButton.Location = new System.Drawing.Point(934, 620);
            this.OpenFurnitureButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OpenFurnitureButton.Name = "OpenFurnitureButton";
            this.OpenFurnitureButton.Size = new System.Drawing.Size(86, 53);
            this.OpenFurnitureButton.TabIndex = 6;
            this.OpenFurnitureButton.Text = "Öppna möbeln";
            this.OpenFurnitureButton.UseVisualStyleBackColor = true;
            // 
            // CheckFurnitureButton
            // 
            this.CheckFurnitureButton.Location = new System.Drawing.Point(934, 559);
            this.CheckFurnitureButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckFurnitureButton.Name = "CheckFurnitureButton";
            this.CheckFurnitureButton.Size = new System.Drawing.Size(86, 53);
            this.CheckFurnitureButton.TabIndex = 6;
            this.CheckFurnitureButton.Text = "Granska föremål";
            this.CheckFurnitureButton.UseVisualStyleBackColor = true;
            this.CheckFurnitureButton.Click += new System.EventHandler(this.CheckFurnitureButton_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 823);
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