﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalLoanOffer
{
    public partial class OfferList : Form
    {
        public OfferList()
        {
            InitializeComponent();
        }

        private void OfferList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personalLoanOfferDataSet.CREDIT' table. You can move, or remove it, as needed.
            this.cREDITTableAdapter.Fill(this.personalLoanOfferDataSet.CREDIT);

        }

        private void searchButton_OnClick(object sender, EventArgs e)
        {

        }
    }
}
