﻿using Inlämningsuppgift_3_Alexander_Adolfsson.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inlämningsuppgift_3_Alexander_Adolfsson
{
    public partial class GameForm : Form
    {
        Game game = new Game();
        public GameForm()
        {
            InitializeComponent();                              
        }        

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            game.StartGame(InsertNameBox.Text);
            UpdateGameBoard();
            StartGameButton.Hide();
            InsertNameBox.Hide();
            InserNameLabel.Hide();
        }

        private void UseItemButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(game.UseItem(PlayerInventoryList.Text));
        }

        private void CheckIInventorytemButton_Click(object sender, EventArgs e)
        {
            string itemInformation = game.ReadItem(PlayerInventoryList.Text);
            MessageBox.Show(itemInformation);
        }
        private void CheckRoomItemButton_Click(object sender, EventArgs e)
        {
            string itemInformation = game.ReadItem(RoomInventoryList.Text);
            MessageBox.Show(itemInformation);
        }
        private void CheckFurnitureButton_Click(object sender, EventArgs e)
        {
            string itemInformation = game.ReadItem(FurnitureList.Text);
            MessageBox.Show(itemInformation);
        }
        

        private void LookAroundButton_Click(object sender, EventArgs e)
        {
            game.LookAroundInRoom();
            UpdateGameBoard();
        }

        private void ThrowItemButton_Click(object sender, EventArgs e)
        {
            game.ThrowItemOnGround(PlayerInventoryList.Text);
            UpdateGameBoard();
        }

        private void PickUpButton_Click(object sender, EventArgs e)
        {
            game.PickUpItemFromRoom(RoomInventoryList.Text);
            UpdateGameBoard();
        }

        private void RoomInfoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(game.RoomInfo()); 
        }
        public void UpdateGameBoard()
        {
            PlayerInventoryList.Items.Clear();
            RoomInventoryList.Items.Clear();
            FurnitureList.Items.Clear();
            PlayerNameLabel.Text = $"Spelarnamn : {game.CurrentPlayer()}";
            RoomLabel.Text = $"Du befinner dig nu i rum : {game.CurrentRoom()}";
            List<Items> playerInventoryList = game.PlayerInventory().ToList();
            List<Items> itemsInRoomList = game.ItemsInRoom().ToList();
            List<Furnitures> furnituresInRoomList = game.FurnituresInRoom().ToList();

            foreach (Items item in playerInventoryList)
            {
                PlayerInventoryList.Items.Add(item.Name);
            }
            foreach (Items item in itemsInRoomList)
            {
                RoomInventoryList.Items.Add(item.Name);
            }
            foreach (Furnitures furniture in furnituresInRoomList)
            {
                FurnitureList.Items.Add(furniture.Name);
            }



        }

        private void UseItemOnFurnitureButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(game.UseItemOnFurniture(PlayerInventoryList.Text, FurnitureList.Text));
            UpdateGameBoard();
        }

        private void NextRoomButton_Click(object sender, EventArgs e)
        {
            game.GoToNextRoom();
            UpdateGameBoard();
        }

        private void PreviousRoomButton_Click(object sender, EventArgs e)
        {
            game.GoToPreviousRoom();
            UpdateGameBoard();
        }
    }
}
