using Domain_bib.Persistence;
using Domain_bib.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inlogformulier
{
    public partial class Gebruikerscherm : Form
    {
        public Gebruikerscherm()
        {
            InitializeComponent();
            var mapper = new Boekmapper();
            var boekenlijst = mapper.GetBoeken();
            tbBoekenlijst.Items.Clear();
            foreach (var boeken in boekenlijst)
            {
                tbBoekenlijst.Items.Add(boeken); // ToString() wordt automatisch gebruikt
            }
        }
    }
}
