using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Age_Determiner
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack==false)
            {
                Panel1.Visible=false;
            } 
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //DateTime birthdate = Convert.ToDateTime(txtbox5.Text);

            //Declaring the variables
            var mbirthdate = this.txtbox5.Text;

            //parsing the mbirthdate to datetime using DateTime.ParseExact
            DateTime birthdate = DateTime.ParseExact(mbirthdate,"MM/dd/yyyy",null);
            
            //declaring variables
            var ageinyears = birthdate.Year;
            var MonthofBirth = birthdate.Month;
            var DayofBirth = birthdate.Day;

            //to calc the total months of birth, multiply ageinyears by 12 bcoz 12months make a year
            //to calc the total days  of birth, multiply ageinyears by 365 coz 365days make a year 
            var TotalMonthsofBirth = ageinyears * 12;
            var TotalDaysofBirth = ageinyears * 365;
            
            //calc the total age in months,days and years
            var ActualMonthsofBirth = (TotalMonthsofBirth - MonthofBirth);
            var ActualDaysOfBirth = (TotalDaysofBirth - DayofBirth);
            var ActualageInYears = (DateTime.Now.Year - ageinyears);

            //printing the results on the screen
            this.txtbox1.Text = ActualDaysOfBirth.ToString();
            this.txtbox2.Text = ActualMonthsofBirth.ToString();
            this.txtbox3.Text = ActualageInYears.ToString();

            this.Panel1.Visible = true;

            //DateTime birthdate = new DateTime(this.txtbox5);
            //DateTime today = DateTime.Today;

            //int year = birthdate.Year;
            //int month = birthdate.Month;
            //int day = birthdate.Day;

            //TimeSpan timespan = DateTime.Today.Subtract(birthdate);
            //int ageday = (today.Day - birthdate.Day);
            //int agemonth = (today.Month - birthdate.Month);
            //int ageyear = (today.Year - birthdate.Year);
            //int ageinMonths = (ageyear * 12);
            //int formula = (12 - birthdate.Month);
            //int ageindays = (ageyear * 365);
            //int formula2 = (365 - birthdate.Day);

            //this.txtbox1.Text = ageday.ToString();
            //this.txtbox2.Text = agemonth.ToString();

            //this.txtbox1.Text = formula2.ToString();
            //this.txtbox2.Text = formula.ToString();
            //this.txtbox3.Text = ageyear.ToString(); 





            //int year, month, day;

            //declaring constant 
            //const int currentYear = 2019;
        
            
            //var dobyear = int.Parse(txtbox3.Text);
            //double yearsOld = (currentYear - dobyear);
            //this.txtbox4.Text = yearsOld.ToString();

            //var monthsOld = int.Parse(txtbox2.Text);

            //this.txtbox4.Text = yearsOld.ToString();

            //var daysOld = int.Parse(txtbox1.Text);
            //this.txtbox4.Text = daysOld.ToString();




        }
    }
}