﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Pokemon_Shuffle_Hack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string save
        {
            get { return savegame.Text; }
        }

        private void BLKDTH_get_data()
        {
            OpenFileDialog openFD = new OpenFileDialog();
            //openFD.InitialDirectory = "c:\\";
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                #region filename
                savegame.Text = openFD.FileName;
                #endregion

            }
        }

        // 99999 Coins + 150 Diamonds, (No Overflow)
        private void BLKDTH_set_data1()
        {

            byte[] X1 = { 0xF8, 0x34, 0x6C, 0x49 };

            System.IO.FileStream update_save_open = null;
            System.IO.BinaryWriter update_save_write = null;
            update_save_open = new System.IO.FileStream(save, System.IO.FileMode.OpenOrCreate);
            update_save_write = new System.IO.BinaryWriter(update_save_open);
            update_save_open.Position = Convert.ToInt64("68", 16);
            update_save_write.Write(X1);
            update_save_open.Close();
            //

            //

        }

        // 99 x Other Items, (No Overflow)
        private void BLKDTH_set_data2()
        {

            byte[] X2 = { 0x80, 0xB1, 0xB1, 0xB1, 0xB1, 0xB1, 0xB1, 0xB1, 0x31 };

            System.IO.FileStream update_save_open = null;
            System.IO.BinaryWriter update_save_write = null;
            update_save_open = new System.IO.FileStream(save, System.IO.FileMode.OpenOrCreate);
            update_save_write = new System.IO.BinaryWriter(update_save_open);
            update_save_open.Position = Convert.ToInt64("D0", 16);
            update_save_write.Write(X2);
            update_save_open.Close();
            //

            //

        }

        // 99 Hearts, (No Overflow)
        private void BLKDTH_set_data3()
        {

            byte[] X3 = { 0x80, 0x31 };

            System.IO.FileStream update_save_open = null;
            System.IO.BinaryWriter update_save_write = null;
            update_save_open = new System.IO.FileStream(save, System.IO.FileMode.OpenOrCreate);
            update_save_write = new System.IO.BinaryWriter(update_save_open);
            update_save_open.Position = Convert.ToInt64("2D4A", 16);
            update_save_write.Write(X3);
            update_save_open.Close();
            //

            //

        }

        // 99 Mega Speedups, (No Overflow)
        private void BLKDTH_set_data4()
        {

            byte[] X4 = { 0xC6 };

            System.IO.FileStream update_save_open = null;
            System.IO.BinaryWriter update_save_write = null;
            update_save_open = new System.IO.FileStream(save, System.IO.FileMode.OpenOrCreate);
            update_save_write = new System.IO.BinaryWriter(update_save_open);
            update_save_open.Position = Convert.ToInt64("2D4C", 16);
            update_save_write.Write(X4);
            update_save_open.Close();
            //

            //

        }

        // Caught All Pokemon (Table 1)
        private void BLKDTH_set_data5()
        {

            byte[] X5 = { 0xC2, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x01 };

            System.IO.FileStream update_save_open = null;
            System.IO.BinaryWriter update_save_write = null;
            update_save_open = new System.IO.FileStream(save, System.IO.FileMode.OpenOrCreate);
            update_save_write = new System.IO.BinaryWriter(update_save_open);
            update_save_open.Position = Convert.ToInt64("E6", 16);
            update_save_write.Write(X5);
            update_save_open.Close();
            //

            //

        }

        // Caught All Pokemon (Table 2)
        private void BLKDTH_set_data6()
        {

            byte[] X6 = { 0xC4, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x01 };

            System.IO.FileStream update_save_open = null;
            System.IO.BinaryWriter update_save_write = null;
            update_save_open = new System.IO.FileStream(save, System.IO.FileMode.OpenOrCreate);
            update_save_write = new System.IO.BinaryWriter(update_save_open);
            update_save_open.Position = Convert.ToInt64("546", 16);
            update_save_write.Write(X6);
            update_save_open.Close();
            //

            //

        }
        
        // Caught All Pokemon (Table 3)
        private void BLKDTH_set_data7()
        {

            byte[] X7 = { 0xC4, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0xFF, 0x01 };

            System.IO.FileStream update_save_open = null;
            System.IO.BinaryWriter update_save_write = null;
            update_save_open = new System.IO.FileStream(save, System.IO.FileMode.OpenOrCreate);
            update_save_write = new System.IO.BinaryWriter(update_save_open);
            update_save_open.Position = Convert.ToInt64("5E6", 16);
            update_save_write.Write(X7);
            update_save_open.Close();
            //

            //

        }
        
        // All Pokemon Level 10
        private void BLKDTH_set_data8()
        {

            byte[] X8 = { 0x54, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x55, 0x15 };

            System.IO.FileStream update_save_open = null;
            System.IO.BinaryWriter update_save_write = null;
            update_save_open = new System.IO.FileStream(save, System.IO.FileMode.OpenOrCreate);
            update_save_write = new System.IO.BinaryWriter(update_save_open);
            update_save_open.Position = Convert.ToInt64("187", 16);
            update_save_write.Write(X8);
            update_save_open.Close();
            //

            //

        }
        
        // All Megas Unlocked
        private void BLKDTH_set_data9()
        {

            byte[] X9 = { 0x08, 0x86, 0x00, 0x08, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x80, 0x00, 0x00, 0x00, 0x20, 0x00, 0x00, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x08, 0x02, 0x00, 0x00, 0x02, 0x00, 0x06, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x08, 0x88, 0x00, 0x00, 0x00, 0x20, 0x00, 0x00, 0x00, 0x00, 0x08, 0x80, 0x20, 0x08, 0x00, 0x00, 0x00, 0x00, 0x80, 0x00, 0x00, 0x00, 0x00, 0x80, 0x82, 0x88, 0x00, 0x00, 0x02, 0x02, 0x00, 0x80, 0x00, 0x00, 0x00, 0x00, 0x80, 0x00, 0x82, 0x00, 0x00, 0x20, 0x08, 0x28, 0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x20, 0x08, 0x00, 0x00, 0x08, 0x00, 0x00, 0x00, 0x02, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x80, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x08 };

            System.IO.FileStream update_save_open = null;
            System.IO.BinaryWriter update_save_write = null;
            update_save_open = new System.IO.FileStream(save, System.IO.FileMode.OpenOrCreate);
            update_save_write = new System.IO.BinaryWriter(update_save_open);
            update_save_open.Position = Convert.ToInt64("407", 16);
            update_save_write.Write(X9);
            update_save_open.Close();
            //

            //

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            BLKDTH_get_data();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BLKDTH_set_data1();
            
            MessageBox.Show("Patching done!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BLKDTH_set_data2();
            MessageBox.Show("Patching done!");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            BLKDTH_set_data1();
            BLKDTH_set_data2();
            BLKDTH_set_data3();
            BLKDTH_set_data4();
            BLKDTH_set_data5();
            BLKDTH_set_data6();
            BLKDTH_set_data7();
            BLKDTH_set_data8();
            BLKDTH_set_data9();
            MessageBox.Show("Patching done!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BLKDTH_set_data3();
            MessageBox.Show("Patching done!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BLKDTH_set_data4();
            MessageBox.Show("Patching done!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BLKDTH_set_data5();
            MessageBox.Show("Patching done!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BLKDTH_set_data6();
            MessageBox.Show("Patching done!");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BLKDTH_set_data7();
            MessageBox.Show("Patching done!");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            BLKDTH_set_data8();
            MessageBox.Show("Patching done!");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            BLKDTH_set_data9();
            MessageBox.Show("Patching done!");
        }

        private void germanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Text="savedata.bin laden";
            button2.Text = "99999 Münzen + 150 Klunker (Kein Überschuss)";
            button3.Text = "99 Gegenstände (Kein Überschuss)";
            button4.Text = "99 Herzen / Versuche (Kein Überschuss)";
            button5.Text = "99 Mega-Auslöser (Kein Überschuss)";
            button6.Text = "Alle Pokemon gefangen (Tabelle 1)";
            button7.Text = "Alle Pokemon gefangen (Tabelle 2)";
            button8.Text = "Alle Pokemon gefangen (Tabelle 3)";
            button9.Text = "Gefangene Pokemon werden Level 10";
            button10.Text = "Alle Megas freischalten";
            button11.Text = "Patche alles";

            toolStripSplitButton1.Text = "Sprache";

        }

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Text = "Open savedata.bin";
            button2.Text = "99999 Coins + 150 Diamonds (No Overflow)";
            button3.Text = "99 Items (No Overflow)";
            button4.Text = "99 Hearts (No Overflow)";
            button5.Text = "99 Mega-Speedups (No Overflow)";
            button6.Text = "Caught All Pokemon (Table 1)";
            button7.Text = "Caught All Pokemon (Table 2)";
            button8.Text = "Caught All Pokemon (Table 3)";
            button9.Text = "Pokemon caught become Level 10";
            button10.Text = "Unlock All Megas";
            button11.Text = "Patch All";

            toolStripSplitButton1.Text = "Language";
        }

        private void frenchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Text = "Charger un savedata.bin";
            button2.Text = "99999 Pièces + 150 Joyaux (Pas de superflus)";
            button3.Text = "99 Objets (Pas de superflus)";
            button4.Text = "99 Coeurs (Pas de superflus)";
            button5.Text = "99 Méga-Turbo (Pas de superflus)";
            button6.Text = "Capturer tous les Pokémon (Partie 1)";
            button7.Text = "Capturer tous les Pokémon (Partie 2)";
            button8.Text = "Capturer tous les Pokémon (Partie 3)";
            button9.Text = "Les Pokémon capturés deviennent N°10";
            button10.Text = "Débloquer tous les Méga";
            button11.Text = "Patcher tout en même temps";

            toolStripSplitButton1.Text = "Langue";
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form Form2 = new Form2();
            Form2.ShowDialog();
        }


       
        
    }
}