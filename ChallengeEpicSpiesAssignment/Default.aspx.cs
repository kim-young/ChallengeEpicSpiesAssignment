using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeEpicSpiesAssignment
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                PreviousEndDateCalendar.SelectedDate = DateTime.Today;
                StartDateCalendar.SelectedDate = DateTime.Today.AddDays(14);
                EndDateCalendar.SelectedDate = DateTime.Today.AddDays(21);
            }
            Page.MaintainScrollPositionOnPostBack = true;
        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            //2 weeks of resting time
            TimeSpan totalRestDays = StartDateCalendar.SelectedDate.Subtract(PreviousEndDateCalendar.SelectedDate);

            if (totalRestDays.TotalDays < 14)
            {
                resultLabel.Text = "ERROR: There must be total rest time of 14 days or 2 weeks.";
                StartDateCalendar.SelectedDate = PreviousEndDateCalendar.SelectedDate.AddDays(14);
                return;
            }


            // Spies cost $500 per day
            TimeSpan totalDurationOfAssignment = EndDateCalendar.SelectedDate.Subtract(StartDateCalendar.SelectedDate);
            double totalCost;

            if (totalDurationOfAssignment.TotalDays > 21)
            {
                totalCost = (totalDurationOfAssignment.TotalDays * 500) + 1000;
            }
            else
            {
                totalCost = totalDurationOfAssignment.TotalDays * 500;
            }

            resultLabel.Text = String.Format("Assignment of {0} to assignment {1} is authorized. Budget total: {2:C}", 
                SpyNameTextBox.Text, 
                NewAssignmentTextBox.Text, 
                totalCost);
        }
    }
}