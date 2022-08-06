using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test01_PulasthiBethmage.View;
using Test01_PulasthiBethmage.Model;
using Test01_PulasthiBethmage.Presenter;

namespace Test01_PulasthiBethmage
{
    public partial class Form1 : Form,IPaymentView
    {
        public Form1()
        {
            InitializeComponent();


        }

        public string EmpFirstNameLabel
        {
            get
            {
                return fnameLabel.Text;
            }
            set
            {
                fnameLabel.Text = value;
            }
        }

        public string EmpLastNameLabel
        {
            get
            {
                return lnameLabel.Text;
            }
            set
            {
                lnameLabel.Text=value;
            }
        }

        public string EmpContactNoLabel
        {
            get
            {
                return contactLabel.Text;
            }
            set
            {
                contactLabel.Text = value;
            }
        }

        public string EmpAmountPaidLabel
        {
            get
            {
                return amountLabel.Text;
            }
            set
            {
                amountLabel.Text = value;
            }
        }

        public string EmpPointsLabel
        {
            get
            {
                return pointsLabel.Text;
            }
            set
            {
                pointsLabel.Text = value;
            }
        }

        public string EmpFirstNameTextBox
        {
            get
            {
                return txtbFname.Text;
            }
            set
            {
                txtbFname.Text=value;
            }
        }

        public string EmpLastNameTextBox
        {
            get
            {
                return txtbLname.Text;
            }
            set
            {
                txtbLname.Text=value;
            }
        }

        public string EmContactNoTextBox
        {
            get
            {
                return txtbContact.Text;
            }
            set
            {
                txtbContact.Text = value;
            }
        }

        public string EmpAmountPaidTextBox
        {
            get
            {
                return txtbAmountpaid.Text;
            }
            set
            {
                txtbAmountpaid.Text = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PaymentPresenter paypresenter = new PaymentPresenter(this, new PaymentModel());
            paypresenter.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PaymentPresenter paypresenter = new PaymentPresenter(this, new PaymentModel());
            paypresenter.BindModalView();

            
        }
    }
}
