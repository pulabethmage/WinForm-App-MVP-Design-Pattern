using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test01_PulasthiBethmage.View;
using Test01_PulasthiBethmage.Model;
using System.Data.SqlClient;

namespace Test01_PulasthiBethmage.Presenter
{
    public class PaymentPresenter
    {
        IPaymentView _pView;
        IPaymentModel _pModel;

        public PaymentPresenter(IPaymentView PView, IPaymentModel PModel)
        {
            _pView = PView;
            _pModel = PModel;
        }

         public void BindModalView()
        {
            List<String> ls = _pModel.setInfo();
            _pView.EmpFirstNameLabel = ls[0];
            _pView.EmpLastNameLabel = ls[1];
            _pView.EmpContactNoLabel = ls[2];
            _pView.EmpAmountPaidLabel = ls[3];
            _pView.EmpPointsLabel = ls[4];
        }

         // Inserting data to database table 
         string connection =
           @"Data Source=localhost\SQLEXPRESS;Database=TestDatabase;Trusted_Connection=True;User Id=sa;Password=12345;";
         public void Save()
         {
             SqlConnection con = new SqlConnection(connection);
             SqlCommand cmd = con.CreateCommand();
             cmd.CommandText = "INSERT INTO test01_paymentdetails(firstName,lastName," +
               "contactNo,amountPaid)VALUES(@FirstName,@LastName,@ContactNumber,@AmountPaid)";        
             cmd.Parameters.AddWithValue("@FirstName", _pView.EmpFirstNameTextBox);
             cmd.Parameters.AddWithValue("@LastName", _pView.EmpLastNameTextBox);
             cmd.Parameters.AddWithValue("@ContactNumber", _pView.EmContactNoTextBox);
             cmd.Parameters.AddWithValue("@AmountPaid", float.Parse(_pView.EmpAmountPaidTextBox));
             try
             {
                 con.Open();
                 cmd.ExecuteNonQuery();
                 
                 //Calculating Points
                 if (100 <= int.Parse(_pView.EmpAmountPaidTextBox) && int.Parse(_pView.EmpAmountPaidTextBox) <200)
                 {
                     _pView.EmpPointsLabel = "1 Point";
                 }
                 else if (200 <= int.Parse(_pView.EmpAmountPaidTextBox) && int.Parse(_pView.EmpAmountPaidTextBox) < 300)
                 {
                     _pView.EmpPointsLabel = "2 Point";
                 }
                 else if (300 <= int.Parse(_pView.EmpAmountPaidTextBox) && int.Parse(_pView.EmpAmountPaidTextBox) < 400)
                 {
                     _pView.EmpPointsLabel = "3 Point";
                 }
                 else if (400 <= int.Parse(_pView.EmpAmountPaidTextBox) && int.Parse(_pView.EmpAmountPaidTextBox) < 500)
                 {
                     _pView.EmpPointsLabel = "4 Point";
                 }
                 else if (500 <= int.Parse(_pView.EmpAmountPaidTextBox))
                 {
                     _pView.EmpPointsLabel = "5 Point";
                 }
                
             }
             catch (SqlException ex)
             {

                 throw ex;
             }
             finally
             {
                 con.Close();
             }
         }

    }
}
